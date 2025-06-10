using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsAreasColor.Entities.Enums;


namespace FormsAreasColor.Entities
{
    internal class Circle : Shape
    {
        // Property for the circle's radius
        public double Radius { get; set; }
        // Constructor to initialize the circle with a color and radius
        public Circle(double radius, ShapeColor color) : base(color)
        {
            Radius = radius;
        }
        // Method to calculate the area of the circle
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        //ToString method to return the circle's details
        public override string ToString()
        {
            return $"Circle: Color = {color}, Radius = {Radius}, Area = {Area()}";
        }
    }
}
