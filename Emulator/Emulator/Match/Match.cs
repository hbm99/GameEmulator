using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated;
using Emulator.PlayerRelated;

namespace Emulator.MatchRelated
{
    public class Match
    {
        List<Team> teams;
        int winNumber;
        static int[] points;
        Game game;
        IEnumerator gameEnumerator;
       /// <summary>
       /// Returns a new instance of a Match
       /// </summary>
       /// <param name="teams"></param>
       /// <param name="game"></param>
       /// <param name="maxRoundSize"></param>
        public Match(List<Team> teams, Game game, int maxRoundSize)
        {
            this.teams = teams;
            winNumber = (maxRoundSize / 2) + 1;
            points = new int[teams.Count];
            this.game = game;
            gameEnumerator = game.GetEnumerator();
            MatchToReset = false;
            Results = null;
        }

        /// <summary>
        /// Returns the tournament game
        /// </summary>
        public Game Game => game;

        /// <summary>
        /// Returns the match teams
        /// </summary>
        public List<Team> MatchList => teams;

        internal void Reset(List<Team> teams, Game game, int maxRoundSize)
        {
            this.teams = teams;
            winNumber = (maxRoundSize / 2) + 1;
            points = new int[teams.Count];
            this.game = game;
            gameEnumerator = game.GetEnumerator();
            MatchToReset = false;
            Results = null;
        }

        /// <summary>
        /// Returns if the match needs to be reseted
        /// </summary>
        public bool MatchToReset { get; internal set; }

        /// <summary>
        /// Returns the team winner of the match
        /// </summary>
        public Team Winner
        {
            get
            {
                for (int i = 0; i < points.Length; i++)
                    if (points[i] == winNumber)
                        return teams[i];
                return null;
            }
        }

        /// <summary>
        /// Returns the loosers list of the match
        /// </summary>
        public List<Team> Loosers
        {
            get
            {
                List<Team> loosers = new List<Team>();
                foreach (var item in teams)
                    if (item != Winner)
                        loosers.Add(item);
                return loosers;
            }
        }

        /// <summary>
        /// Returns a tuple with the winner and looser(s) (Match info)
        /// </summary>
        public Tuple<Team, List<Team>> Results { get; private set; }

        /// <summary>
        /// Executes the match
        /// </summary>
        /// <returns></returns>
        internal void Execute()
        {
            gameEnumerator.MoveNext();

            var gameWinner = game.Winner;
            if (gameWinner != null)
                points[teams.IndexOf(gameWinner)]++;
            if (Winner != null)
                Results = new Tuple<Team, List<Team>>(Winner, Loosers);
            if (winNumber == 1 && game.Draw)
                Results = new Tuple<Team, List<Team>>(null, null);
        }
    }
}
