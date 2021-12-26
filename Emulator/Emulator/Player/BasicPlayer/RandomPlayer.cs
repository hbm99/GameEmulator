using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated;

namespace Emulator.PlayerRelated.BasicPlayer
{
    public class RandomPlayer : BasicPlayer
    {
        /// <summary>
        /// Creates a new instance of a RandomPlayer
        /// </summary>
        /// <param name="id"></param>
        public RandomPlayer(string id) : base(id)
        {
            random = new Random(DateTime.Now.Millisecond);
        }
        /// <summary>
        /// Returns the step decided by the RandomPlayer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="steps"></param>
        /// <returns></returns>
        public override T Play<T>(List<T> steps)
        {
            int randomIndex = random.Next(steps.Count);
            return steps[randomIndex];
        }
    }
}
