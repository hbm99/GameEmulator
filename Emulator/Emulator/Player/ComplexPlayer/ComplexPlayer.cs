using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.PlayerRelated.ComplexPlayer
{
    abstract class ComplexPlayer : Player
    {
        protected ComplexPlayer(string id) : base(id)
        {
        }
    }
}
