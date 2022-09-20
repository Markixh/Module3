using System.Xml.Linq;

namespace Task3_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane";
            Console.WriteLine(MyName);
            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 27 лет");
            Console.WriteLine("\tMy name is\n {0}", MyName);
            Console.ReadLine();
        }
    }
}