namespace Mystery_Battle_.Net_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnWizard = new System.Windows.Forms.Button();
            this.btnSorceress = new System.Windows.Forms.Button();
            this.btnMystery = new System.Windows.Forms.Button();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.lblRoboChoice = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.lblRoboResult = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblRoboWins = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWizard
            // 
            this.btnWizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWizard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWizard.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWizard.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnWizard.Location = new System.Drawing.Point(41, 336);
            this.btnWizard.Name = "btnWizard";
            this.btnWizard.Size = new System.Drawing.Size(150, 50);
            this.btnWizard.TabIndex = 0;
            this.btnWizard.Tag = "W";
            this.btnWizard.Text = "Wizard";
            this.btnWizard.UseVisualStyleBackColor = true;
            this.btnWizard.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnSorceress
            // 
            this.btnSorceress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSorceress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorceress.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSorceress.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnSorceress.Location = new System.Drawing.Point(244, 336);
            this.btnSorceress.Name = "btnSorceress";
            this.btnSorceress.Size = new System.Drawing.Size(150, 50);
            this.btnSorceress.TabIndex = 1;
            this.btnSorceress.Tag = "S";
            this.btnSorceress.Text = "Sorceress";
            this.btnSorceress.UseVisualStyleBackColor = true;
            this.btnSorceress.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnMystery
            // 
            this.btnMystery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMystery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMystery.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMystery.Location = new System.Drawing.Point(450, 336);
            this.btnMystery.Name = "btnMystery";
            this.btnMystery.Size = new System.Drawing.Size(150, 50);
            this.btnMystery.TabIndex = 2;
            this.btnMystery.Tag = "M";
            this.btnMystery.Text = "Mystery";
            this.btnMystery.UseVisualStyleBackColor = true;
            this.btnMystery.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.BackColor = System.Drawing.Color.Black;
            this.CPU_PIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CPU_PIC.Location = new System.Drawing.Point(267, 48);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(100, 100);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 3;
            this.CPU_PIC.TabStop = false;
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PLAYER_PIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PLAYER_PIC.Location = new System.Drawing.Point(267, 180);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(100, 100);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 4;
            this.PLAYER_PIC.TabStop = false;
            // 
            // lblRoboChoice
            // 
            this.lblRoboChoice.AutoSize = true;
            this.lblRoboChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboChoice.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboChoice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRoboChoice.Location = new System.Drawing.Point(255, 20);
            this.lblRoboChoice.Name = "lblRoboChoice";
            this.lblRoboChoice.Size = new System.Drawing.Size(121, 25);
            this.lblRoboChoice.TabIndex = 5;
            this.lblRoboChoice.Text = "Robo Choice";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerChoice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerChoice.Location = new System.Drawing.Point(255, 297);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(122, 25);
            this.lblPlayerChoice.TabIndex = 6;
            this.lblPlayerChoice.Text = "Player Choice";
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerResult.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerResult.Location = new System.Drawing.Point(450, 199);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(118, 25);
            this.lblPlayerResult.TabIndex = 7;
            this.lblPlayerResult.Text = "Player Score:";
            // 
            // lblRoboResult
            // 
            this.lblRoboResult.AutoSize = true;
            this.lblRoboResult.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboResult.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRoboResult.Location = new System.Drawing.Point(450, 65);
            this.lblRoboResult.Name = "lblRoboResult";
            this.lblRoboResult.Size = new System.Drawing.Size(117, 25);
            this.lblRoboResult.TabIndex = 8;
            this.lblRoboResult.Text = "Robo Score:";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWins.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerWins.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerWins.Location = new System.Drawing.Point(41, 180);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(0, 21);
            this.lblPlayerWins.TabIndex = 9;
            this.lblPlayerWins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRoboWins
            // 
            this.lblRoboWins.AutoSize = true;
            this.lblRoboWins.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboWins.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboWins.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRoboWins.Location = new System.Drawing.Point(42, 48);
            this.lblRoboWins.Name = "lblRoboWins";
            this.lblRoboWins.Size = new System.Drawing.Size(0, 21);
            this.lblRoboWins.TabIndex = 10;
            this.lblRoboWins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblDraw.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDraw.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDraw.Location = new System.Drawing.Point(41, 113);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(0, 21);
            this.lblDraw.TabIndex = 12;
            this.lblDraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(320, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(640, 424);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRoboWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblRoboResult);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblRoboChoice);
            this.Controls.Add(this.PLAYER_PIC);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.btnMystery);
            this.Controls.Add(this.btnSorceress);
            this.Controls.Add(this.btnWizard);
            this.Name = "Form1";
            this.Text = "Mystery Battle .Net Game";
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWizard;
        private Button btnSorceress;
        private Button btnMystery;
        private PictureBox CPU_PIC;
        private PictureBox PLAYER_PIC;
        private Label lblRoboChoice;
        private Label lblPlayerChoice;
        private Label lblPlayerResult;
        private Label lblRoboResult;
        private Label lblPlayerWins;
        private Label lblRoboWins;
        private Label lblDraw;
        private Label label2;
    }
}