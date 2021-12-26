using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.PlayerRelated;
using Emulator.GameRelated.Interfaces;

namespace Emulator.GameRelated.TicTacToeRelated
{
    public class TicTacToe : Game, IBoard
    {

        /// <summary>
        /// Creates a new TicTacToe
        /// </summary>
        /// <param name="teams"></param>
        public TicTacToe(List<Team> teams) : base(teams)
        {
            Board = new Team[3, 3];
            GameSteps = new List<Tuple<string, string, Tuple<int, int>>>();
        }

        /// <summary>
        /// Returns the teams in the game
        /// </summary>
        public List<Team> Teams => (List<Team>)teams;



        public override bool GameOver { get { return Draw || Winner != null; } set { } }

        public override Team Winner
        {
            get
            {
                for (int i = 0; i < RowsCount; i++)
                    for (int j = 0; j < ColumnsCount; j++)
                        if (Board[i, j] != null)
                            for (int d = 0; d < DirectionRow.Length; d++)
                                if (SameTeamInDirection(i, j, DirectionRow[d], DirectionCol[d]) >= 3)
                                    return Board[i, j];
                return null;
            }
            set { }
        }

        /// <summary>
        /// Returns the team count heading a direction
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="dr"></param>
        /// <param name="dc"></param>
        /// <returns></returns>
        private int SameTeamInDirection(int i, int j, int dr, int dc)
        {
            int count = 1;
            while (IsInside(i + count * dr, j + count * dc) && Board[i, j] == Board[i + count * dr, j + count * dc])
                count++;
            return count;
        }

        /// <summary>
        /// Returns if the position is inside the board
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        internal bool IsInside(int x, int y)
        {
            return x >= 0 && x < RowsCount && y >= 0 && y < ColumnsCount;
        }

        public override bool Draw
        {
            get
            {
                return IsFull() && Winner == null;
            }
            set { }
        }

        /// <summary>
        /// Returns if the board is full
        /// </summary>
        /// <returns></returns>
        private bool IsFull()
        {
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    if (Board[i, j] == null)
                        return false;
            return true;
        }

        public int RowsCount => Board.GetLength(0);

        public int ColumnsCount => Board.GetLength(1);

        public int[] DirectionRow => new int[] { -1, -1, 0, 1, 1, 1, 0, -1 };

        public int[] DirectionCol => new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };

        public List<Tuple<string, string, Tuple<int, int>>> GameSteps { get; private set; }
        public Team[,] Board { get; set; }

        internal override List<IComparable<object>> FillOptions()
        {
            List<IComparable<object>> list = new List<IComparable<object>>();
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    if (Board[i, j] == null)
                        list.Add(new Position(i, j, this));
            return list;
        }

        internal override void Modify(IComparable<object> step)
        {
            var pos = (Position)step;
            int x = pos.Tuple.Item1;
            int y = pos.Tuple.Item2;
            Board[x, y] = Current;
            GameSteps.Add(new Tuple<string, string, Tuple<int, int>>(Current.Id, Current.Current.Id, new Tuple<int, int>(x, y)));
        }

        public override void Reset(IEnumerable<Team> teams)
        {
            this.teams = teams;
            GameOver = false;
            Winner = null;
            Draw = false;
            Board = new Team[3, 3];
            GameSteps = new List<Tuple<string, string, Tuple<int, int>>>();
        }
    }
    public struct Position : IComparable<object>
    {
        Tuple<int, int> tuple;
        TicTacToe game;
        Tuple<int, int>[] bannedPositions;
        int[] bannedDirectionsIndexes;

        /// <summary>
        /// Creates a new Position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="game"></param>
        public Position(int x, int y, TicTacToe game)
        {
            tuple = new Tuple<int, int>(x, y);
            this.game = game;
            bannedPositions = new Tuple<int, int>[] { new Tuple<int, int>(0, 1), new Tuple<int, int>(1, 0), new Tuple<int, int>(2, 1), new Tuple<int, int>(1, 2) };
            bannedDirectionsIndexes = new int[] { 1, 3, 5, 7 };
        }

        /// <summary>
        /// Returns the position tuple
        /// </summary>
        public Tuple<int, int> Tuple => tuple;

        /// <summary>
        /// Returns the max number in line of the team in any direction
        /// </summary>
        public int MaxInLine
        {
            get
            {
                int max = int.MinValue;
                bool tupleIsBanned = bannedPositions.Contains(tuple);
                for (int d = 0; d < game.DirectionRow.Length; d++)
                {
                    if (tupleIsBanned && bannedDirectionsIndexes.Contains(d)) 
                        continue;
                    int teamsInDirection = SameTeamInDirection(tuple.Item1, tuple.Item2, game.DirectionRow[d], game.DirectionCol[d]);
                    if (teamsInDirection > max)
                        max = teamsInDirection;
                }
                return max;
            }
        }

        /// <summary>
        /// Returns the team count heading a direction
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="dr"></param>
        /// <param name="dc"></param>
        /// <returns></returns>
        private int SameTeamInDirection(int i, int j, int dr, int dc)
        {
            int count = 1;
            while (game.IsInside(i + count * dr, j + count * dc) && Equals(game.Current, game.Board[i + count * dr, j + count * dc])) 
                count++;
            
            return count;
        }

        /// <summary>
        /// Returns a number related to what team has more consecutive positions busy in line
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(object other)
        {
            var otherPosition = (Position)other;
            if (MaxInLine == otherPosition.MaxInLine)
                return 0;
            if (MaxInLine > otherPosition.MaxInLine)
                return 1;
            return -1;
        }
    }
}

