namespace Shape
{
    public class Circle : IShape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public double Area()
        {
            return Math.PI * R * R;
        }
    }
}
