namespace Pong_Game
{
    partial class _pauseMenu
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
            this._buttonResume = new System.Windows.Forms.Button();
            this._buttonMainMenu = new System.Windows.Forms.Button();
            this._buttonCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonResume
            // 
            this._buttonResume.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonResume.Location = new System.Drawing.Point(55, 55);
            this._buttonResume.Name = "_buttonResume";
            this._buttonResume.Size = new System.Drawing.Size(206, 77);
            this._buttonResume.TabIndex = 0;
            this._buttonResume.Text = "Resume";
            this._buttonResume.UseVisualStyleBackColor = true;
            this._buttonResume.Click += new System.EventHandler(this._buttonResume_Click);
            this._buttonResume.MouseHover += new System.EventHandler(this._buttonResume_MouseHover);
            // 
            // _buttonMainMenu
            // 
            this._buttonMainMenu.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonMainMenu.Location = new System.Drawing.Point(55, 173);
            this._buttonMainMenu.Name = "_buttonMainMenu";
            this._buttonMainMenu.Size = new System.Drawing.Size(206, 77);
            this._buttonMainMenu.TabIndex = 2;
            this._buttonMainMenu.Text = "Back to Main Menu";
            this._buttonMainMenu.UseVisualStyleBackColor = true;
            this._buttonMainMenu.Click += new System.EventHandler(this._buttonMainMenu_Click);
            this._buttonMainMenu.MouseHover += new System.EventHandler(this._buttonMainMenu_MouseHover);
            // 
            // _buttonCloseApp
            // 
            this._buttonCloseApp.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonCloseApp.Location = new System.Drawing.Point(55, 290);
            this._buttonCloseApp.Name = "_buttonCloseApp";
            this._buttonCloseApp.Size = new System.Drawing.Size(206, 77);
            this._buttonCloseApp.TabIndex = 3;
            this._buttonCloseApp.Text = "Exit Game";
            this._buttonCloseApp.UseVisualStyleBackColor = true;
            this._buttonCloseApp.Click += new System.EventHandler(this._buttonCloseApp_Click);
            this._buttonCloseApp.MouseHover += new System.EventHandler(this._buttonCloseApp_MouseHover);
            // 
            // _pauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(316, 451);
            this.Controls.Add(this._buttonCloseApp);
            this.Controls.Add(this._buttonMainMenu);
            this.Controls.Add(this._buttonResume);
            this.Name = "_pauseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonResume;
        private System.Windows.Forms.Button _buttonMainMenu;
        private System.Windows.Forms.Button _buttonCloseApp;
    }
}