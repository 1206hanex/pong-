using System.Drawing;

namespace Pong_Game
{
    class Paddles : Sprite
    {
        // Instance Variables
        // Constants

        private const int PADDLE_WIDTH = 10;
        private const int PADDLE_HEIGHT = 120;

        private int _paddleSpeed;

        private Color _paddleColour;

        // Constructor

        public Paddles(int x, int y, int paddleSpeed, Color paddleColour)
            : base(x, y, PADDLE_WIDTH, PADDLE_HEIGHT, 0, paddleSpeed, paddleColour)
        {
            _paddleSpeed = paddleSpeed;
            _paddleColour = paddleColour;
        }

        // Public Methods

        public void MoveUp()
        {
            Y -= YSpeed;
        }

        public void MoveDown()
        {
            Y += YSpeed;
        }
        
        public override void Move()
        {
            Y += YSpeed;

            if (Y < 0 || (Y + 120) > 694)
            {
                YSpeed = -YSpeed;
            }
        }

        public override void Display(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Colour);
            graphics.FillRectangle(brush, X, Y, PADDLE_WIDTH, PADDLE_HEIGHT);
        }
    }
}
