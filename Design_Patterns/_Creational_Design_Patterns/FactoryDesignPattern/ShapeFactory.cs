namespace FactoryPattern
{
    class ShapeFactory
    {
        public IShape GetShape(string shapeName)
        {
            return shapeName switch {
                "Rectangle" => new Rectangle(),
                "Circle" => new CircleShape(),
                _ => new CircleShape()
            };
        }
    }
}