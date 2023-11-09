using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModulWork
{
    public class ShapeContainer
    {
        private List<Shape> shapes;

        public ShapeContainer()
        {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            if (shape != null)
            {
                shapes.Add(shape);
            }
        }
        public void ClearShapes()
        {
            shapes.Clear();
        }
        public string GetShapeNames()
        {
            StringBuilder names = new StringBuilder();

            foreach (Shape shape in shapes)
            {
                names.AppendLine($"Назва фігури: {shape.Name}");
            }

            return names.ToString();
        }

        public string GetShapeData()
        {
            StringBuilder data = new StringBuilder();

            foreach (Shape shape in shapes)
            {
                if (shape is PentagonalPyramid)
                {
                    PentagonalPyramid pyramid = (PentagonalPyramid)shape;
                    data.AppendLine($"BaseSide: {pyramid.BaseSide}");
                    data.AppendLine($"SlantHeight: {pyramid.SlantHeight}");
                }
                if (shape is IsoscelesTriangle)
                {
                    IsoscelesTriangle pyramid = (IsoscelesTriangle)shape;
                    data.AppendLine($"Base: {pyramid.Base}");
                    data.AppendLine($"Height: {pyramid.Height}");
                }
                if (shape is Rhombus)
                {
                    Rhombus pyramid = (Rhombus)shape;
                    data.AppendLine($"Side: {pyramid.Side}");
                }
                if (shape is Trapezoid)
                {
                    Trapezoid pyramid = (Trapezoid)shape;
                    data.AppendLine($"Base1: {pyramid.Base1}");
                    data.AppendLine($"Base2: {pyramid.Base2}");
                    data.AppendLine($"Height: {pyramid.Height}");
                }
            }
            return data.ToString();
        }

        public string GetShapeCalculations()
        {
            StringBuilder calculations = new StringBuilder();

            foreach (Shape shape in shapes)
            {
                if (shape is IPerimeter)
                {
                    double perimeter = ((IPerimeter)shape).CalculatePerimeter();
                    calculations.AppendLine($"Периметр: {Math.Round(perimeter, 2)}");
                }

                if (shape is IShapeArea)
                {
                    double area = ((IShapeArea)shape).CalculateArea();
                    calculations.AppendLine($"Площа: {Math.Round(area, 2)}");
                }

                if (shape is I3D)
                {
                    double volume = ((I3D)shape).CalculateVolume();
                    calculations.AppendLine($"Об'єм: {Math.Round(volume,2)}");
                    double area = ((I3D)shape).CalculateArea();
                    calculations.AppendLine($"Площа: {Math.Round(area, 2)}");
                }

                if (shape is IInscribedCircle)
                {
                    double circle = ((IInscribedCircle)shape).CalculateInscribedCircleRadius();
                    calculations.AppendLine($"Впис к: {Math.Round(circle, 2)}");
                }

                if (shape is ICircumscribedCircle)
                {
                    double circle = ((ICircumscribedCircle)shape).CalculateCircumscribedCircleRadius();
                    calculations.AppendLine($"Опис к: {Math.Round(circle, 2)}");
                }
            }
            
            return calculations.ToString();
        }
    }
}
