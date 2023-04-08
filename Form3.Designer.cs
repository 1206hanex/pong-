namespace Pong_Game
{
    partial class _gameScreen2
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
            this._pictureBoxCourt = new System.Windows.Forms.PictureBox();
            this._animationTimer = new System.Windows.Forms.Timer(this.components);
            this._labelPlayerOneName = new System.Windows.Forms.Label();
            this._labelPlayerTwoName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._pOneSmashStatus = new System.Windows.Forms.Label();
            this._pOneCombo = new System.Windows.Forms.Label();
            this._pTwoCombo = new System.Windows.Forms.Label();
            this._pTwoSmashStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxCourt)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBoxCourt
            // 
            this._pictureBoxCourt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._pictureBoxCourt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pictureBoxCourt.Location = new System.Drawing.Point(12, 47);
            this._pictureBoxCourt.Name = "_pictureBoxCourt";
            this._pictureBoxCourt.Size = new System.Drawing.Size(1291, 694);
            this._pictureBoxCourt.TabIndex = 1;
            this._pictureBoxCourt.TabStop = false;
            this._pictureBoxCourt.Paint += new System.Windows.Forms.PaintEventHandler(this._pictureBoxCourt_Paint);
            // 
            // _animationTimer
            // 
            this._animationTimer.Interval = 10;
            this._animationTimer.Tick += new System.EventHandler(this._animationTimer_Tick);
            // 
            // _labelPlayerOneName
            // 
            this._labelPlayerOneName.AutoSize = true;
            this._labelPlayerOneName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelPlayerOneName.Location = new System.Drawing.Point(12, 9);
            this._labelPlayerOneName.Name = "_labelPlayerOneName";
            this._labelPlayerOneName.Size = new System.Drawing.Size(114, 31);
            this._labelPlayerOneName.TabIndex = 7;
            this._labelPlayerOneName.Text = "AAA: #";
            // 
            // _labelPlayerTwoName
            // 
            this._labelPlayerTwoName.AutoSize = true;
            this._labelPlayerTwoName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelPlayerTwoName.Location = new System.Drawing.Point(1189, 9);
            this._labelPlayerTwoName.Name = "_labelPlayerTwoName";
            this._labelPlayerTwoName.Size = new System.Drawing.Size(114, 31);
            this._labelPlayerTwoName.TabIndex = 8;
            this._labelPlayerTwoName.Text = "AAA: #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "SMASH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 789);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "COMBO:";
            // 
            // _pOneSmashStatus
            // 
            this._pOneSmashStatus.AutoSize = true;
            this._pOneSmashStatus.BackColor = System.Drawing.Color.Silver;
            this._pOneSmashStatus.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._pOneSmashStatus.ForeColor = System.Drawing.Color.Black;
            this._pOneSmashStatus.Location = new System.Drawing.Point(103, 758);
            this._pOneSmashStatus.Name = "_pOneSmashStatus";
            this._pOneSmashStatus.Size = new System.Drawing.Size(44, 24);
            this._pOneSmashStatus.TabIndex = 13;
            this._pOneSmashStatus.Text = "##";
            // 
            // _pOneCombo
            // 
            this._pOneCombo.AutoSize = true;
            this._pOneCombo.BackColor = System.Drawing.Color.Silver;
            this._pOneCombo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._pOneCombo.ForeColor = System.Drawing.Color.Black;
            this._pOneCombo.Location = new System.Drawing.Point(112, 789);
            this._pOneCombo.Name = "_pOneCombo";
            this._pOneCombo.Size = new System.Drawing.Size(44, 24);
            this._pOneCombo.TabIndex = 14;
            this._pOneCombo.Text = "##";
            // 
            // _pTwoCombo
            // 
            this._pTwoCombo.AutoSize = true;
            this._pTwoCombo.BackColor = System.Drawing.Color.Silver;
            this._pTwoCombo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._pTwoCombo.ForeColor = System.Drawing.Color.Black;
            this._pTwoCombo.Location = new System.Drawing.Point(1261, 789);
            this._pTwoCombo.Name = "_pTwoCombo";
            this._pTwoCombo.Size = new System.Drawing.Size(44, 24);
            this._pTwoCombo.TabIndex = 15;
            this._pTwoCombo.Text = "##";
            // 
            // _pTwoSmashStatus
            // 
            this._pTwoSmashStatus.AutoSize = true;
            this._pTwoSmashStatus.BackColor = System.Drawing.Color.Silver;
            this._pTwoSmashStatus.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._pTwoSmashStatus.ForeColor = System.Drawing.Color.Black;
            this._pTwoSmashStatus.Location = new System.Drawing.Point(1162, 758);
            this._pTwoSmashStatus.Name = "_pTwoSmashStatus";
            this._pTwoSmashStatus.Size = new System.Drawing.Size(141, 24);
            this._pTwoSmashStatus.TabIndex = 16;
            this._pTwoSmashStatus.Text = "NOT READY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1067, 758);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "SMASH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1164, 789);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "COMBO:";
            // 
            // _gameScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1317, 829);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._pTwoSmashStatus);
            this.Controls.Add(this._pTwoCombo);
            this.Controls.Add(this._pOneCombo);
            this.Controls.Add(this._pOneSmashStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._labelPlayerTwoName);
            this.Controls.Add(this._labelPlayerOneName);
            this.Controls.Add(this._pictureBoxCourt);
            this.MaximumSize = new System.Drawing.Size(1333, 868);
            this.MinimumSize = new System.Drawing.Size(1333, 868);
            this.Name = "_gameScreen2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._gameScreen2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this._gameScreen2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxCourt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer _animationTimer;
        private System.Windows.Forms.PictureBox _pictureBoxCourt;
        private System.Windows.Forms.Label _labelPlayerOneName;
        private System.Windows.Forms.Label _labelPlayerTwoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _pOneSmashStatus;
        private System.Windows.Forms.Label _pOneCombo;
        private System.Windows.Forms.Label _pTwoCombo;
        private System.Windows.Forms.Label _pTwoSmashStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}