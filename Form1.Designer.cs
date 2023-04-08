namespace Pong_Game
{
    partial class _menuScreen
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
            this._buttonOnePlayer = new System.Windows.Forms.Button();
            this._buttonTwoPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxPlayerOne = new System.Windows.Forms.TextBox();
            this._textBoxPlayerTwo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._buttonPlayerOneColour = new System.Windows.Forms.Button();
            this._buttonPlayerTwoColour = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._colorDialog2 = new System.Windows.Forms.ColorDialog();
            this._buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonOnePlayer
            // 
            this._buttonOnePlayer.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonOnePlayer.Location = new System.Drawing.Point(94, 358);
            this._buttonOnePlayer.Name = "_buttonOnePlayer";
            this._buttonOnePlayer.Size = new System.Drawing.Size(151, 85);
            this._buttonOnePlayer.TabIndex = 0;
            this._buttonOnePlayer.Text = "1P";
            this._buttonOnePlayer.UseVisualStyleBackColor = true;
            this._buttonOnePlayer.Click += new System.EventHandler(this._buttonOnePlayer_Click);
            this._buttonOnePlayer.MouseHover += new System.EventHandler(this._buttonOnePlayer_MouseHover);
            // 
            // _buttonTwoPlayer
            // 
            this._buttonTwoPlayer.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonTwoPlayer.Location = new System.Drawing.Point(246, 358);
            this._buttonTwoPlayer.Name = "_buttonTwoPlayer";
            this._buttonTwoPlayer.Size = new System.Drawing.Size(151, 85);
            this._buttonTwoPlayer.TabIndex = 1;
            this._buttonTwoPlayer.Text = "2P";
            this._buttonTwoPlayer.UseVisualStyleBackColor = true;
            this._buttonTwoPlayer.Click += new System.EventHandler(this._buttonTwoPlayer_Click);
            this._buttonTwoPlayer.MouseHover += new System.EventHandler(this._buttonTwoPlayer_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 111);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pong!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "卓球！";
            // 
            // _textBoxPlayerOne
            // 
            this._textBoxPlayerOne.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._textBoxPlayerOne.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._textBoxPlayerOne.Location = new System.Drawing.Point(94, 193);
            this._textBoxPlayerOne.MaxLength = 3;
            this._textBoxPlayerOne.Name = "_textBoxPlayerOne";
            this._textBoxPlayerOne.Size = new System.Drawing.Size(46, 20);
            this._textBoxPlayerOne.TabIndex = 4;
            this._textBoxPlayerOne.Text = "P1";
            this._textBoxPlayerOne.MouseHover += new System.EventHandler(this._textBoxPlayerOne_MouseHover);
            // 
            // _textBoxPlayerTwo
            // 
            this._textBoxPlayerTwo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._textBoxPlayerTwo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._textBoxPlayerTwo.Location = new System.Drawing.Point(344, 193);
            this._textBoxPlayerTwo.MaxLength = 3;
            this._textBoxPlayerTwo.Name = "_textBoxPlayerTwo";
            this._textBoxPlayerTwo.Size = new System.Drawing.Size(53, 20);
            this._textBoxPlayerTwo.TabIndex = 5;
            this._textBoxPlayerTwo.Text = "P2";
            this._textBoxPlayerTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._textBoxPlayerTwo.MouseHover += new System.EventHandler(this._textBoxPlayerTwo_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(287, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(152, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mode Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(162, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "モードセレクト";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(91, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "名前：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(353, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "名前：";
            // 
            // _buttonPlayerOneColour
            // 
            this._buttonPlayerOneColour.Location = new System.Drawing.Point(94, 271);
            this._buttonPlayerOneColour.Name = "_buttonPlayerOneColour";
            this._buttonPlayerOneColour.Size = new System.Drawing.Size(83, 23);
            this._buttonPlayerOneColour.TabIndex = 12;
            this._buttonPlayerOneColour.UseVisualStyleBackColor = true;
            this._buttonPlayerOneColour.Click += new System.EventHandler(this._buttonPlayerOneColour_Click);
            this._buttonPlayerOneColour.MouseHover += new System.EventHandler(this._buttonPlayerOneColour_MouseHover);
            // 
            // _buttonPlayerTwoColour
            // 
            this._buttonPlayerTwoColour.Location = new System.Drawing.Point(314, 271);
            this._buttonPlayerTwoColour.Name = "_buttonPlayerTwoColour";
            this._buttonPlayerTwoColour.Size = new System.Drawing.Size(83, 23);
            this._buttonPlayerTwoColour.TabIndex = 13;
            this._buttonPlayerTwoColour.UseVisualStyleBackColor = true;
            this._buttonPlayerTwoColour.Click += new System.EventHandler(this._buttonPlayerTwoColour_Click);
            this._buttonPlayerTwoColour.MouseHover += new System.EventHandler(this._buttonPlayerTwoColour_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(91, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Colour:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(328, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Colour:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(91, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "色：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(369, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "色：";
            // 
            // _buttonExit
            // 
            this._buttonExit.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonExit.Location = new System.Drawing.Point(397, 526);
            this._buttonExit.Name = "_buttonExit";
            this._buttonExit.Size = new System.Drawing.Size(75, 23);
            this._buttonExit.TabIndex = 18;
            this._buttonExit.Text = "Exit";
            this._buttonExit.UseVisualStyleBackColor = true;
            this._buttonExit.Click += new System.EventHandler(this._buttonExit_Click);
            this._buttonExit.MouseHover += new System.EventHandler(this._buttonExit_MouseHover);
            // 
            // _menuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this._buttonExit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._buttonPlayerTwoColour);
            this.Controls.Add(this._buttonPlayerOneColour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxPlayerTwo);
            this.Controls.Add(this._textBoxPlayerOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonTwoPlayer);
            this.Controls.Add(this._buttonOnePlayer);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "_menuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOnePlayer;
        private System.Windows.Forms.Button _buttonTwoPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxPlayerOne;
        private System.Windows.Forms.TextBox _textBoxPlayerTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button _buttonPlayerOneColour;
        private System.Windows.Forms.Button _buttonPlayerTwoColour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColorDialog _colorDialog1;
        private System.Windows.Forms.ColorDialog _colorDialog2;
        private System.Windows.Forms.Button _buttonExit;
    }
}

