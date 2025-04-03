namespace GeographyGameTest
{
    partial class MainForm
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
            cmbCountry = new ComboBox();
            cmbCapital = new ComboBox();
            cmbContinent = new ComboBox();
            lblCountry = new Label();
            lblCapital = new Label();
            lblContinent = new Label();
            lblContinentCorrect = new Label();
            lblCapitalCorrect = new Label();
            lblCountryCorrect = new Label();
            btnStart = new Button();
            btnGuess = new Button();
            btnNext = new Button();
            btnQuit = new Button();
            lblPlayerName = new Label();
            txtPlayerName = new TextBox();
            lblScoreboard = new Label();
            lblNamePrompt = new Label();
            progressBarFlags = new ProgressBar();
            lblFinalScore = new Label();
            pbxFlag = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxFlag).BeginInit();
            SuspendLayout();
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(70, 491);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(321, 30);
            cmbCountry.TabIndex = 1;
            // 
            // cmbCapital
            // 
            cmbCapital.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCapital.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCapital.FormattingEnabled = true;
            cmbCapital.Location = new Point(493, 491);
            cmbCapital.Name = "cmbCapital";
            cmbCapital.Size = new Size(339, 30);
            cmbCapital.TabIndex = 2;
            // 
            // cmbContinent
            // 
            cmbContinent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContinent.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbContinent.FormattingEnabled = true;
            cmbContinent.Location = new Point(921, 491);
            cmbContinent.Name = "cmbContinent";
            cmbContinent.Size = new Size(328, 30);
            cmbContinent.TabIndex = 3;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Courier New", 10F, FontStyle.Bold);
            lblCountry.ForeColor = Color.White;
            lblCountry.Location = new Point(155, 447);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(94, 23);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "COUNTRY";
            // 
            // lblCapital
            // 
            lblCapital.AutoSize = true;
            lblCapital.Font = new Font("Courier New", 10F, FontStyle.Bold);
            lblCapital.ForeColor = Color.White;
            lblCapital.Location = new Point(611, 447);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(94, 23);
            lblCapital.TabIndex = 5;
            lblCapital.Text = "CAPITAL";
            // 
            // lblContinent
            // 
            lblContinent.AutoSize = true;
            lblContinent.BackColor = Color.Transparent;
            lblContinent.Font = new Font("Courier New", 10F, FontStyle.Bold);
            lblContinent.ForeColor = Color.White;
            lblContinent.Location = new Point(1030, 447);
            lblContinent.Name = "lblContinent";
            lblContinent.Size = new Size(118, 23);
            lblContinent.TabIndex = 6;
            lblContinent.Text = "CONTINENT";
            // 
            // lblContinentCorrect
            // 
            lblContinentCorrect.AutoSize = true;
            lblContinentCorrect.ForeColor = Color.Black;
            lblContinentCorrect.Location = new Point(980, 534);
            lblContinentCorrect.Name = "lblContinentCorrect";
            lblContinentCorrect.Size = new Size(136, 25);
            lblContinentCorrect.TabIndex = 9;
            lblContinentCorrect.Text = "Right or Wrong";
            // 
            // lblCapitalCorrect
            // 
            lblCapitalCorrect.AutoSize = true;
            lblCapitalCorrect.ForeColor = Color.Black;
            lblCapitalCorrect.Location = new Point(543, 534);
            lblCapitalCorrect.Name = "lblCapitalCorrect";
            lblCapitalCorrect.Size = new Size(136, 25);
            lblCapitalCorrect.TabIndex = 8;
            lblCapitalCorrect.Text = "Right or Wrong";
            // 
            // lblCountryCorrect
            // 
            lblCountryCorrect.AutoSize = true;
            lblCountryCorrect.ForeColor = Color.Black;
            lblCountryCorrect.Location = new Point(116, 534);
            lblCountryCorrect.Name = "lblCountryCorrect";
            lblCountryCorrect.Size = new Size(136, 25);
            lblCountryCorrect.TabIndex = 7;
            lblCountryCorrect.Text = "Right or Wrong";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Niagara Solid", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.DarkSlateGray;
            btnStart.Location = new Point(533, 135);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(258, 117);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnGuess
            // 
            btnGuess.Font = new Font("Niagara Solid", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuess.ForeColor = Color.DarkSlateGray;
            btnGuess.Location = new Point(445, 592);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(200, 83);
            btnGuess.TabIndex = 9;
            btnGuess.Text = "GUESS";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Visible = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Niagara Solid", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.DarkSlateGray;
            btnNext.Location = new Point(666, 592);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(190, 83);
            btnNext.TabIndex = 10;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Niagara Solid", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.DarkSlateGray;
            btnQuit.Location = new Point(1152, 694);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(147, 47);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerName.ForeColor = Color.Snow;
            lblPlayerName.Location = new Point(12, 27);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(131, 21);
            lblPlayerName.TabIndex = 12;
            lblPlayerName.Text = "PLAYER NAME";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(12, 62);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(265, 31);
            txtPlayerName.TabIndex = 13;
            // 
            // lblScoreboard
            // 
            lblScoreboard.AutoSize = true;
            lblScoreboard.BackColor = Color.Transparent;
            lblScoreboard.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreboard.ForeColor = Color.White;
            lblScoreboard.Location = new Point(1110, 83);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(65, 21);
            lblScoreboard.TabIndex = 14;
            lblScoreboard.Text = "SCORE";
            // 
            // lblNamePrompt
            // 
            lblNamePrompt.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamePrompt.ForeColor = SystemColors.ButtonHighlight;
            lblNamePrompt.Location = new Point(445, 280);
            lblNamePrompt.Name = "lblNamePrompt";
            lblNamePrompt.Size = new Size(430, 44);
            lblNamePrompt.TabIndex = 16;
            lblNamePrompt.Text = "PLEASE ENTER PLAYER NAME TO START GAME";
            // 
            // progressBarFlags
            // 
            progressBarFlags.ForeColor = Color.Plum;
            progressBarFlags.Location = new Point(1048, 36);
            progressBarFlags.Name = "progressBarFlags";
            progressBarFlags.Size = new Size(192, 23);
            progressBarFlags.TabIndex = 18;
            // 
            // lblFinalScore
            // 
            lblFinalScore.AutoSize = true;
            lblFinalScore.Font = new Font("Courier New", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinalScore.ForeColor = Color.AliceBlue;
            lblFinalScore.Location = new Point(1097, 117);
            lblFinalScore.Name = "lblFinalScore";
            lblFinalScore.Size = new Size(102, 103);
            lblFinalScore.TabIndex = 22;
            lblFinalScore.Text = "0";
            // 
            // pbxFlag
            // 
            pbxFlag.Location = new Point(343, 18);
            pbxFlag.Name = "pbxFlag";
            pbxFlag.Size = new Size(623, 380);
            pbxFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFlag.TabIndex = 0;
            pbxFlag.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1311, 753);
            Controls.Add(btnStart);
            Controls.Add(lblContinentCorrect);
            Controls.Add(lblFinalScore);
            Controls.Add(lblCapitalCorrect);
            Controls.Add(lblCountryCorrect);
            Controls.Add(cmbCountry);
            Controls.Add(lblContinent);
            Controls.Add(progressBarFlags);
            Controls.Add(lblCountry);
            Controls.Add(cmbContinent);
            Controls.Add(lblNamePrompt);
            Controls.Add(lblCapital);
            Controls.Add(cmbCapital);
            Controls.Add(lblScoreboard);
            Controls.Add(txtPlayerName);
            Controls.Add(lblPlayerName);
            Controls.Add(btnQuit);
            Controls.Add(btnNext);
            Controls.Add(btnGuess);
            Controls.Add(pbxFlag);
            Name = "MainForm";
            Text = "Geography Game";
            ((System.ComponentModel.ISupportInitialize)pbxFlag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbCountry;
        private ComboBox cmbCapital;
        private ComboBox cmbContinent;
        private Label lblCountry;
        private Label lblCapital;
        private Label lblContinent;
        private Button btnStart;
        private Button btnGuess;
        private Button btnNext;
        private Button btnQuit;
        private Label lblContinentCorrect;
        private Label lblCapitalCorrect;
        private Label lblCountryCorrect;
        private Label lblPlayerName;
        private TextBox txtPlayerName;
        private Label lblScoreboard;
        private Label lblNamePrompt;
        private ProgressBar progressBarFlags;
        private Label lblFinalScore;
        private PictureBox pbxFlag;
    }
}
