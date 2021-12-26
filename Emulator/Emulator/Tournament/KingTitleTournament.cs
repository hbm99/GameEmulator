using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated.TicTacToeRelated;
using Emulator.MatchRelated;
using Emulator.PlayerRelated;

namespace Emulator.TournamentRelated
{
    public class KingTitleTournament : Tournament
    {
        Team champion;
        Team initialChampion;
        int teamIndex;

        /// <summary>
        /// Creates a new KingTitleTournament
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="match"></param>
        /// <param name="actualChampion"></param>
        public KingTitleTournament(List<Team> teams, Match match, Team actualChampion) : base(teams, match, 1)
        {
            champion = actualChampion;
            initialChampion = actualChampion;
            teamIndex = 0;
        }

        public override Match Match => match;

        public override bool IsOver => teamIndex == teams.Count;

        public override void Execute()
        {
            if (match.MatchToReset) 
            {
                List<Team> matchList = new List<Team>() { champion, teams[teamIndex] };
                game.Reset(matchList);
                match.Reset(matchList, game, 1);
            }

            match.Execute();

            if (Match.Results != null && match.Results.Item1 != null)
            {
                match.MatchToReset = true;
                champion = match.Results.Item1;
                teamIndex++;
                if (IsOver)
                {
                    Results = new List<Tuple<int, Team, int>>();
                    int resultsOrder = 1;
                    Results.Add(new Tuple<int, Team, int>(resultsOrder++, champion, 1));
                    foreach (var item in teams)
                    {
                        if (Equals(item, champion))
                            continue;
                        Results.Add(new Tuple<int, Team, int>(resultsOrder++, item, 0));
                    }

                    if (!teams.Contains(initialChampion) && !Equals(Results[0].Item2, initialChampion))
                        Results.Add(new Tuple<int, Team, int>(resultsOrder++, initialChampion, 0));
                    return;
                }
            }
        }
    }
}
