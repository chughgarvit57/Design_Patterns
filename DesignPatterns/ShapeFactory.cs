using System.Drawing;

namespace DesignPatterns
{
    public class ShapeFactory
    {
        public static IShape? CreateShape(string shapeType)
        {
            if(shapeType.ToLower() == "circle")
            {
                return new Circle();
            }
            else if (shapeType.ToLower() == "rectangle")
            {
                return new MyRectangle();
            }
            else
            {
                return null;
            }
        }
    }
}
