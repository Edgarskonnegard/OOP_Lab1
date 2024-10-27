namespace OOP_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            var area1 = circle1.GetArea();
            var area2 = circle2.GetArea();
        }
    }
}
