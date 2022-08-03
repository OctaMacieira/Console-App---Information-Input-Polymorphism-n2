using System;
using System.Globalization;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp, velMed;
            double cons;

            Console.WriteLine("Insira o tempo de viagem: ");
            temp = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a velocidade média: ");
            velMed = int.Parse(Console.ReadLine());

            cons = (double) (temp * velMed) / 12;

            Console.WriteLine(cons.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
