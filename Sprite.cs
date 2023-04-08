using System.Drawing;

namespace Pong_Game
{
    public abstract class Sprite
    {
        // Instance Variables

        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private int _xSpeed;
        private int _ySpeed;
        private Color _colour;

        // Constructor

        public Sprite(int x, int y, int width, int height, int xSpeed, int ySpeed, Color colour)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            _xSpeed = xSpeed;
            _ySpeed = ySpeed;
            _colour = colour; 
        }

        // Properties

        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public int XSpeed { get { return _xSpeed; } set { _xSpeed = value; } }
        public int YSpeed { get { return _ySpeed; } set { _ySpeed = value; } }

        public Color Colour { get { return _colour; } set { _colour = value; } }

        public Rectangle HitBox { get { return new Rectangle(_x, _y, _width, _height); } }

        // Public Methods

        public abstract void Display(Graphics graphics);

        public abstract void Move();

        public bool Returns(Sprite other)
        {
            Rectangle paddle = HitBox;
            Rectangle ball = other.HitBox;
            return paddle.IntersectsWith(ball);
        }
    }
}
