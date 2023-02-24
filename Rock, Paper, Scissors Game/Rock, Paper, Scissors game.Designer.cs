namespace Rock__Paper__Scissors_Game
{
    partial class rockPaperScissorsGame
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
            this.lblPick = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnPlayGmae = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblWonTheMost = new System.Windows.Forms.Label();
            this.lblPickNumber = new System.Windows.Forms.Label();
            this.lblResultsShow = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWonTheMostShow = new System.Windows.Forms.Label();
            this.lblUserPickShow = new System.Windows.Forms.Label();
            this.lblComputerPIckShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPick
            // 
            this.lblPick.AutoSize = true;
            this.lblPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPick.Location = new System.Drawing.Point(65, 9);
            this.lblPick.Name = "lblPick";
            this.lblPick.Size = new System.Drawing.Size(274, 16);
            this.lblPick.TabIndex = 1;
            this.lblPick.Text = "Please pick a number between 1 and 5";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(136, 63);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // btnPlayGmae
            // 
            this.btnPlayGmae.Location = new System.Drawing.Point(146, 98);
            this.btnPlayGmae.Name = "btnPlayGmae";
            this.btnPlayGmae.Size = new System.Drawing.Size(75, 23);
            this.btnPlayGmae.TabIndex = 3;
            this.btnPlayGmae.Text = "Play Game";
            this.btnPlayGmae.UseVisualStyleBackColor = true;
            this.btnPlayGmae.Click += new System.EventHandler(this.btnPlayGmae_Click);
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(126, 137);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(126, 18);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "Result of game";
            // 
            // lblWonTheMost
            // 
            this.lblWonTheMost.AutoSize = true;
            this.lblWonTheMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWonTheMost.Location = new System.Drawing.Point(120, 273);
            this.lblWonTheMost.Name = "lblWonTheMost";
            this.lblWonTheMost.Size = new System.Drawing.Size(132, 16);
            this.lblWonTheMost.TabIndex = 5;
            this.lblWonTheMost.Text = "Who won the most";
            // 
            // lblPickNumber
            // 
            this.lblPickNumber.AutoSize = true;
            this.lblPickNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickNumber.Location = new System.Drawing.Point(43, 34);
            this.lblPickNumber.Name = "lblPickNumber";
            this.lblPickNumber.Size = new System.Drawing.Size(344, 16);
            this.lblPickNumber.TabIndex = 0;
            this.lblPickNumber.Text = "1=Rock, 2=Paper, 3=Scissors, 4=Lizard, 5=Spock";
            // 
            // lblResultsShow
            // 
            this.lblResultsShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultsShow.Location = new System.Drawing.Point(81, 227);
            this.lblResultsShow.Name = "lblResultsShow";
            this.lblResultsShow.Size = new System.Drawing.Size(205, 22);
            this.lblResultsShow.TabIndex = 7;
            this.lblResultsShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset the game count";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(192, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWonTheMostShow
            // 
            this.lblWonTheMostShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWonTheMostShow.Location = new System.Drawing.Point(111, 301);
            this.lblWonTheMostShow.Name = "lblWonTheMostShow";
            this.lblWonTheMostShow.Size = new System.Drawing.Size(156, 86);
            this.lblWonTheMostShow.TabIndex = 6;
            // 
            // lblUserPickShow
            // 
            this.lblUserPickShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserPickShow.Location = new System.Drawing.Point(111, 165);
            this.lblUserPickShow.Name = "lblUserPickShow";
            this.lblUserPickShow.Size = new System.Drawing.Size(154, 20);
            this.lblUserPickShow.TabIndex = 10;
            this.lblUserPickShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComputerPIckShow
            // 
            this.lblComputerPIckShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputerPIckShow.Location = new System.Drawing.Point(111, 196);
            this.lblComputerPIckShow.Name = "lblComputerPIckShow";
            this.lblComputerPIckShow.Size = new System.Drawing.Size(154, 20);
            this.lblComputerPIckShow.TabIndex = 11;
            this.lblComputerPIckShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rockPaperScissorsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 457);
            this.Controls.Add(this.lblComputerPIckShow);
            this.Controls.Add(this.lblUserPickShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResultsShow);
            this.Controls.Add(this.lblWonTheMostShow);
            this.Controls.Add(this.lblWonTheMost);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnPlayGmae);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblPick);
            this.Controls.Add(this.lblPickNumber);
            this.Name = "rockPaperScissorsGame";
            this.Text = "Rock, Paper, Scissors Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPick;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnPlayGmae;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblWonTheMost;
        private System.Windows.Forms.Label lblPickNumber;
        private System.Windows.Forms.Label lblResultsShow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWonTheMostShow;
        private System.Windows.Forms.Label lblUserPickShow;
        private System.Windows.Forms.Label lblComputerPIckShow;
    }
}

