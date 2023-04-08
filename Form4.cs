using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class _pauseMenu : Form
    {
        public static _pauseMenu pauseMenu;

        private System.Media.SoundPlayer _mouseHover;
        private System.Media.SoundPlayer _buttonClick;
        
        
        public _pauseMenu()
        {
            InitializeComponent();
            pauseMenu = this;

            _mouseHover = new System.Media.SoundPlayer(Properties.Resources.mousehover);
            _buttonClick = new System.Media.SoundPlayer(Properties.Resources.gamestart);

        }

        private void _buttonResume_Click(object sender, EventArgs e)
        {
            _buttonClick.Play();
            
            
            if (_gameScreen1.gameScreen1.Enabled == true)
            {
                _gameScreen1.gameScreen1._timer1.Start();
                pauseMenu.Hide();
            }
            
            if (_gameScreen2.gameScreen2.Enabled == true)
            {
                _gameScreen2.gameScreen2._timer2.Start();
                pauseMenu.Hide();
            }
        }

        private void _buttonMainMenu_Click(object sender, EventArgs e)
        {
            _buttonClick.Play();
            

            if (_gameScreen1.gameScreen1.Enabled == true)
            {
                _gameScreen1.gameScreen1.Hide();
                _menuScreen._mainMenu.Show();
                pauseMenu.Hide();
            }

            if (_gameScreen2.gameScreen2.Enabled == true)
            {
                _gameScreen2.gameScreen2.Hide();
                _menuScreen._mainMenu.Show();
                pauseMenu.Hide();
            }
        }

        private void _buttonCloseApp_Click(object sender, EventArgs e)
        {
            _buttonClick.Play();

            Application.Exit();
        }

        
        
        /// <summary>
        /// Hover event handlers
        /// </summary>
        private void _buttonResume_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _buttonMainMenu_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _buttonCloseApp_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }
    }
}
