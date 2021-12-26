namespace EmulatorVisual
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelRigthsReserved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.BackColor = System.Drawing.Color.Gray;
            this.buttonLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadGame.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadGame.Location = new System.Drawing.Point(288, 144);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(206, 53);
            this.buttonLoadGame.TabIndex = 0;
            this.buttonLoadGame.Text = "LOAD GAME";
            this.buttonLoadGame.UseVisualStyleBackColor = false;
            this.buttonLoadGame.Click += new System.EventHandler(this.ButtonLoadGame_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Gray;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(288, 213);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(206, 53);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // labelRigthsReserved
            // 
            this.labelRigthsReserved.AutoSize = true;
            this.labelRigthsReserved.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRigthsReserved.Location = new System.Drawing.Point(615, 426);
            this.labelRigthsReserved.Name = "labelRigthsReserved";
            this.labelRigthsReserved.Size = new System.Drawing.Size(173, 15);
            this.labelRigthsReserved.TabIndex = 2;
            this.labelRigthsReserved.Text = "All rigths reserved. @ Copyright";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRigthsReserved);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonLoadGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Emulator";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadGame;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelRigthsReserved;
    }
}

