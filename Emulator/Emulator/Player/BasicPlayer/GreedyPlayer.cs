using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated;

namespace Emulator.PlayerRelated.BasicPlayer
{
    public class GreedyPlayer : BasicPlayer
    {
        /// <summary>
        /// Creates a new instance of a GreedyPlayer
        /// </summary>
        /// <param name="id"></param>
        public GreedyPlayer(string id) : base(id)
        {
            random = new Random(DateTime.Now.Millisecond);
        }
        /// <summary>
        /// Returns the step decided by the GreedyPlayer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="steps"></param>
        /// <returns></returns>
        public override T Play<T>(List<T> steps)
        {
            T best = steps[0];
            for (int i = 1; i < steps.Count; i++)
                if (best.CompareTo(steps[i]) < 0)
                    best = steps[i];
            return best;
        }
    }
}
