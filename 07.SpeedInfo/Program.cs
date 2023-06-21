namespace _07.SpeedInfo;

internal class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        if (type == "square")
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("{0:f3}", area);

        }
        else if (type == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine("{0:f3}", area);

        }
        else if (type == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("{0:f3}", area);
        }
        else if (type == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2;
            Console.WriteLine("{0:f3}", area);
        }
    }
}