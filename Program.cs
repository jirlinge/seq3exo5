using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime thisDay = DateTime.Today;
            Console.WriteLine("renseignez votre nom");
            string name = Console.ReadLine();
            Console.WriteLine("renseignez votre prénom");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Bonjour {firstName} {name} nous somme le {thisDay:D} comment allez vous?");
        }
    }
}
