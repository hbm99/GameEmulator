using Emulator.PlayerRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.GameRelated.Interfaces
{
    interface IBoard
    {
        /// <summary>
        /// Returns the game board
        /// </summary>
        Team[,] Board { get; set; }

        /// <summary>
        /// Returns rows direction array
        /// </summary>
        int[] DirectionRow { get; }

        /// <summary>
        /// Returns columns direction array
        /// </summary>
        int[] DirectionCol { get; }

        /// <summary>
        /// Returns rows amount 
        /// </summary>
        int RowsCount { get; }

        /// <summary>
        /// Returns columns amount
        /// </summary>
        int ColumnsCount { get; }

        /// <summary>
        /// Returns the game registry
        /// </summary>
        /// <returns></returns>
        List<Tuple<string, string, Tuple<int, int>>> GameSteps { get; }
    }
}
