using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cube cube = new Cube();
            ////Cylinder cylinder = new Cylinder();
            //Rhombus rhombus = new Rhombus();
            //Square square = new Square();
            Shape shape;


            Console.WriteLine("Select a shape: ");
            Console.WriteLine("Circle, Square, Rhombus, Cube, Cylinder");
            string shapeName = Console.ReadLine();
            //Console.ReadKey();

            switch (shapeName)
            {
                case "Circle":
                    Console.WriteLine("Radius Number = ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    shape = new Circle(r);
                    break;
                case "Square":
                    Console.WriteLine("Height Number = ");
                    int Height = Convert.ToInt32(Console.ReadLine());
                    shape = new Square(Height);
                    break;
                case "Rhombus":
                    Console.WriteLine("Diagonal p Number = ");
                    int HeightRhombus = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Diagonal q Number = ");
                    int WidthRhombus = Convert.ToInt32(Console.ReadLine());
                    shape = new Rhombus(HeightRhombus, WidthRhombus);
                    break;
                case "Cube":
                    Console.WriteLine("Side Cube = ");
                    int HeightCube = Convert.ToInt32(Console.ReadLine());
                    shape = new Cube(HeightCube);
                    break;
                case "Cylinder":
                    Console.WriteLine("Radius Number = ");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Height Number = ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    shape = new Cylinder(radius, height);
                    break;
                default:
                    shape = new Shape();
                    break;
            }

            Console.WriteLine("Area of " + shapeName + " is: " + shape.calculateArea());
            Console.WriteLine("Number of sides is " + shape.NumberOfSides);

            Console.ReadKey();
        }
    }
}
