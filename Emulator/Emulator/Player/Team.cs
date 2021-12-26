using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.PlayerRelated
{
    public class Team
    {
        List<Player> players;
        int cursor;

        /// <summary>
        /// Creates a new Team
        /// </summary>
        /// <param name="players"></param>
        public Team(string id, params Player[] players)
        {
            this.players = players.ToList();
            Id = id;
            cursor = 0;
        }

        /// <summary>
        /// Returns team Id
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Returns current player
        /// </summary>
        internal Player Current { get; private set; }

        /// <summary>
        /// Returns the team score
        /// </summary>
        public int Score { get; internal set; }

        /// <summary>
        /// Modifies Current
        /// </summary>
        internal void NextPlayer()
        {
            Current = players[cursor % players.Count];
            cursor++;
        }

        public override string ToString()
        {
            return Id;
        }
    }


}
