namespace Pong_Game
{
    partial class _gameScreen1
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
            this.label1 = new System.Windows.Forms.Label();
            this._labelSmashStatus = new System.Windows.Forms.Label();
            this._labelPlayerName = new System.Windows.Forms.Label();
            this._labelCpuName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._labelPlayerCombo = new System.Windows.Forms.Label();
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
            this._pictureBoxCourt.TabIndex = 0;
            this._pictureBoxCourt.TabStop = false;
            this._pictureBoxCourt.Paint += new System.Windows.Forms.PaintEventHandler(this._pictureBoxCourt_Paint);
            // 
            // _animationTimer
            // 
            this._animationTimer.Interval = 10;
            this._animationTimer.Tick += new System.EventHandler(this._animationTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMASH:";
            // 
            // _labelSmashStatus
            // 
            this._labelSmashStatus.AutoSize = true;
            this._labelSmashStatus.BackColor = System.Drawing.Color.Silver;
            this._labelSmashStatus.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelSmashStatus.ForeColor = System.Drawing.Color.Black;
            this._labelSmashStatus.Location = new System.Drawing.Point(109, 758);
            this._labelSmashStatus.Name = "_labelSmashStatus";
            this._labelSmashStatus.Size = new System.Drawing.Size(44, 24);
            this._labelSmashStatus.TabIndex = 4;
            this._labelSmashStatus.Text = "##";
            // 
            // _labelPlayerName
            // 
            this._labelPlayerName.AutoSize = true;
            this._labelPlayerName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelPlayerName.Location = new System.Drawing.Point(12, 9);
            this._labelPlayerName.Name = "_labelPlayerName";
            this._labelPlayerName.Size = new System.Drawing.Size(114, 31);
            this._labelPlayerName.TabIndex = 6;
            this._labelPlayerName.Text = "AAA: #";
            // 
            // _labelCpuName
            // 
            this._labelCpuName.AutoSize = true;
            this._labelCpuName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelCpuName.Location = new System.Drawing.Point(1189, 9);
            this._labelCpuName.Name = "_labelCpuName";
            this._labelCpuName.Size = new System.Drawing.Size(114, 31);
            this._labelCpuName.TabIndex = 7;
            this._labelCpuName.Text = "AAA: #";
            this._labelCpuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 794);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "COMBO:";
            // 
            // _labelPlayerCombo
            // 
            this._labelPlayerCombo.AutoSize = true;
            this._labelPlayerCombo.BackColor = System.Drawing.Color.Silver;
            this._labelPlayerCombo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelPlayerCombo.ForeColor = System.Drawing.Color.Black;
            this._labelPlayerCombo.Location = new System.Drawing.Point(123, 794);
            this._labelPlayerCombo.Name = "_labelPlayerCombo";
            this._labelPlayerCombo.Size = new System.Drawing.Size(44, 24);
            this._labelPlayerCombo.TabIndex = 9;
            this._labelPlayerCombo.Text = "##";
            // 
            // _gameScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1317, 829);
            this.Controls.Add(this._labelPlayerCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._labelCpuName);
            this.Controls.Add(this._labelPlayerName);
            this.Controls.Add(this._labelSmashStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pictureBoxCourt);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(1333, 868);
            this.MinimumSize = new System.Drawing.Size(1333, 868);
            this.Name = "_gameScreen1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._gameScreen1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this._gameScreen1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxCourt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBoxCourt;
        private System.Windows.Forms.Timer _animationTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _labelSmashStatus;
        private System.Windows.Forms.Label _labelPlayerName;
        private System.Windows.Forms.Label _labelCpuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _labelPlayerCombo;
    }
}