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
    public partial class MainForm : Form
    {
        GameOptions gameOptions;
        Settings settings;
        public MainForm()
        {
            InitializeComponent();
            gameOptions = new GameOptions();
            settings = new Settings();
        }

        private void ButtonLoadGame_Click(object sender, EventArgs e)
        {
            Hide();
            gameOptions.ShowDialog();
            Close();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }
    }
}
