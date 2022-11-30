// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace ConsoleApp001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius:");
            double r = double.Parse(Console.ReadLine());
            var S = 3.14 * r * r;
            Console.Write("S = " +S);
        }
    }
}
