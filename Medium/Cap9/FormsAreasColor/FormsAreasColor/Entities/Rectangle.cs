using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsAreasColor.Entities.Enums;

namespace FormsAreasColor.Entities
{
    internal class Rectangle : Shape
    {
        // Properties for the rectangle's dimensions
        public double Width { get; set; }
        public double Height { get; set; }

        //contructor to initialize the rectangle with a color
        public Rectangle(double width, double height, ShapeColor color) : base(color)
        {
            Width = width;
            Height = height;
        }

        // Method to calculate the area of the rectangle
        public override double Area()
        {
            return Width * Height;
        }

        // ToString method to return the rectangle's details
        public override string ToString()
        {
            return $"Rectangle: Color = {color}, Width = {Width}, Height = {Height}, Area = {Area()}";
        }

    }

}
