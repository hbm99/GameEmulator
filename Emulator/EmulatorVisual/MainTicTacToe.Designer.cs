namespace EmulatorVisual
{
    partial class MainTicTacToe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTicTacToe));
            this.menuStripTicTacToe = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewLeagueTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewBeattheChampionTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideForUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTicTacToe = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTicTacToe = new System.Windows.Forms.PictureBox();
            this.dataGridViewStepByStep = new System.Windows.Forms.DataGridView();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.labelChampionPresentation = new System.Windows.Forms.Label();
            this.labelChampion = new System.Windows.Forms.Label();
            this.numericUpDownTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.labelTimerInterval = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.notifyIconTicTacToe = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelNotificationsIntensity = new System.Windows.Forms.Label();
            this.numericUpDownNotificationsIntensity = new System.Windows.Forms.NumericUpDown();
            this.labelNotificationsDescription = new System.Windows.Forms.Label();
            this.labelGameSteps = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.dataGridViewMatchResults = new System.Windows.Forms.DataGridView();
            this.labelMatchResults = new System.Windows.Forms.Label();
            this.menuStripTicTacToe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicTacToe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStepByStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotificationsIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTicTacToe
            // 
            this.menuStripTicTacToe.BackColor = System.Drawing.Color.Gray;
            this.menuStripTicTacToe.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTicTacToe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTicTacToe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.executionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripTicTacToe.Location = new System.Drawing.Point(0, 0);
            this.menuStripTicTacToe.Name = "menuStripTicTacToe";
            this.menuStripTicTacToe.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripTicTacToe.Size = new System.Drawing.Size(1066, 25);
            this.menuStripTicTacToe.TabIndex = 0;
            this.menuStripTicTacToe.Text = "menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewTournamentToolStripMenuItem,
            this.quickMatchToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "Game";
            // 
            // createNewTournamentToolStripMenuItem
            // 
            this.createNewTournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewLeagueTournamentToolStripMenuItem,
            this.createNewBeattheChampionTournamentToolStripMenuItem});
            this.createNewTournamentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewTournamentToolStripMenuItem.Image")));
            this.createNewTournamentToolStripMenuItem.Name = "createNewTournamentToolStripMenuItem";
            this.createNewTournamentToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.createNewTournamentToolStripMenuItem.Text = "Create new Tournament";
            // 
            // createNewLeagueTournamentToolStripMenuItem
            // 
            this.createNewLeagueTournamentToolStripMenuItem.Name = "createNewLeagueTournamentToolStripMenuItem";
            this.createNewLeagueTournamentToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.createNewLeagueTournamentToolStripMenuItem.Text = "League Tournament";
            this.createNewLeagueTournamentToolStripMenuItem.Click += new System.EventHandler(this.CreateNewLeagueTournamentToolStripMenuItem_Click);
            // 
            // createNewBeattheChampionTournamentToolStripMenuItem
            // 
            this.createNewBeattheChampionTournamentToolStripMenuItem.Name = "createNewBeattheChampionTournamentToolStripMenuItem";
            this.createNewBeattheChampionTournamentToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.createNewBeattheChampionTournamentToolStripMenuItem.Text = "\"BeatTheChampion\" Tournament ";
            this.createNewBeattheChampionTournamentToolStripMenuItem.Click += new System.EventHandler(this.CreateNewBeattheChampionTournamentToolStripMenuItem_Click);
            // 
            // quickMatchToolStripMenuItem
            // 
            this.quickMatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quickMatchToolStripMenuItem.Image")));
            this.quickMatchToolStripMenuItem.Name = "quickMatchToolStripMenuItem";
            this.quickMatchToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.quickMatchToolStripMenuItem.Text = "Quick Match";
            this.quickMatchToolStripMenuItem.Click += new System.EventHandler(this.QuickMatchToolStripMenuItem_Click);
            // 
            // executionToolStripMenuItem
            // 
            this.executionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.playMatchToolStripMenuItem,
            this.playGameToolStripMenuItem,
            this.playStepToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.executionToolStripMenuItem.Name = "executionToolStripMenuItem";
            this.executionToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.executionToolStripMenuItem.Text = "Execution";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playToolStripMenuItem.Image")));
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.playToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // playMatchToolStripMenuItem
            // 
            this.playMatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playMatchToolStripMenuItem.Image")));
            this.playMatchToolStripMenuItem.Name = "playMatchToolStripMenuItem";
            this.playMatchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.playMatchToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.playMatchToolStripMenuItem.Text = "Play Match";
            this.playMatchToolStripMenuItem.Click += new System.EventHandler(this.PlayMatchToolStripMenuItem_Click);
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playGameToolStripMenuItem.Image")));
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.PlayGameToolStripMenuItem_Click);
            // 
            // playStepToolStripMenuItem
            // 
            this.playStepToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playStepToolStripMenuItem.Image")));
            this.playStepToolStripMenuItem.Name = "playStepToolStripMenuItem";
            this.playStepToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.playStepToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.playStepToolStripMenuItem.Text = "Play Step";
            this.playStepToolStripMenuItem.Click += new System.EventHandler(this.PlayStepToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseToolStripMenuItem.Image")));
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guideForUserToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // guideForUserToolStripMenuItem
            // 
            this.guideForUserToolStripMenuItem.Name = "guideForUserToolStripMenuItem";
            this.guideForUserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.guideForUserToolStripMenuItem.Text = "Guide for users";
            // 
            // timerTicTacToe
            // 
            this.timerTicTacToe.Enabled = true;
            this.timerTicTacToe.Interval = 1000;
            this.timerTicTacToe.Tick += new System.EventHandler(this.TimerTicTacToe_Tick);
            // 
            // pictureBoxTicTacToe
            // 
            this.pictureBoxTicTacToe.Location = new System.Drawing.Point(97, 163);
            this.pictureBoxTicTacToe.Name = "pictureBoxTicTacToe";
            this.pictureBoxTicTacToe.Size = new System.Drawing.Size(258, 258);
            this.pictureBoxTicTacToe.TabIndex = 1;
            this.pictureBoxTicTacToe.TabStop = false;
            this.pictureBoxTicTacToe.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxTicTacToe_Paint);
            // 
            // dataGridViewStepByStep
            // 
            this.dataGridViewStepByStep.AllowUserToAddRows = false;
            this.dataGridViewStepByStep.AllowUserToDeleteRows = false;
            this.dataGridViewStepByStep.AllowUserToResizeColumns = false;
            this.dataGridViewStepByStep.AllowUserToResizeRows = false;
            this.dataGridViewStepByStep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStepByStep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStepByStep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewStepByStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStepByStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStepByStep.ColumnHeadersVisible = false;
            this.dataGridViewStepByStep.Location = new System.Drawing.Point(490, 163);
            this.dataGridViewStepByStep.Name = "dataGridViewStepByStep";
            this.dataGridViewStepByStep.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewStepByStep.TabIndex = 2;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.ColumnHeadersVisible = false;
            this.dataGridViewResults.Location = new System.Drawing.Point(490, 334);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(240, 87);
            this.dataGridViewResults.TabIndex = 3;
            // 
            // labelChampionPresentation
            // 
            this.labelChampionPresentation.AutoSize = true;
            this.labelChampionPresentation.Location = new System.Drawing.Point(651, 83);
            this.labelChampionPresentation.Name = "labelChampionPresentation";
            this.labelChampionPresentation.Size = new System.Drawing.Size(79, 17);
            this.labelChampionPresentation.TabIndex = 4;
            this.labelChampionPresentation.Text = "Champion: ";
            // 
            // labelChampion
            // 
            this.labelChampion.AutoSize = true;
            this.labelChampion.Location = new System.Drawing.Point(736, 83);
            this.labelChampion.Name = "labelChampion";
            this.labelChampion.Size = new System.Drawing.Size(0, 17);
            this.labelChampion.TabIndex = 5;
            // 
            // numericUpDownTimerInterval
            // 
            this.numericUpDownTimerInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownTimerInterval.Location = new System.Drawing.Point(238, 81);
            this.numericUpDownTimerInterval.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTimerInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimerInterval.Name = "numericUpDownTimerInterval";
            this.numericUpDownTimerInterval.Size = new System.Drawing.Size(39, 24);
            this.numericUpDownTimerInterval.TabIndex = 6;
            this.numericUpDownTimerInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimerInterval.ValueChanged += new System.EventHandler(this.NumericUpDownTimerInterval_ValueChanged);
            // 
            // labelTimerInterval
            // 
            this.labelTimerInterval.AutoSize = true;
            this.labelTimerInterval.Location = new System.Drawing.Point(118, 83);
            this.labelTimerInterval.Name = "labelTimerInterval";
            this.labelTimerInterval.Size = new System.Drawing.Size(103, 17);
            this.labelTimerInterval.TabIndex = 7;
            this.labelTimerInterval.Text = "Timer Interval :";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(283, 83);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(51, 17);
            this.labelSeconds.TabIndex = 8;
            this.labelSeconds.Text = "second";
            // 
            // notifyIconTicTacToe
            // 
            this.notifyIconTicTacToe.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconTicTacToe.Text = "Tic Tac Toe Notification";
            this.notifyIconTicTacToe.Visible = true;
            // 
            // labelNotificationsIntensity
            // 
            this.labelNotificationsIntensity.AutoSize = true;
            this.labelNotificationsIntensity.Location = new System.Drawing.Point(67, 121);
            this.labelNotificationsIntensity.Name = "labelNotificationsIntensity";
            this.labelNotificationsIntensity.Size = new System.Drawing.Size(154, 17);
            this.labelNotificationsIntensity.TabIndex = 9;
            this.labelNotificationsIntensity.Text = "Notifications Intensity :";
            // 
            // numericUpDownNotificationsIntensity
            // 
            this.numericUpDownNotificationsIntensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownNotificationsIntensity.Location = new System.Drawing.Point(238, 119);
            this.numericUpDownNotificationsIntensity.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNotificationsIntensity.Name = "numericUpDownNotificationsIntensity";
            this.numericUpDownNotificationsIntensity.Size = new System.Drawing.Size(39, 24);
            this.numericUpDownNotificationsIntensity.TabIndex = 10;
            this.numericUpDownNotificationsIntensity.ValueChanged += new System.EventHandler(this.NumericUpDownNotificationsIntensity_ValueChanged);
            // 
            // labelNotificationsDescription
            // 
            this.labelNotificationsDescription.AutoSize = true;
            this.labelNotificationsDescription.Location = new System.Drawing.Point(283, 121);
            this.labelNotificationsDescription.Name = "labelNotificationsDescription";
            this.labelNotificationsDescription.Size = new System.Drawing.Size(133, 17);
            this.labelNotificationsDescription.TabIndex = 11;
            this.labelNotificationsDescription.Text = "(Basic Notifications)";
            // 
            // labelGameSteps
            // 
            this.labelGameSteps.AutoSize = true;
            this.labelGameSteps.Location = new System.Drawing.Point(487, 143);
            this.labelGameSteps.Name = "labelGameSteps";
            this.labelGameSteps.Size = new System.Drawing.Size(101, 17);
            this.labelGameSteps.TabIndex = 12;
            this.labelGameSteps.Text = "Game playing: ";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(487, 314);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(130, 17);
            this.labelResults.TabIndex = 13;
            this.labelResults.Text = "Tournament Table: ";
            // 
            // dataGridViewMatchResults
            // 
            this.dataGridViewMatchResults.AllowUserToAddRows = false;
            this.dataGridViewMatchResults.AllowUserToDeleteRows = false;
            this.dataGridViewMatchResults.AllowUserToResizeColumns = false;
            this.dataGridViewMatchResults.AllowUserToResizeRows = false;
            this.dataGridViewMatchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMatchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMatchResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewMatchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatchResults.ColumnHeadersVisible = false;
            this.dataGridViewMatchResults.Location = new System.Drawing.Point(749, 163);
            this.dataGridViewMatchResults.Name = "dataGridViewMatchResults";
            this.dataGridViewMatchResults.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMatchResults.TabIndex = 14;
            // 
            // labelMatchResults
            // 
            this.labelMatchResults.AutoSize = true;
            this.labelMatchResults.Location = new System.Drawing.Point(756, 143);
            this.labelMatchResults.Name = "labelMatchResults";
            this.labelMatchResults.Size = new System.Drawing.Size(98, 17);
            this.labelMatchResults.TabIndex = 15;
            this.labelMatchResults.Text = "Match Results:";
            // 
            // MainTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1066, 588);
            this.Controls.Add(this.labelMatchResults);
            this.Controls.Add(this.dataGridViewMatchResults);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelGameSteps);
            this.Controls.Add(this.labelNotificationsDescription);
            this.Controls.Add(this.numericUpDownNotificationsIntensity);
            this.Controls.Add(this.labelNotificationsIntensity);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelTimerInterval);
            this.Controls.Add(this.numericUpDownTimerInterval);
            this.Controls.Add(this.labelChampion);
            this.Controls.Add(this.labelChampionPresentation);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.dataGridViewStepByStep);
            this.Controls.Add(this.pictureBoxTicTacToe);
            this.Controls.Add(this.menuStripTicTacToe);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTicTacToe;
            this.Name = "MainTicTacToe";
            this.Text = "TicTacToe";
            this.menuStripTicTacToe.ResumeLayout(false);
            this.menuStripTicTacToe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicTacToe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStepByStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotificationsIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTicTacToe;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewLeagueTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewBeattheChampionTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guideForUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickMatchToolStripMenuItem;
        private System.Windows.Forms.Timer timerTicTacToe;
        private System.Windows.Forms.ToolStripMenuItem executionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxTicTacToe;
        private System.Windows.Forms.DataGridView dataGridViewStepByStep;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ToolStripMenuItem playMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playStepToolStripMenuItem;
        private System.Windows.Forms.Label labelChampionPresentation;
        private System.Windows.Forms.Label labelChampion;
        private System.Windows.Forms.NumericUpDown numericUpDownTimerInterval;
        private System.Windows.Forms.Label labelTimerInterval;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.NotifyIcon notifyIconTicTacToe;
        private System.Windows.Forms.Label labelNotificationsIntensity;
        private System.Windows.Forms.NumericUpDown numericUpDownNotificationsIntensity;
        private System.Windows.Forms.Label labelNotificationsDescription;
        private System.Windows.Forms.Label labelGameSteps;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.DataGridView dataGridViewMatchResults;
        private System.Windows.Forms.Label labelMatchResults;
    }
}