using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmulatorVisual
{
    public partial class GameOptions : Form
    {
        MainTicTacToe mainTTT;
        MainPointingGame mainPG;
        public GameOptions()
        {
            InitializeComponent();
            mainTTT = new MainTicTacToe();
            mainPG = new MainPointingGame();
        }

        private void ButtonOpenTicTacToe_Click(object sender, EventArgs e)
        {
            Hide();
            mainTTT.ShowDialog();
            Close();
        }

        private void ButtonPointingParty_Click(object sender, EventArgs e)
        {
            Hide();
            mainPG.ShowDialog();
            Close();
        }
    }
}
