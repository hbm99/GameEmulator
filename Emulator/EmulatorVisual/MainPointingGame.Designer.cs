namespace EmulatorVisual
{
    partial class MainPointingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPointingGame));
            this.menuStripPointingGame = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualClasificationTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideForUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPointingParty = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTeamPoints = new System.Windows.Forms.DataGridView();
            this.menuStripPointingGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPointingGame
            // 
            this.menuStripPointingGame.BackColor = System.Drawing.Color.Gray;
            this.menuStripPointingGame.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripPointingGame.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPointingGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.executionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripPointingGame.Location = new System.Drawing.Point(0, 0);
            this.menuStripPointingGame.Name = "menuStripPointingGame";
            this.menuStripPointingGame.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripPointingGame.Size = new System.Drawing.Size(800, 25);
            this.menuStripPointingGame.TabIndex = 1;
            this.menuStripPointingGame.Text = "menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewTournamentToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "Game";
            // 
            // createNewTournamentToolStripMenuItem
            // 
            this.createNewTournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualClasificationTournamentToolStripMenuItem});
            this.createNewTournamentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewTournamentToolStripMenuItem.Image")));
            this.createNewTournamentToolStripMenuItem.Name = "createNewTournamentToolStripMenuItem";
            this.createNewTournamentToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.createNewTournamentToolStripMenuItem.Text = "Create new Tournament";
            // 
            // individualClasificationTournamentToolStripMenuItem
            // 
            this.individualClasificationTournamentToolStripMenuItem.Name = "individualClasificationTournamentToolStripMenuItem";
            this.individualClasificationTournamentToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.individualClasificationTournamentToolStripMenuItem.Text = "Individual Clasification Tournament";
            this.individualClasificationTournamentToolStripMenuItem.Click += new System.EventHandler(this.IndividualClasificationTournamentToolStripMenuItem_Click);
            // 
            // executionToolStripMenuItem
            // 
            this.executionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
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
            this.playToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseToolStripMenuItem.Image")));
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
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
            this.guideForUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.guideForUserToolStripMenuItem.Text = "Guide for user";
            // 
            // timerPointingParty
            // 
            this.timerPointingParty.Enabled = true;
            this.timerPointingParty.Tick += new System.EventHandler(this.TimerPointingParty_Tick);
            // 
            // dataGridViewTeamPoints
            // 
            this.dataGridViewTeamPoints.AllowUserToAddRows = false;
            this.dataGridViewTeamPoints.AllowUserToDeleteRows = false;
            this.dataGridViewTeamPoints.AllowUserToResizeColumns = false;
            this.dataGridViewTeamPoints.AllowUserToResizeRows = false;
            this.dataGridViewTeamPoints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTeamPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamPoints.Location = new System.Drawing.Point(280, 150);
            this.dataGridViewTeamPoints.Name = "dataGridViewTeamPoints";
            this.dataGridViewTeamPoints.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTeamPoints.TabIndex = 3;
            // 
            // MainPointingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTeamPoints);
            this.Controls.Add(this.menuStripPointingGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPointingGame";
            this.Text = "MainPointingGame";
            this.menuStripPointingGame.ResumeLayout(false);
            this.menuStripPointingGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPointingGame;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualClasificationTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guideForUserToolStripMenuItem;
        private System.Windows.Forms.Timer timerPointingParty;
        private System.Windows.Forms.DataGridView dataGridViewTeamPoints;
    }
}