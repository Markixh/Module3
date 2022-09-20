namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше Имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваше имя {name}, а возраст {age}");
            Console.Write("Введите дату своего рождения: ");
            var birtdate = Console.ReadLine();
            Console.Write("Ты родился {0}", birtdate);
            Console.ReadKey();
        }        
    }
}