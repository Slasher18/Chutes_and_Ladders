namespace Chutes_and_Ladders
{
    partial class Chutes_Ladders
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
            this.textBoxPlayerNum = new System.Windows.Forms.TextBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonPlayTurn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPlayerNum
            // 
            this.textBoxPlayerNum.Location = new System.Drawing.Point(12, 24);
            this.textBoxPlayerNum.Name = "textBoxPlayerNum";
            this.textBoxPlayerNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayerNum.TabIndex = 0;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(127, 24);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(105, 22);
            this.buttonNewGame.TabIndex = 1;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 16;
            this.listBoxPlayers.Location = new System.Drawing.Point(2, 52);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(565, 308);
            this.listBoxPlayers.TabIndex = 2;
            // 
            // buttonPlayTurn
            // 
            this.buttonPlayTurn.Location = new System.Drawing.Point(492, 24);
            this.buttonPlayTurn.Name = "buttonPlayTurn";
            this.buttonPlayTurn.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayTurn.TabIndex = 3;
            this.buttonPlayTurn.Text = "Play Turn";
            this.buttonPlayTurn.UseVisualStyleBackColor = true;
            this.buttonPlayTurn.Click += new System.EventHandler(this.buttonPlayTurn_Click);
            // 
            // Chutes_Ladders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 356);
            this.Controls.Add(this.buttonPlayTurn);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.textBoxPlayerNum);
            this.Name = "Chutes_Ladders";
            this.Text = "Chutes and Ladders";
            this.Load += new System.EventHandler(this.Chutes_Ladders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlayerNum;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Button buttonPlayTurn;
    }
}

