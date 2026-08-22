using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        //private Point2D _position;
        private float _x;
        private float _y;

        private int _width;
        private int _height;

        public Shape(int param)
        {
            _color = Color.Red;
            _x = 0;
            _y = 0;
            _width = param;
            _height = param;
        }
 
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }   
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

      
    }
}