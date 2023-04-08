using System.Drawing;

namespace Pong_Game
{
    class PlayerPaddle : Paddles
    {
        public PlayerPaddle(int x, int y, int paddleSpeedY, Color paddleColour)
            : base(x, y, paddleSpeedY, paddleColour)
        {
        }

        public void Smash(Ball ball)
        {
            if (ball.X < 645)
            {
                ball.XSpeed -= 15;
            }
            else if (ball.X > 645)
            {
                ball.XSpeed += 15;
            }
        }

        public void StraightSmash(Ball ball)
        {
            if (ball.X < 645)
            {
                ball.XSpeed -= 15;
                ball.YSpeed = 0;
            }
            else if (ball.X > 645)
            {
                ball.XSpeed += 15;
                ball.YSpeed = 0;
            }
        }
    }
}
