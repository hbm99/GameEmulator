using Emulator.GameRelated.TicTacToeRelated;
using Emulator.PlayerRelated;
using Emulator.PlayerRelated.BasicPlayer;
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

namespace EmulatorVisual
{
    public partial class MainTicTacToe : Form
    {
        CreateNormalTournament createNormalTournament;
        Tournament tournament;
        bool tournamentPlaying;
        bool matchPlaying;
        bool gamePlaying;
        bool stepPlaying;
        int currentSignal;
        TicTacToe ttt;
        int[,] mask;
        Team champion;
        int notificationsLevel;
        List<Tuple<string,string>> matchResults;

        public MainTicTacToe()
        {
            InitializeComponent();
            tournamentPlaying = false;
            matchPlaying = false;
            gamePlaying = false;
            stepPlaying = false;
            currentSignal = 1;
            champion = new Team("Blue", new GreedyPlayer("Pedrito"));
            labelChampion.Text = champion.Id;
            notifyIconTicTacToe.Text = "You have been notified from TicTacToe";
            notifyIconTicTacToe.BalloonTipTitle = "TicTacToe Notification";
            notifyIconTicTacToe.Icon = SystemIcons.Application;
            notificationsLevel = 0;
            matchResults = new List<Tuple<string, string>>();
        }

        private void CreateNewLeagueTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetStuffs();
            createNormalTournament = new CreateNormalTournament(0);
            createNormalTournament.ShowDialog();
            if (createNormalTournament.Tournament == null)
                return;
            tournament = createNormalTournament.Tournament;
            ttt = (TicTacToe)tournament.Match.Game;
            createNormalTournament.Close();
            mask = new int[ttt.RowsCount, ttt.ColumnsCount];
        }

        private void CreateNewBeattheChampionTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetStuffs();
            createNormalTournament = new CreateNormalTournament(2, champion);
            createNormalTournament.ShowDialog();
            if (createNormalTournament.Tournament == null)
                return;
            tournament = createNormalTournament.Tournament;
            ttt = (TicTacToe)tournament.Match.Game;
            createNormalTournament.Close();
            mask = new int[ttt.RowsCount, ttt.ColumnsCount];
        }

        private void IndividualClasificationTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetStuffs();
            createNormalTournament = new CreateNormalTournament(3);
            createNormalTournament.ShowDialog();
            if (createNormalTournament.Tournament == null)
                return;
            tournament = createNormalTournament.Tournament;
            ttt = (TicTacToe)tournament.Match.Game;
            createNormalTournament.Close();
            mask = new int[ttt.RowsCount, ttt.ColumnsCount];
        }
        private void QuickMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetStuffs();
            createNormalTournament = new CreateNormalTournament(4);
            createNormalTournament.ShowDialog();
            if (createNormalTournament.Tournament == null)
                return;
            tournament = createNormalTournament.Tournament;
            ttt = (TicTacToe)tournament.Match.Game;
            createNormalTournament.Close();
            mask = new int[ttt.RowsCount, ttt.ColumnsCount];
        }

        private void TimerTicTacToe_Tick(object sender, EventArgs e)
        {
            if (tournamentPlaying)
            {
                if (!tournament.IsOver)
                {
                    tournament.Execute();

                    ttt = (TicTacToe)tournament.Match.Game;
                    pictureBoxTicTacToe.Refresh();

                    if (tournament.IsOver)
                    {
                        tournamentPlaying = matchPlaying = gamePlaying = stepPlaying = false;
                        matchResults.Add(new Tuple<string, string>(tournament.Match.MatchList[0].Id + " vs " + tournament.Match.MatchList[1].Id, " => " + tournament.Match.Winner));
                        dataGridViewMatchResults.DataSource = matchResults.ToArray();
                        dataGridViewResults.DataSource = ResultsView(tournament.Results).ToArray();
                        dataGridViewStepByStep.DataSource = ttt.GameSteps.ToArray();
                        if (tournament.Winner != null)
                        {
                            champion = tournament.Winner;
                            labelChampion.Text = champion.Id;
                            notifyIconTicTacToe.BalloonTipText = "Tournament Finished. Winner: " + champion;
                            notifyIconTicTacToe.ShowBalloonTip(2000);
                        }
                        else
                        {
                            notifyIconTicTacToe.BalloonTipText = "Draw Tournament";
                            notifyIconTicTacToe.ShowBalloonTip(2000);
                        }
                        tournament = null;
                        //matchResults = new List<Tuple<string, string>>();
                        //dataGridViewMatchResults.DataSource = null;
                        //dataGridViewResults.DataSource = null;
                        //dataGridViewStepByStep.DataSource = null;
                        return;
                    }

                    if (ttt != null && ttt.GameOver)
                    {
                        if (notificationsLevel >= 4)
                        {
                            notifyIconTicTacToe.BalloonTipText = "You finished a game.";
                            if (tournament.Match.Game.Winner != null)
                                notifyIconTicTacToe.BalloonTipText += " " + tournament.Match.Game.Winner.Id + " was the winner.";
                            notifyIconTicTacToe.ShowBalloonTip(800);
                        }
                        if (gamePlaying)
                            tournamentPlaying = gamePlaying = false;
                        mask = new int[ttt.RowsCount, ttt.ColumnsCount];
                        currentSignal = 1;
                        if (!tournament.Match.MatchToReset)
                            tournament.Match.Game.Reset(tournament.Match.MatchList);
                        else 
                        {
                            matchResults.Add(new Tuple<string, string>(tournament.Match.MatchList[0].Id + " vs " + tournament.Match.MatchList[1].Id, " => " + tournament.Match.Winner));
                            dataGridViewMatchResults.DataSource = matchResults.ToArray();
                            if (notificationsLevel >= 3)
                            {
                                notifyIconTicTacToe.BalloonTipText = "You finished a match.";
                                if (tournament.Match.Winner != null)
                                    notifyIconTicTacToe.BalloonTipText += " " + tournament.Match.Winner.Id + " was the winner.";
                                notifyIconTicTacToe.ShowBalloonTip(800);
                            }
                            if (matchPlaying)
                                tournamentPlaying = matchPlaying = false;
                        }
                    }
                }
                dataGridViewStepByStep.DataSource = ttt.GameSteps.ToArray();
                if (tournament.Results != null)
                    dataGridViewResults.DataSource = ResultsView(tournament.Results).ToArray();

                if (stepPlaying)
                    tournamentPlaying = stepPlaying = false;
            }
        }

        private List<Tuple<int, string, int>> ResultsView(List<Tuple<int, Team, int>> results)
        {
            List<Tuple<int, string, int>> resultsView = new List<Tuple<int, string, int>>();
            foreach (var item in results)
                resultsView.Add(new Tuple<int, string, int>(item.Item1, item.Item2.ToString(), item.Item3));
            return resultsView;
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            } 
            tournamentPlaying = true;
            if (notificationsLevel < 1) return;
            notifyIconTicTacToe.BalloonTipText = "You are in a tournament run.";
            notifyIconTicTacToe.ShowBalloonTip(2000);
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            tournamentPlaying = false;
            if (notificationsLevel < 1) return;
            notifyIconTicTacToe.BalloonTipText = "You paused a tournament run.";
            notifyIconTicTacToe.ShowBalloonTip(2000);
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            tournamentPlaying = false;
            //ttt = new TicTacToe(null);
            //dataGridViewResults.DataSource = null;
            //dataGridViewStepByStep.DataSource = null;
            //dataGridViewMatchResults.DataSource = null;
            //tournament = null;
            //matchResults = new List<Tuple<string, string>>();
            ResetStuffs();
            pictureBoxTicTacToe.Refresh();
            if (notificationsLevel < 1) return;
            notifyIconTicTacToe.BalloonTipText = "You stopped a tournament run.";
            notifyIconTicTacToe.ShowBalloonTip(2000);
        }
        private void ResetStuffs()
        {
            ttt = new TicTacToe(null);
            dataGridViewResults.DataSource = null;
            dataGridViewStepByStep.DataSource = null;
            dataGridViewMatchResults.DataSource = null;
            tournament = null;
            matchResults = new List<Tuple<string, string>>();
        }

        private void PictureBoxTicTacToe_Paint(object sender, PaintEventArgs e)
        {
            if (Equals(ttt, default(TicTacToe)))
                return;

            Graphics graphics = e.Graphics;
            int dim = 30;

            pictureBoxTicTacToe.Height = ttt.RowsCount * dim + 1;
            pictureBoxTicTacToe.Width = ttt.ColumnsCount * dim + 1;

            for (int i = 0; i < ttt.RowsCount; i++)
            {
                for (int j = 0; j < ttt.ColumnsCount; j++)
                {
                    if (ttt.Board[i, j] == default(Team))
                        graphics.DrawImage(Image.FromFile("resources\\empty.png"), j * dim, i * dim, dim, dim);
                    else
                    {
                        if (currentSignal == 1)
                        {
                            if (mask[i, j] != 0)
                            {
                                if (mask[i, j] == 1)
                                    graphics.DrawImage(Image.FromFile("resources\\xx.png"), j * dim, i * dim, dim, dim);
                                else
                                    graphics.DrawImage(Image.FromFile("resources\\00.png"), j * dim, i * dim, dim, dim);
                            }
                            else
                            {
                                graphics.DrawImage(Image.FromFile("resources\\xx.png"), j * dim, i * dim, dim, dim);
                                mask[i, j] = currentSignal;
                                currentSignal++;
                            }
                        }
                        else
                        {
                            if (mask[i, j] != 0)
                            {
                                if (mask[i, j] == 1)
                                    graphics.DrawImage(Image.FromFile("resources\\xx.png"), j * dim, i * dim, dim, dim);
                                else
                                    graphics.DrawImage(Image.FromFile("resources\\00.png"), j * dim, i * dim, dim, dim);
                            }
                            else
                            {
                                graphics.DrawImage(Image.FromFile("resources\\00.png"), j * dim, i * dim, dim, dim);
                                mask[i, j] = currentSignal;
                                currentSignal--;
                            }
                        }
                    }
                }
            }
        }

        private void PlayMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            tournamentPlaying = true;
            matchPlaying = true;
            if (notificationsLevel < 3) return;
            notifyIconTicTacToe.BalloonTipText = "You are in a match run.";
            notifyIconTicTacToe.ShowBalloonTip(2000);
        }

        private void PlayGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            tournamentPlaying = true;
            gamePlaying = true;
            if (notificationsLevel < 4) return;
            notifyIconTicTacToe.BalloonTipText = "You are in a game run.";
            notifyIconTicTacToe.ShowBalloonTip(2000);
        }

        private void PlayStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournament == null)
            {
                MessageBox.Show("You must set a tournament first.", "Error");
                return;
            }
            tournamentPlaying = true;
            stepPlaying = true;
            if (notificationsLevel < 5) return;
            notifyIconTicTacToe.BalloonTipText = "You are in a step run.";
            notifyIconTicTacToe.ShowBalloonTip(2000);
        }

        private void NumericUpDownTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            timerTicTacToe.Interval = (int)numericUpDownTimerInterval.Value * 1000;
            if (numericUpDownTimerInterval.Value == 1)
                labelSeconds.Text = "second";
            else
                labelSeconds.Text = "seconds";
        }

        private void NumericUpDownNotificationsIntensity_ValueChanged(object sender, EventArgs e)
        {
            notificationsLevel = (int)numericUpDownNotificationsIntensity.Value;
            switch (notificationsLevel)
            {
                case 0:
                    labelNotificationsDescription.Text = "(Basic Notifications)";
                    break;
                case 1:
                    labelNotificationsDescription.Text = "(+ Basic Execution Notifications)";
                    break;
                case 2:
                    labelNotificationsDescription.Text = "(+ Tournament Notifications)";
                    break;
                case 3:
                    labelNotificationsDescription.Text = "(+ Match Notifications)";
                    break;
                case 4:
                    labelNotificationsDescription.Text = "(+ Game Notifications)";
                    break;
                case 5:
                    labelNotificationsDescription.Text = "(+ Step Notifications)";
                    break;
            }
        }
    }
}
