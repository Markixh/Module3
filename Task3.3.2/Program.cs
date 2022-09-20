namespace Task3_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Myname = "Андрей";
            const byte Age = 39;
            const Boolean Ifpit = false;
            const float Fsize = 42;

            var Ip = Ifpit == true ? "да" : "нет";

            Console.WriteLine("Меня зовут {0}", Myname);            
            Console.WriteLine("Мне {0} лет", Age);    
            Console.WriteLine("Есть ли у вас питомец? {0}", Ip);            
            Console.WriteLine("Мой размер ноги {0}", Fsize);
            Console.ReadKey();
        }
    }
}