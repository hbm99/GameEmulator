using Emulator.GameRelated;
using Emulator.GameRelated.PointingPartyRelated;
using Emulator.MatchRelated;
using Emulator.PlayerRelated;
using System.Collections.Generic;

namespace Emulator.TournamentRelated
{
    public class IndividualClasificationTournament : Tournament
    {
        int[] points;
        int teamIndex;
        /// <summary>
        /// Creates a new instance of a IndividualClasificationTournament
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="game"></param>
        /// <param name="maxRoundSize"></param>
        public IndividualClasificationTournament(List<Team> teams, Match match) : base(teams, match, 1)
        {
            points = new int[teams.Count];
            teamIndex = 0;
        }

        public override bool IsOver => teamIndex == teams.Count;

        public override Match Match => match;

        public override void Execute()
        {
            match.Execute();

            teamIndex++;

            if (IsOver)
                return;

            List<Team> matchList = new List<Team>();
            matchList.Add(teams[teamIndex]);

            match = new Match(matchList, new PointingParty(matchList), 1);
        }
    }
}
