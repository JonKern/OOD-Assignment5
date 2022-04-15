using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Shapes
{
    public class Rectangle : Shape
    {
        //constructors
        public Rectangle()
        {
            new Rectangle(defaultHeight, defaultWidth);
        }
        public Rectangle(double height, double width)
        {
            this._height = height;
            this._width = width;
        }

        //fields
        private double _height;
        private double _width;
        public const double defaultHeight = 0;
        public const double defaultWidth = 0;

        //properties
        public double Height 
        {
            get { return _height; }

            set { _height = value; }           
        }

        public double Width
        {
            get { return _width; }

            set { _width = value; }
        }


        //methods
        private double CalculatePerimeter(double _height, double _width)
        {
            return _height * _width;
        }

        public override double CalculatePerimeter()
        {
            return CalculatePerimeter(_height, _width);
        }

        public static bool operator >(Rectangle rec1, Rectangle rec2)
        {
            return rec1.CalculatePerimeter() > rec2.CalculatePerimeter();
        }
        public static bool operator >=(Rectangle rec1, Rectangle rec2)
        {
            return rec1.CalculatePerimeter() >= rec2.CalculatePerimeter();
        }
        public static bool operator <(Rectangle rec1, Rectangle rec2)
        {
            return rec1.CalculatePerimeter() < rec2.CalculatePerimeter();
        }
        public static bool operator <=(Rectangle rec1, Rectangle rec2)
        {
            return rec1.CalculatePerimeter() <= rec2.CalculatePerimeter();
        }
   
        public static bool operator ==(Rectangle rec1, Rectangle rec2)
        {
            return rec1.CalculatePerimeter() == rec2.CalculatePerimeter();
        }
        public static bool operator !=(Rectangle rec1, Rectangle rec2)
        {
            return rec1.CalculatePerimeter() != rec2.CalculatePerimeter();
        }
    }
}
