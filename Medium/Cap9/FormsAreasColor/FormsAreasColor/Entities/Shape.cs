using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsAreasColor.Entities.Enums;

namespace FormsAreasColor.Entities
{
    internal abstract class Shape
    {
        // Properties for the shape's dimensions
        public ShapeColor color { get; set; }

        // Constructor to initialize the shape with a color
        public Shape(ShapeColor color)
        {
            color = color;
        }

        // method to calculate the area of the shape
        public abstract double Area();


    }
}
