using System.Drawing;

namespace Pong_Game
{
    class CpuPaddle : Paddles
    {
        public CpuPaddle(int x, int y, int paddleSpeedY, Color paddleColour)
            : base (x, y, paddleSpeedY, paddleColour)
        {
        }

        public override void Move()
        {
            Y += YSpeed;

            if (Y < 0 || (Y + 120) > 694)
            {
                YSpeed = -YSpeed;
            }
        }

        public void FollowBall(CpuPaddle paddle, Ball ball)
        {
            int paddleCentre = paddle.HitBox.Top + (paddle.Y / 2);
            int ballCentre = ball.HitBox.Top + (ball.Y / 2);

            if (paddleCentre < ballCentre)
            {
                Y += YSpeed;
            }
            else if (paddleCentre > ballCentre)
            {
                Y -= YSpeed;
            }
        }
    }
}
