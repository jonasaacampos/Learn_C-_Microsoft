using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random moeda = new Random();

            int jogada = moeda.Next(0, 2);
            string resultado = (jogada == 0) ? "cara" : "coroa";
            Console.WriteLine($"A moeda caiu em {resultado}");
        }
    }
}