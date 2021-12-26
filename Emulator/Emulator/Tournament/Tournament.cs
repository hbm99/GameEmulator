using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated;
using Emulator.MatchRelated;
using Emulator.PlayerRelated;

namespace Emulator.TournamentRelated
{
    public abstract class Tournament
    {
        protected List<Team> teams;
        protected int maxRoundSize;
        protected Game game;
        protected Match match;
        /// <summary>
        /// Creates a new Tournament
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="game"></param>
        /// <param name="maxRoundSize"></param>
        public Tournament(List<Team> teams, Match match, int maxRoundSize)
        {
            this.teams = teams;
            this.match = match;
            this.maxRoundSize = maxRoundSize;
            game = match.Game;
        }
        /// <summary>
        /// Returns the tournament teams
        /// </summary>
        public List<Team> Teams => teams;
        /// <summary>
        /// Returns the tournament match
        /// </summary>
        public abstract Match Match { get; }

        /// <summary>
        /// Returns tournament state
        /// </summary>
        public abstract bool IsOver { get; }

        /// <summary>
        /// Returns results of the tournament
        /// </summary>
        /// 
        public List<Tuple<int, Team, int>> Results { get; set; }

        /// <summary>
        /// Returns teams to match
        /// </summary>
        protected int MatchTeams { get; set; }

        /// <summary>
        /// Returns the Tournament Winner
        /// </summary>
        public Team Winner => Results[0].Item2;
        /// <summary>
        /// Executes the Tournament
        /// </summary>
        /// <returns></returns>
        public abstract void Execute();
        /// <summary>
        /// Returns an ordered table by points
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        protected List<Tuple<int, Team, int>> SortByPoints(int[] points)
        {
            List<Tuple<int, Team, int>> results = new List<Tuple<int, Team, int>>();
            int[] pointsAux = new int[points.Length];
            for (int i = 0; i < points.Length; i++)
                pointsAux[i] = points[i];

            int k = 1;
            while (results.Count != pointsAux.Length)
            {
                int max = int.MinValue;
                int index = -1;
                for (int i = 0; i < pointsAux.Length; i++)
                {
                    if (pointsAux[i] > max)
                    {
                        max = pointsAux[i];
                        index = i;
                    }
                }
                pointsAux[index] = -1;
                results.Add(new Tuple<int, Team, int>(k++, teams[index], Math.Max(max, 0)));
            }
            return results;
        }
    }
}
