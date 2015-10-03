using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantas horas você dormiu na última noite?");
            int horasDormidas = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);

            if (horasDormidas < 8)
            {
                Console.WriteLine("Você deve estar cansado!");
            }
            else
            {
                Console.WriteLine("Você parece estar bem descansado!");
            }
        }
    }
}

