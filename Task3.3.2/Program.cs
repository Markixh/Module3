namespace Task3_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Myname = "Андрей";
            Console.WriteLine("Меня зовут {0}", Myname);
            const byte Age = 39;
            Console.WriteLine("Мне {0} лет", Age);
            const Boolean Ifpit = false;
            var Ip = Ifpit == true ? "да" : "нет";
            Console.WriteLine("Есть ли у вас питомец? {0}", Ip);
            const float Fsize = 42;
            Console.WriteLine("Мой размер ноги {0}", Fsize);
            Console.ReadKey();
        }
    }
}