using System;
using System.Drawing;

namespace Pong_Game
{
    class Ball : Sprite
    {
        // Instance variables
        // Constants

        private const int BALL_WIDTH = 30;
        private const int BALL_HEIGHT = 30;

        // Constructor

        public Ball(int x, int y, int ballSpeedX, int ballSpeedY)
            : base(x, y, BALL_WIDTH, BALL_HEIGHT, ballSpeedX, ballSpeedY, Color.Orange)
        {
        }

        // Public Methods

        public override void Display(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Orange, X, Y, BALL_WIDTH, BALL_HEIGHT);
        }

        public override void Move()
        {
            X += XSpeed;
            Y += YSpeed;

            if (Y <= 0 || (Y + 30) >= 694)
            {
                YSpeed = -YSpeed;
            }

            if (X <= 0 || (X + 30) >= 1291)
            {
                XSpeed = -XSpeed;
            }
        }

        public void MoveToOpponent()
        {
            Random rand = new Random();
            
            XSpeed = -XSpeed;

            if (rand.Next(0, 2) == 1)
            {
                YSpeed = -YSpeed;
            }
            else if(rand.Next(0, 2) == 2)
            {
                YSpeed = YSpeed;
            }
            
            Move();
        }
    }
}
