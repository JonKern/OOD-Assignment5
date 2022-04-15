namespace Assignment5Shapes
{
    class Program
    {
        public static Rectangle GetRectangle()
        {
            Console.WriteLine("Enter a positive value for the height: ");

            var rectHeightAsString = Console.ReadLine();
            double rectHeight;

            while (!double.TryParse(rectHeightAsString, out rectHeight) || (rectHeight <= 0))
            {
                if (rectHeight <= 0)
                    Console.WriteLine("Value must be greater than 0.\n");
                else
                    Console.WriteLine("Invalid value was entered.\n");

                Console.WriteLine("Enter a positive value for the height: ");
                rectHeightAsString = Console.ReadLine();
            }

            Console.WriteLine("Enter a positive value for the width: ");

            var rectWidthAsString = Console.ReadLine();
            double rectWidth;

            while (!double.TryParse(rectWidthAsString, out rectWidth) || (rectWidth <= 0))
            {
                if (rectWidth <= 0)
                    Console.WriteLine("Value must be greater than 0.\n");
                else
                    Console.WriteLine("Invalid value was entered.\n");

                Console.WriteLine("Enter a positive value for the width: ");
                rectWidthAsString = Console.ReadLine();
            }
            Rectangle r = new(rectHeight, rectWidth);

            return r;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will compare the Perimeters of two Rectangles.\n");

            Console.WriteLine("First Rectangle");
            Console.WriteLine("---------------");
            Rectangle rect1 = GetRectangle();

            Console.WriteLine("\nSecond Rectangle");
            Console.WriteLine("---------------");
            Rectangle rect2 = GetRectangle();

            Console.WriteLine("\nThe Perimeter of the 1st Rectangle is : " 
                + Math.Round(rect1.CalculatePerimeter(), 4));
            Console.WriteLine("The Perimeter of the 2nd Rectangle is : " 
                + Math.Round(rect2.CalculatePerimeter(), 4));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1st Rectangle >  2nd Rectangle   |  " + (rect1 >  rect2));
            Console.WriteLine("1st Rectangle >= 2nd Rectangle   |  " + (rect1 >= rect2));
            Console.WriteLine("1st Rectangle <  2nd Rectangle   |  " + (rect1 <  rect2));
            Console.WriteLine("1st Rectangle <= 2nd Rectangle   |  " + (rect1 <= rect2));            
            Console.WriteLine("1st Rectangle == 2nd Rectangle   |  " + (rect1 == rect2));
            Console.WriteLine("1st Rectangle != 2nd Rectangle   |  " + (rect1 != rect2));
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            return;
        }
    }
}