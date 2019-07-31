using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of the box in cm:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of the box in cm:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of the box in cm:");
            double height = double.Parse(Console.ReadLine());


            Box b1 = new Box(width, length, height);

            Console.WriteLine($"The surface area of the box is: {b1.SurfaceArea()}cm and the volume is:{b1.Volume()}cm");

            Console.ReadLine();
        
        }

        class Box
        {
            public double Width { get; set; }
            public double Length { get; set; }
            public double Height { get; set; }

            public Box(double _width, double _length, double _height)
            {
                Width = _width;
                Length = _length;
                Height = _height;
            }

           public double SurfaceArea()
               {
               
                return 2* (Height * Width) + 2*(Height * Length) + 2*(Width * Length);
                
               }

            public double Volume()
            {
                return Length * Width * Height;
            }
        }
    }
}
