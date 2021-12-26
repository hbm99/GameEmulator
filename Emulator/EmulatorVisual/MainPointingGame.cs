using Emulator.TournamentRelated;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emulator.GameRelated.PointingPartyRelated;
using Emulator.PlayerRelated;

namespace EmulatorVisual
{
    public partial class MainPointingGame : Form
    {
        bool gamePlaying;
        Tournament tournament;
        CreateNormalTournament createNormalTournament;
        PointingParty pointingParty;
        int[] points;
        public MainPointingGame()
        {
            InitializeComponent();
            gamePlaying = false;
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            gamePlaying = true;
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            gamePlaying = false;
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            gamePlaying = false;
            tournament = null;
        }

        private void IndividualClasificationTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNormalTournament = new CreateNormalTournament(3);
            createNormalTournament.ShowDialog();
            if (createNormalTournament.Tournament == null)
                return;
            tournament = createNormalTournament.Tournament;
            pointingParty = (PointingParty)tournament.Match.Game;
            createNormalTournament.Close();
            points = new int[tournament.Teams.Count];
        }

        private void TimerPointingParty_Tick(object sender, EventArgs e)
        {
            if (!gamePlaying) 
                return;

            tournament.Execute();

            for (int i = 0; i < tournament.Teams.Count; i++) 
                points[i] = tournament.Teams[i].Score;

            dataGridViewTeamPoints.DataSource = SortByPoints(points).ToArray();

            if (tournament.IsOver)
            {
                gamePlaying = false;
                tournament = null;
            }
        }
        private List<Tuple<int, Team, int>> SortByPoints(int[] points)
        {
            List<Tuple<int, Team, int>> results = new List<Tuple<int, Team, int>>();
            int[] pointsAux = new int[points.Length];
            for (int i = 0; i < points.Length; i++)
                pointsAux[i] = points[i];

            int k = 1;
            while (results.Count != pointsAux.Length)
            {
                int max = int.MinValue;
                int index = -1;
                for (int i = 0; i < pointsAux.Length; i++)
                {
                    if (pointsAux[i] > max)
                    {
                        max = pointsAux[i];
                        index = i;
                    }
                }
                pointsAux[index] = -1;
                results.Add(new Tuple<int, Team, int>(k++, tournament.Teams[index], Math.Max(max, 0)));
            }
            return results;
        }
    }
}
