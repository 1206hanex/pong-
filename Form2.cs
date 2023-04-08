using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class _gameScreen1 : Form
    {
        // Instance variables

        public static _gameScreen1 gameScreen1;
        public Timer _timer1;

        private PlayerPaddle _playerPaddle;
        private CpuPaddle _cpuPaddle;
        private Ball _ball;
        private Color _playerColour;

        private bool _wKeyDown;
        private bool _sKeyDown;
        private bool _playerCrossSmash;

        private int _ballSpeedX = -5;
        private int _ballSpeedY = -5;
        private int _paddleSpeedY = 8;

        private int _playerScore;
        private int _cpuScore;
        private int _playerHitCount;

        private string _playerName;
        
        public _gameScreen1()
        {
            InitializeComponent();

            gameScreen1 = this;
            _timer1 = _animationTimer;
            _playerName = _menuScreen._mainMenu._playerOneTB.Text;
            _playerColour = _menuScreen._mainMenu._playerOneColour.Color;

            _playerPaddle = new PlayerPaddle(40, (_pictureBoxCourt.Height / 2) - 60, _paddleSpeedY, _playerColour);
            _cpuPaddle = new CpuPaddle(_pictureBoxCourt.Width - 50, (_pictureBoxCourt.Height / 2) - 60, _paddleSpeedY, Color.Red);
            _ball = new Ball((_pictureBoxCourt.Width / 2) - 15, (_pictureBoxCourt.Height / 2) - 15, _ballSpeedX, _ballSpeedY);
        }


        private void _pictureBoxCourt_Paint(object sender, PaintEventArgs e)
        {  
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(Brushes.White, (_pictureBoxCourt.Width / 2) - 5, 0, 5, _pictureBoxCourt.Height);
            _playerPaddle.Display(graphics);
            _cpuPaddle.Display(graphics);
            _ball.Display(graphics);
        }


        private void _animationTimer_Tick(object sender, EventArgs e)
        {
            Random randomPos = new Random();

            _ball.Move();
            _cpuPaddle.FollowBall(_cpuPaddle, _ball);
            _labelPlayerCombo.Text = _playerHitCount.ToString();
            _labelPlayerName.Text = _playerName + ": " + _playerScore.ToString();
            _labelCpuName.Text = "CPU: " + _cpuScore.ToString();

            
            // Smash function
            if (_playerHitCount >= 4)
            {
                _labelSmashStatus.Text = "READY";

                if (_playerPaddle.Returns(_ball) && _playerCrossSmash == true)
                {
                    _playerPaddle.Smash(_ball);
                    _playerHitCount = 0;
                    _cpuPaddle.YSpeed = 0;
                } 
            }
            else
            {
                _labelSmashStatus.Text = "NOT READY";
            }


            // When player & cpu paddles hit the ball
            if (_playerPaddle.Returns(_ball))
            {
                _ball.MoveToOpponent();
                _ball.XSpeed += 1;
                _playerHitCount++;
            }
            else if (_cpuPaddle.Returns(_ball))
            {
                _ball.MoveToOpponent();
                _ball.XSpeed -= 2;
            }


            // When ball goes out of bounds
            if (_ball.X <= 0)
            {
                _cpuScore++;
                _ball.X = _pictureBoxCourt.Width / 2;
                _ball.Y = randomPos.Next(100, 500);

                _ball.XSpeed = 6;
            }
            else if (_ball.X + _ball.Width >= _pictureBoxCourt.Width)
            {
                _playerScore++;
                _ball.X = _pictureBoxCourt.Width / 2;
                _ball.Y = randomPos.Next(100, 500);

                _ball.XSpeed = -6;
                _cpuPaddle.YSpeed = 7;
            }
            
            
            // Win handling
            if (_playerScore == 7)
            {
                _animationTimer.Stop();
                MessageBox.Show(_playerName + " win!");

                gameScreen1.Hide();

                _menuScreen._mainMenu.Show();
            }
            else if(_cpuScore == 7)
            {
                _animationTimer.Stop();
                MessageBox.Show("CPU win!");

                gameScreen1.Close();

                _menuScreen._mainMenu.Show();
            }


            // Movement functions for player paddle
            if (_wKeyDown == true && _playerPaddle.Y > 0)
            {
                _playerPaddle.MoveUp();
            }
            else if (_sKeyDown == true && (_playerPaddle.Y + 120) < _pictureBoxCourt.Height)
            {
                _playerPaddle.MoveDown();
            }

            _pictureBoxCourt.Refresh();
        }


        private void _gameScreen1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                _wKeyDown = true;
            }

            if (e.KeyCode == Keys.S)
            {
                _sKeyDown = true;
            }

            if (e.KeyCode == Keys.D)
            {
                _playerCrossSmash = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                _animationTimer.Stop();
                _pauseMenu.pauseMenu.Show();
            }

            if (e.KeyCode == Keys.Space)
            {
                _animationTimer.Start();
            }
        }


        private void _gameScreen1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                _wKeyDown = false;
            }

            if (e.KeyCode == Keys.S)
            {
                _sKeyDown = false;
            }

            if (e.KeyCode == Keys.D)
            {
                _playerCrossSmash = false;
            }
        }
    }
}
