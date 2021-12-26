using Emulator.GameRelated.PointingPartyRelated;
using Emulator.GameRelated.TicTacToeRelated;
using Emulator.MatchRelated;
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
    public partial class CreateNormalTournament : Form
    {
        string _teamName;
        string _playerName;
        int maxRoundSize;
        List<Player> playerList;
        List<Team> teamList;
        int tournamentType;
        int matchTeams;
        private Team champion;

        public CreateNormalTournament(int tournamentType)
        {
            InitializeComponent();
            if (tournamentType != 1)
            {
                labelMatchTeams.Hide();
                numericUpDownMatchTeams.Hide();
            }
            if (tournamentType != 0)
            {
                labelMaxRoundSize.Hide();
                numericUpDownRoundSize.Hide();
            }
            _teamName = "";
            _playerName = "";
            playerList = new List<Player>();
            teamList = new List<Team>();
            maxRoundSize = 1;
            this.tournamentType = tournamentType;
        }

        public CreateNormalTournament(int tournamentType, Team champion) : this(tournamentType)
        {
            this.champion = champion;
        }

        public Tournament Tournament { get; private set; }

        private void TeamName_TextChanged(object sender, EventArgs e)
        {
            _teamName = teamName.Text;
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            if (!IsValid(teamName.Text)) 
                return;
            if (Exists(teamList, _teamName))
                _teamName = _teamName + "2";
            
            if (playerList.Count == 0)
            {
                MessageBox.Show("You had an error seting data. Try again seting the player first.", "Error");
                return;
            }
            Team team = new Team(_teamName, playerList.ToArray());
            teamList.Add(team);
            teamName.Clear();
            playerName.Clear();
            playerList.Clear();

            if (tournamentType == 4 && teamList.Count == 2)
            {
                buttonAddGreedyPlayer.Hide();
                buttonAddRandomPlayer.Hide();
                addTeamButton.Hide();
                playerName.Hide();
                teamName.Hide();
            }
        }

        private bool Exists(List<Team> teamList, string teamName)
        {
            foreach (var item in teamList)
                if (item.Id == teamName)
                    return true;
            return false;
        }

        private void PlayerName_TextChanged(object sender, EventArgs e)
        {
            _playerName = playerName.Text;
        }

        private void ButtonAddGreedyPlayer_Click(object sender, EventArgs e)
        {
            if (!IsValid(playerName.Text)) 
                return;
            Player greedyPlayer = new GreedyPlayer(_playerName);
            playerList.Add(greedyPlayer);
            playerName.Clear();
        }

        private void ButtonAddRandomPlayer_Click(object sender, EventArgs e)
        {
            if (!IsValid(playerName.Text))
                return;
            Player randomPlayer = new RandomPlayer(_playerName);
            playerList.Add(randomPlayer);
            playerName.Clear();
        }
        private bool IsValid(string textBox)
        {
            return textBox != default && textBox != "" && ContainsLetters(textBox);
        }

        private bool ContainsLetters(string textBox)
        {
            for (int i = 0; i < textBox.Length; i++)
                if (textBox[i] != ' ')
                    return true;
            return false;
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                Hide();
                _teamName = "";
                _playerName = "";
                playerList = new List<Player>();
                teamList = new List<Team>();
                maxRoundSize = 1;
                return;
            }
            switch (tournamentType)
            {
                case 0:
                    {
                        if (teamList.Count < 2)
                        {
                            MessageBox.Show("You had an error seting data. Try again adding the last team.", "Error");
                            return;
                        }
                        List<Team> firstMatchList = new List<Team>();
                        firstMatchList.Add(teamList[0]); firstMatchList.Add(teamList[1]);
                        Tournament = new LeagueTournament(teamList, new Match(firstMatchList, new TicTacToe(firstMatchList), maxRoundSize), maxRoundSize);
                    }
                    break;
                case 1:
                    //Tournament = new PlayOffTournament(teamList, new TicTacToe(teamList), maxRoundSize, matchTeams);
                    break;
                case 2:
                    {
                        List<Team> firstMatchList = new List<Team>() { champion, teamList[0] };
                        Tournament = new KingTitleTournament(teamList, new Match(firstMatchList, new TicTacToe(firstMatchList), 1), firstMatchList[0]);
                    }
                    break;
                case 3:
                    {
                        List<Team> matchList = new List<Team>();
                        matchList.Add(teamList[0]);
                        Tournament = new IndividualClasificationTournament(teamList, new Match(matchList, new PointingParty(matchList), 1));
                    }
                    break;
                case 4:
                    {
                        if (teamList.Count < 2)
                        {
                            MessageBox.Show("You had an error seting data. Try again adding the last team.", "Error");
                            return;
                        }
                        Tournament = new LeagueTournament(teamList, new Match(teamList, new TicTacToe(teamList), 1), 1);
                    }
                    break;
                default:
                    break;
            }
            Hide();
        }

        private bool IsValid()
        {
            return teamList.Count != 0;
        }

        private void NumericUpDownRoundSize_ValueChanged(object sender, EventArgs e)
        {
            maxRoundSize = (int)numericUpDownRoundSize.Value;
        }

        private void NumericUpDownMatchTeams_ValueChanged(object sender, EventArgs e)
        {
            matchTeams = (int)numericUpDownMatchTeams.Value;
        }
    }
}
