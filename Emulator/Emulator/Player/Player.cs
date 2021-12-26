using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated;

namespace Emulator.PlayerRelated
{
    public abstract class Player
    {
        /// <summary>
        /// Creates a new Player
        /// </summary>
        /// <param name="id"></param>
        protected Player(string id)
        {
            Id = id;
        }
        /// <summary>
        /// Returns the Player ID 
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Returns the step to play
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="steps"></param>
        /// <returns></returns>
        public abstract T Play<T>(List<T> steps) where T : IComparable<T>;
    }
}
