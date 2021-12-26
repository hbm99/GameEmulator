using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.PlayerRelated.BasicPlayer
{
    public abstract class BasicPlayer : Player
    {
        protected Random random;

        /// <summary>
        /// Creates a new BasicPlayer
        /// </summary>
        /// <param name="id"></param>
        protected BasicPlayer(string id) : base(id)
        {
        }
    }
}
