using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated;
using Emulator.GameRelated.TicTacToeRelated;
using Emulator.MatchRelated;
using Emulator.PlayerRelated;

namespace Emulator.TournamentRelated
{
    public class LeagueTournament : Tournament
    {
        int teamIndex;
        int opponentTeam;
        int[] points;
        List<Team> matchList;

        /// <summary>
        /// Creates a new instance of the LeagueTournament
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="game"></param>
        /// <param name="maxRoundSize"></param>
        public LeagueTournament(List<Team> teams, Match match, int maxRoundSize) : base(teams, match, maxRoundSize)
        {
            MatchTeams = 2;
            teamIndex = 0;
            opponentTeam = teamIndex + 1;
            points = new int[teams.Count];
            this.match = match;
        }
        public override bool IsOver => teamIndex == teams.Count - 1;

        public override Match Match => match;

        public override void Execute()
        {
            if (match.MatchToReset)
            {
                game.Reset(matchList);
                match.Reset(matchList, game, maxRoundSize);
            }

            match.Execute();

            var tupleResults = match.Results;
            if (tupleResults != null && tupleResults.Item1 != null)
            {
                points[teams.IndexOf(tupleResults.Item1)] += 3;

                opponentTeam++;
                if (opponentTeam == teams.Count) 
                {
                    teamIndex++;
                    if (IsOver)
                    {
                        Results = SortByPoints(points);
                        return;
                    }
                    opponentTeam = teamIndex + 1;
                }

                matchList = new List<Team>();
                matchList.Add(teams[teamIndex]);
                matchList.Add(teams[opponentTeam]);
                match.MatchToReset = true;
            }
            else if (tupleResults != null && tupleResults.Item1 == null && tupleResults.Item2 == null)  
            {
                foreach (var item in matchList)
                    points[teams.IndexOf(item)]++;

                opponentTeam++;
                if (opponentTeam == teams.Count)
                {
                    teamIndex++;
                    if (IsOver)
                    {
                        Results = SortByPoints(points);
                        return;
                    }
                    opponentTeam = teamIndex + 1;
                }

                matchList = new List<Team>();
                matchList.Add(teams[teamIndex]);
                matchList.Add(teams[opponentTeam]);
                match.MatchToReset = true;
            }
            Results = SortByPoints(points);
        }
    }
}
