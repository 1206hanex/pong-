using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class _gameScreen2 : Form
    {
        // Instance variables

        public static _gameScreen2 gameScreen2;
        public Timer _timer2;
        
        private PlayerPaddle _playerOnePaddle;
        private PlayerPaddle _playerTwoPaddle;
        private Ball _ball;
        private Color _playerOneColour;
        private Color _playerTwoColour;

        private bool _wKeyDown;
        private bool _sKeyDown;
        private bool _upKeyDown;
        private bool _downKeyDown;
        private bool _playerOneCrossSmash;
        private bool _playerOneStraightSmash;
        private bool _playerTwoCrossSmash;
        private bool _playerTwoStraightSmash;

        private int _ballSpeedX = -5;
        private int _ballSpeedY = -5;
        private int _paddleSpeedY = 8;

        private int _playerOneScore;
        private int _playerTwoScore;
        private int _playerOneHitCount;
        private int _playerTwoHitCount;

        private string _playerOneName;
        private string _playerTwoName;


        public _gameScreen2()
        {
            InitializeComponent();

            gameScreen2 = this;
            _timer2 = _animationTimer;
            _playerOneName = _menuScreen._mainMenu._playerOneTB.Text;
            _playerTwoName = _menuScreen._mainMenu._playerTwoTB.Text;
            _playerOneColour = _menuScreen._mainMenu._playerOneColour.Color;
            _playerTwoColour = _menuScreen._mainMenu._playerTwoColour.Color;

            _playerOnePaddle = new PlayerPaddle(40, (_pictureBoxCourt.Height / 2) - 60, _paddleSpeedY, _playerOneColour);
            _playerTwoPaddle = new PlayerPaddle(_pictureBoxCourt.Width - 40, (_pictureBoxCourt.Height / 2) - 60, _paddleSpeedY, _playerTwoColour);
            _ball = new Ball((_pictureBoxCourt.Width / 2) - 15, (_pictureBoxCourt.Height / 2) - 15, _ballSpeedX, _ballSpeedY);
        }

        private void _pictureBoxCourt_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(Brushes.White, (_pictureBoxCourt.Width / 2) - 5, 0, 5, _pictureBoxCourt.Height);
            _playerOnePaddle.Display(graphics);
            _playerTwoPaddle.Display(graphics);
            _ball.Display(graphics);
        }

        private void _animationTimer_Tick(object sender, EventArgs e)
        {
            Random randomPos = new Random();
            _ball.Move();
            _pOneCombo.Text = _playerOneHitCount.ToString();
            _pTwoCombo.Text = _playerTwoHitCount.ToString();
            _labelPlayerOneName.Text = _playerOneName + ": " + _playerOneScore.ToString();
            _labelPlayerTwoName.Text = _playerTwoName + ": " + _playerTwoScore.ToString();


            // Smash Functions
            if (_playerOneHitCount >= 4)
            {
                _pOneSmashStatus.Text = "READY";

                if (_playerOneCrossSmash == true && _playerOneHitCount >= 4 && _playerOnePaddle.Returns(_ball))
                {
                    _playerOnePaddle.Smash(_ball);
                    _playerOneHitCount = 0;
                }
                else if (_playerOneStraightSmash == true && _playerOneHitCount >= 4 && _playerOnePaddle.Returns(_ball))
                {
                    _playerOnePaddle.StraightSmash(_ball);
                    _playerOneHitCount = 0;
                }
            }
            else
            {
                _pOneSmashStatus.Text = "NOT READY";
            }

            if (_playerTwoHitCount >= 4)
            {
                _pTwoSmashStatus.Text = "READY";

                if (_playerTwoCrossSmash == true && _playerTwoPaddle.Returns(_ball))
                {
                    _playerTwoPaddle.Smash(_ball);
                    _playerTwoHitCount = 0;
                }
                else if (_playerTwoStraightSmash == true && _playerTwoPaddle.Returns(_ball))
                {
                    _playerTwoPaddle.StraightSmash(_ball);
                    _playerTwoHitCount = 0;
                }
            }
            else
            {
                _pTwoSmashStatus.Text = "NOT READY";
            }


            // Movement functions for player 1
            if (_wKeyDown == true && _playerOnePaddle.Y > 0)
            {
                _playerOnePaddle.MoveUp();
            }
            else if (_sKeyDown == true && (_playerOnePaddle.Y + 120) < _pictureBoxCourt.Height)
            {
                _playerOnePaddle.MoveDown();
            }

            // Movement functions for player 2
            if (_upKeyDown == true && _playerTwoPaddle.Y > 0)
            {
                _playerTwoPaddle.MoveUp();
            }
            else if (_downKeyDown == true && (_playerTwoPaddle.Y + 120) < _pictureBoxCourt.Height)
            {
                _playerTwoPaddle.MoveDown();
            }


            // When player 1 or player 2 hits the ball
            if (_playerOnePaddle.Returns(_ball))
            {
                _ball.MoveToOpponent();
                _ball.XSpeed += 1;
                _playerOneHitCount++;
            }
            else if (_playerTwoPaddle.Returns(_ball))
            {
                _ball.MoveToOpponent();
                _ball.XSpeed -= 1;
                _playerTwoHitCount++;
            }


            // When ball goes out of bounds
            if (_ball.X <= 0)
            {
                _playerTwoScore++;
                _ball.X = _pictureBoxCourt.Width / 2;
                _ball.Y = randomPos.Next(100, 500);

                _ball.XSpeed = 6;
                _ball.YSpeed = 6;
            }
            else if (_ball.X + _ball.Width >= _pictureBoxCourt.Width)
            {
                _playerOneScore++;
                _ball.X = _pictureBoxCourt.Width / 2;
                _ball.Y = randomPos.Next(100, 500);

                _ball.XSpeed = -6;
                _ball.YSpeed = -6;
            }


            if (_playerOneScore == 7)
            {
                _animationTimer.Stop();
                MessageBox.Show(_playerOneName + " win!");

                gameScreen2.Hide();
                _menuScreen._mainMenu.Show();
            }
            else if(_playerTwoScore == 7)
            {
                _animationTimer.Stop();
                MessageBox.Show(_playerTwoName + " win!");

                gameScreen2.Hide();
                _menuScreen._mainMenu.Show();
            }

            _pictureBoxCourt.Refresh();
        }

        private void _gameScreen2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                _wKeyDown = true;
            }
            if (e.KeyCode == Keys.S)
            {
                _sKeyDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                _upKeyDown = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                _downKeyDown = true;
            }

            if (e.KeyCode == Keys.D)
            {
                _playerOneCrossSmash = true;
            }
            if (e.KeyCode == Keys.E)
            {
                _playerOneStraightSmash = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                _playerTwoCrossSmash = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                _playerTwoStraightSmash = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                _animationTimer.Stop();
                _pauseMenu.pauseMenu.Show();
            }

            if (e.KeyCode == Keys.G)
            {
                _animationTimer.Start();
            }
        }

        private void _gameScreen2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                _wKeyDown = false;
            }
            if (e.KeyCode == Keys.S)
            {
                _sKeyDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                _upKeyDown = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                _downKeyDown = false;
            }

            if (e.KeyCode == Keys.D)
            {
                _playerOneCrossSmash = false;
            }
            if (e.KeyCode == Keys.E)
            {
                _playerOneStraightSmash = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                _playerTwoCrossSmash = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                _playerTwoStraightSmash = false;
            }
        }
    }
}
