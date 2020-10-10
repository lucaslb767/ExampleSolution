using System;

namespace EaeManoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("what's your name");
            name = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?");
            age = int.Parse(Console.ReadLine());
        }
    }
}
