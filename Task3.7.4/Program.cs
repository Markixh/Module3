namespace Task3_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше Имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваше имя {name}, а возраст {age}");
            Console.Write("Какой твой любимый день недели (1..7)? ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Твой любимый день недели {0}", day);
            Console.ReadKey();
        }
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
    }
}