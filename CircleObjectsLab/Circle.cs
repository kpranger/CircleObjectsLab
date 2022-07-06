using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    internal class Circle
    {
        //Properties
        public double Radius;

        //Constructor
        public Circle(double _radius)
        {
            Radius = _radius;
        }

        //Methods
        public double CalculateCircumference()
        {
            double circumference = (2 * Math.PI * Radius);
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            string formattedCircumference = FormatNumber(CalculateCircumference());
            return formattedCircumference;
        }
        public double CalculateArea()
        {
            double area = (Math.PI * (Radius * Radius));
            return area;
        }
        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
