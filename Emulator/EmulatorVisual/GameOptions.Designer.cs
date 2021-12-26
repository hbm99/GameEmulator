namespace EmulatorVisual
{
    partial class GameOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOptions));
            this.buttonOpenTicTacToe = new System.Windows.Forms.Button();
            this.buttonPointingParty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenTicTacToe
            // 
            this.buttonOpenTicTacToe.BackColor = System.Drawing.Color.Gray;
            this.buttonOpenTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenTicTacToe.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenTicTacToe.Location = new System.Drawing.Point(338, 167);
            this.buttonOpenTicTacToe.Name = "buttonOpenTicTacToe";
            this.buttonOpenTicTacToe.Size = new System.Drawing.Size(125, 30);
            this.buttonOpenTicTacToe.TabIndex = 0;
            this.buttonOpenTicTacToe.Text = "TicTacToe";
            this.buttonOpenTicTacToe.UseVisualStyleBackColor = false;
            this.buttonOpenTicTacToe.Click += new System.EventHandler(this.ButtonOpenTicTacToe_Click);
            // 
            // buttonPointingParty
            // 
            this.buttonPointingParty.BackColor = System.Drawing.Color.Gray;
            this.buttonPointingParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPointingParty.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPointingParty.Location = new System.Drawing.Point(338, 210);
            this.buttonPointingParty.Name = "buttonPointingParty";
            this.buttonPointingParty.Size = new System.Drawing.Size(125, 30);
            this.buttonPointingParty.TabIndex = 1;
            this.buttonPointingParty.Text = "PointingParty";
            this.buttonPointingParty.UseVisualStyleBackColor = false;
            this.buttonPointingParty.Click += new System.EventHandler(this.ButtonPointingParty_Click);
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPointingParty);
            this.Controls.Add(this.buttonOpenTicTacToe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOptions";
            this.Text = "GameOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenTicTacToe;
        private System.Windows.Forms.Button buttonPointingParty;
    }
}