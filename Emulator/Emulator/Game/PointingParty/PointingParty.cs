using Emulator.GameRelated.Interfaces;
using Emulator.PlayerRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.GameRelated.PointingPartyRelated
{
    public class PointingParty : Game, IScorable
    {
        bool gameFinished;

        /// <summary>
        /// Creates a new PointingParty game
        /// </summary>
        /// <param name="teams"></param>
        public PointingParty(List<Team> teams) : base(teams)
        {
            gameFinished = false;
        }
        public override bool GameOver { get { return gameFinished; } set { gameFinished = value; } }
        public override Team Winner { get; set; }
        public override bool Draw { get; set; }

        public override void Reset(IEnumerable<Team> teams)
        {
            gameFinished = false;
        }

        /// <summary>
        /// Returns the game score
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public int Score(int points)
        {
            return points * 1000;
        }

        internal override List<IComparable<object>> FillOptions()
        {
            List<IComparable<object>> list = new List<IComparable<object>>();
            for (int i = 0; i <= 100; i++)
                list.Add(new Integer(i));
            return list;
        }

        internal override void Modify(IComparable<object> step)
        {
            var integer = (Integer)step;
            int points = Score(integer.Value);
            Current.Score = points;
        }
    }
    struct Integer : IComparable<object>
    {
        /// <summary>
        /// Creates a new Integer
        /// </summary>
        /// <param name="value"></param>
        public Integer(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Returns the integer value
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Returns a number related to integer values comparation
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(object other)
        {
            var otherNumber = (Integer)other;
            if (Value > otherNumber.Value)
                return 1;
            if (Value < otherNumber.Value)
                return -1;
            return 0;
        }
    }
}
