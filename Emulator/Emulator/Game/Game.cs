using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulator.GameRelated.Interfaces;
using Emulator.PlayerRelated;

namespace Emulator.GameRelated
{
    public abstract class Game : IEnumerable<Team>
    {
        protected IEnumerable<Team> teams;

        /// <summary>
        /// Creates a new Game
        /// </summary>
        /// <param name="teams"></param>
        protected Game(IEnumerable<Team> teams)
        {
            this.teams = teams;
        }

        /// <summary>
        /// Resets the Game values
        /// </summary>
        /// <param name="teams"></param>
        public abstract void Reset(IEnumerable<Team> teams);

        public IEnumerator<Team> GetEnumerator()
        {
            return new GameEnumerator(teams.GetEnumerator(), this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Returns if the game is playing
        /// </summary>
        public abstract bool GameOver { get; set; }

        /// <summary>
        /// Returns the game winner
        /// </summary>
        public abstract Team Winner { get; set; }

        /// <summary>
        /// Returns if the game is draw
        /// </summary>
        public abstract bool Draw { get; set; }

        /// <summary>
        /// Returns the current Team
        /// </summary>
        public Team Current { get; private set; }

        /// <summary>
        /// Modifies the game status
        /// </summary>
        /// <param name="step"></param>
        internal abstract void Modify(IComparable<object> step);

        /// <summary>
        /// Returns the options a player can reproduce
        /// </summary>
        /// <returns></returns>
        internal abstract List<IComparable<object>> FillOptions();
       
        /// <summary>
        /// Class for the Game enumerator
        /// </summary>
        class GameEnumerator : IEnumerator<Team>
        {
            IEnumerator<Team> enumerator;
            Team current;
            Game game;
            bool gamePlaying;
            public GameEnumerator(IEnumerator<Team> enumerator, Game game)
            {
                this.enumerator = enumerator;
                gamePlaying = false;
                this.game = game;
            }

            public Team Current
            {
                get
                {
                    if (!gamePlaying)
                        throw new ArgumentException("No Started Game");
                    return current;
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }
            /// <summary>
            /// Returns the game main execution by changing the playing team
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                gamePlaying = true;
                if (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    game.Current = current;
                    current.NextPlayer();
                    var actualPlayer = current.Current;
                    var step = actualPlayer.Play(game.FillOptions());
                    game.Modify(step);
                }
                else
                {
                    enumerator.Reset();
                    MoveNext();
                }
                if (game.GameOver)
                    return false;
                return true;
            }

            public void Reset()
            {
                gamePlaying = false;
            }
        }

    }
}
