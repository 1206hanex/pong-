using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class _menuScreen : Form
    {
        public static _menuScreen _mainMenu;
        public TextBox _playerOneTB;
        public TextBox _playerTwoTB;
        public ColorDialog _playerOneColour;
        public ColorDialog _playerTwoColour;

        private Task _delay;
        private System.Media.SoundPlayer _mouseHover;
        private System.Media.SoundPlayer _buttonClick;


        public _menuScreen()
        {
            InitializeComponent();

            _buttonPlayerOneColour.BackColor = Color.White;
            _buttonPlayerTwoColour.BackColor = Color.White;

            _mainMenu = this;
            _playerOneTB = _textBoxPlayerOne;
            _playerTwoTB = _textBoxPlayerTwo;
            _playerOneColour = _colorDialog1;
            _playerTwoColour = _colorDialog2;

            _pauseMenu pauseMenu = new _pauseMenu();
            _gameScreen1 gameScreen1 = new _gameScreen1();
            _gameScreen2 gameScreen2 = new _gameScreen2();

            _delay = Task.Delay(1500);
            _mouseHover = new System.Media.SoundPlayer(Properties.Resources.mousehover);
            _buttonClick = new System.Media.SoundPlayer(Properties.Resources.gamestart);
        }

        private void _buttonOnePlayer_Click(object sender, EventArgs e)
        {
            _buttonClick.Play();
            _gameScreen1 gameScreen1 = new _gameScreen1();
            _delay.Wait();
            gameScreen1.Show();

            _mainMenu.Hide();
        }

        private void _buttonTwoPlayer_Click(object sender, EventArgs e)
        {
            _buttonClick.Play();
            _gameScreen2 gameScreen2 = new _gameScreen2();
            _delay.Wait();
            gameScreen2.Show();
        }

        private void _buttonPlayerOneColour_Click(object sender, EventArgs e)
        {
            _colorDialog1.ShowDialog();

            _buttonPlayerOneColour.BackColor = _colorDialog1.Color;
        }

        private void _buttonPlayerTwoColour_Click(object sender, EventArgs e)
        {
            _colorDialog2.ShowDialog();

            _buttonPlayerTwoColour.BackColor = _colorDialog2.Color;
        }

        private void _buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Hover events to play sound
        /// </summary>
        private void _buttonOnePlayer_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _buttonTwoPlayer_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _buttonPlayerOneColour_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _buttonPlayerTwoColour_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _textBoxPlayerOne_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _textBoxPlayerTwo_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }

        private void _buttonExit_MouseHover(object sender, EventArgs e)
        {
            _mouseHover.Play();
        }
    }
}
