using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.GameRelated.Interfaces
{
    interface IScorable
    {
        /// <summary>
        /// Returns the game score
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        int Score(int points);
    }
}
