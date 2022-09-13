using System;

/*
O herói e o monstro começarão com dez pontos de integridade
Todos os ataques serão um valor entre 1 e 10
O herói atacará primeiro
Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele
Se a integridade do monstro for maior que zero, ele poderá atacar o herói
Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele
Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos
Imprima quem foi o vencedor

 */

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroiNivelVida = 10;
            int monsterNivelVida = 10;
            Random dado = new Random();

            while (heroiNivelVida >= 0 && monsterNivelVida >= 0)
            {
                Console.WriteLine("-----------------------------");
                
                Console.WriteLine("-- Herói ataca! ---");
                
                int dadoJogado = dado.Next(1, 6);
                monsterNivelVida -= dadoJogado;
                Console.WriteLine($"Mostro perdeu {dadoJogado} de vida.| Vida restante: {monsterNivelVida}");

                if (monsterNivelVida <= 0) break;
                
                Console.WriteLine("-- Monstro contra-ataca! ---");
                dadoJogado = dado.Next(1, 6);
                heroiNivelVida -= dadoJogado;
                Console.WriteLine($"Herói perdeu {dadoJogado} de vida.| Vida restante: {heroiNivelVida}");

            }

            Console.WriteLine("-----------------------------");
           
            string vencedor = (heroiNivelVida > monsterNivelVida) ? vencedor = "Herói" : vencedor = "Monstro";

            Console.WriteLine(vencedor);
        }
    }
}
