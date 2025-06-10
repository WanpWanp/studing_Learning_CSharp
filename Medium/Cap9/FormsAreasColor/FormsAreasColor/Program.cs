using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsAreasColor.Entities;
using FormsAreasColor.Entities.Enums;

// Importing the necessary namespaces for the program
namespace FormsAreasColor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a list to hold shapes
            List<Shape> shapesList = new List<Shape>();

            // asking the user for the number of shapes to create
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            // Looping through the number of shapes
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nShape #{i} data:");
                // Asking the user for the type of shape
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine().ToLower());
                // Asking for the color of the shape
                Console.Write("Color (Red, Blue, Black): ");
                ShapeColor color = (ShapeColor)Enum.Parse(typeof(ShapeColor), Console.ReadLine(), true);
                // Creating a rectangle if the user chose 'r'
                if (shapeType == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapesList.Add(new FormsAreasColor.Entities.Rectangle(width, height, color));
                }
                // Creating a circle if the user chose 'c'
                else if (shapeType == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapesList.Add(new Circle(radius, color));
                }
            }
            //print the text shape areas
            Console.WriteLine("\nShape areas:");

            //Print the area, with type shape and color
            foreach (Shape shape in shapesList)
            {
                Console.WriteLine($"{shape.GetType().Name}: {shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

    }
}
