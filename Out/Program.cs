using System;
using Domain;

namespace Out
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cake instaCookie = new Cake();

            instaCookie.Id = 5;

            Console.WriteLine(instaCookie.Id);

            Console.ReadLine();
        }
    }
}