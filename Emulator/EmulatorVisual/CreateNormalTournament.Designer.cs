namespace EmulatorVisual
{
    partial class CreateNormalTournament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNormalTournament));
            this.teamName = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.menuStripCreateNormalTournament = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerName = new System.Windows.Forms.TextBox();
            this.buttonAddGreedyPlayer = new System.Windows.Forms.Button();
            this.buttonAddRandomPlayer = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.numericUpDownRoundSize = new System.Windows.Forms.NumericUpDown();
            this.labelMaxRoundSize = new System.Windows.Forms.Label();
            this.labelMatchTeams = new System.Windows.Forms.Label();
            this.numericUpDownMatchTeams = new System.Windows.Forms.NumericUpDown();
            this.menuStripCreateNormalTournament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoundSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatchTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // teamName
            // 
            this.teamName.BackColor = System.Drawing.Color.Black;
            this.teamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teamName.Location = new System.Drawing.Point(85, 146);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(100, 28);
            this.teamName.TabIndex = 0;
            this.teamName.TextChanged += new System.EventHandler(this.TeamName_TextChanged);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.Gray;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTeamButton.Location = new System.Drawing.Point(542, 146);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(110, 28);
            this.addTeamButton.TabIndex = 1;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // menuStripCreateNormalTournament
            // 
            this.menuStripCreateNormalTournament.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStripCreateNormalTournament.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStripCreateNormalTournament.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCreateNormalTournament.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStripCreateNormalTournament.Location = new System.Drawing.Point(0, 0);
            this.menuStripCreateNormalTournament.Name = "menuStripCreateNormalTournament";
            this.menuStripCreateNormalTournament.Size = new System.Drawing.Size(744, 30);
            this.menuStripCreateNormalTournament.TabIndex = 2;
            this.menuStripCreateNormalTournament.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem
            // 
            this.youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem.Name = "youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem";
            this.youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem.Size = new System.Drawing.Size(1198, 26);
            this.youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem.Text = "You must add players first, then add the team when you have completed its name, t" +
    "he numeric size of each round, and, finally, click Done";
            // 
            // playerName
            // 
            this.playerName.BackColor = System.Drawing.Color.Black;
            this.playerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playerName.Location = new System.Drawing.Point(85, 82);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 28);
            this.playerName.TabIndex = 3;
            this.playerName.TextChanged += new System.EventHandler(this.PlayerName_TextChanged);
            // 
            // buttonAddGreedyPlayer
            // 
            this.buttonAddGreedyPlayer.BackColor = System.Drawing.Color.Gray;
            this.buttonAddGreedyPlayer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddGreedyPlayer.Location = new System.Drawing.Point(506, 64);
            this.buttonAddGreedyPlayer.Name = "buttonAddGreedyPlayer";
            this.buttonAddGreedyPlayer.Size = new System.Drawing.Size(188, 28);
            this.buttonAddGreedyPlayer.TabIndex = 4;
            this.buttonAddGreedyPlayer.Text = "Add Greedy Player";
            this.buttonAddGreedyPlayer.UseVisualStyleBackColor = false;
            this.buttonAddGreedyPlayer.Click += new System.EventHandler(this.ButtonAddGreedyPlayer_Click);
            // 
            // buttonAddRandomPlayer
            // 
            this.buttonAddRandomPlayer.BackColor = System.Drawing.Color.Gray;
            this.buttonAddRandomPlayer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddRandomPlayer.Location = new System.Drawing.Point(506, 98);
            this.buttonAddRandomPlayer.Name = "buttonAddRandomPlayer";
            this.buttonAddRandomPlayer.Size = new System.Drawing.Size(188, 28);
            this.buttonAddRandomPlayer.TabIndex = 5;
            this.buttonAddRandomPlayer.Text = "Add Random Player";
            this.buttonAddRandomPlayer.UseVisualStyleBackColor = false;
            this.buttonAddRandomPlayer.Click += new System.EventHandler(this.ButtonAddRandomPlayer_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Gray;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone.Location = new System.Drawing.Point(542, 248);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(110, 39);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // numericUpDownRoundSize
            // 
            this.numericUpDownRoundSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownRoundSize.Location = new System.Drawing.Point(229, 202);
            this.numericUpDownRoundSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRoundSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoundSize.Name = "numericUpDownRoundSize";
            this.numericUpDownRoundSize.Size = new System.Drawing.Size(40, 28);
            this.numericUpDownRoundSize.TabIndex = 7;
            this.numericUpDownRoundSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoundSize.ValueChanged += new System.EventHandler(this.NumericUpDownRoundSize_ValueChanged);
            // 
            // labelMaxRoundSize
            // 
            this.labelMaxRoundSize.AutoSize = true;
            this.labelMaxRoundSize.Location = new System.Drawing.Point(81, 204);
            this.labelMaxRoundSize.Name = "labelMaxRoundSize";
            this.labelMaxRoundSize.Size = new System.Drawing.Size(133, 22);
            this.labelMaxRoundSize.TabIndex = 8;
            this.labelMaxRoundSize.Text = "MaxRoundSize:";
            // 
            // labelMatchTeams
            // 
            this.labelMatchTeams.AutoSize = true;
            this.labelMatchTeams.Location = new System.Drawing.Point(81, 261);
            this.labelMatchTeams.Name = "labelMatchTeams";
            this.labelMatchTeams.Size = new System.Drawing.Size(116, 22);
            this.labelMatchTeams.TabIndex = 9;
            this.labelMatchTeams.Text = "MatchTeams:";
            // 
            // numericUpDownMatchTeams
            // 
            this.numericUpDownMatchTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownMatchTeams.Location = new System.Drawing.Point(229, 259);
            this.numericUpDownMatchTeams.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMatchTeams.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMatchTeams.Name = "numericUpDownMatchTeams";
            this.numericUpDownMatchTeams.Size = new System.Drawing.Size(40, 28);
            this.numericUpDownMatchTeams.TabIndex = 10;
            this.numericUpDownMatchTeams.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMatchTeams.ValueChanged += new System.EventHandler(this.NumericUpDownMatchTeams_ValueChanged);
            // 
            // CreateNormalTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 317);
            this.Controls.Add(this.numericUpDownMatchTeams);
            this.Controls.Add(this.labelMatchTeams);
            this.Controls.Add(this.labelMaxRoundSize);
            this.Controls.Add(this.numericUpDownRoundSize);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAddRandomPlayer);
            this.Controls.Add(this.buttonAddGreedyPlayer);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.menuStripCreateNormalTournament);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripCreateNormalTournament;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateNormalTournament";
            this.Text = "CreateNormalTournament";
            this.menuStripCreateNormalTournament.ResumeLayout(false);
            this.menuStripCreateNormalTournament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoundSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatchTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.MenuStrip menuStripCreateNormalTournament;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youMustAddPlayersFirstThenAddTheTeamWhenYouHaveCompletedItsNameToolStripMenuItem;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button buttonAddGreedyPlayer;
        private System.Windows.Forms.Button buttonAddRandomPlayer;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.NumericUpDown numericUpDownRoundSize;
        private System.Windows.Forms.Label labelMaxRoundSize;
        private System.Windows.Forms.Label labelMatchTeams;
        private System.Windows.Forms.NumericUpDown numericUpDownMatchTeams;
    }
}