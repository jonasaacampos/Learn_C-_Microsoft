using System;

/*
 Há seis partes na instrução for.

A palavra-chave for.
Um conjunto de parênteses que define as condições da iteração for. Ele contém três partes distintas, separadas pelo fim do operador de instrução, um ponto e vírgula.
A primeira parte define e inicializa a variável de iterador. Neste exemplo: int i = 0. A documentação refere-se a esta seção como o inicializador.
A segunda parte define a condição de conclusão. Neste exemplo: i < 10. Em outras palavras, o tempo de execução continuará iterando sobre o código no bloco de código embaixo da instrução for, enquanto i for menor que 10. Quando i se torna igual a 10, o runtime para de executar o bloco de código da instrução do for. A documentação refere-se a esta seção como a condição.
A terceira parte define a ação a ser executada após cada iteração. Nesse caso, após cada iteração, i++ incrementará o valor de i em 1. A documentação refere-se a esta seção como o iterador.
Finalmente, o bloco de código. Esse é o código que será executado para cada iteração. Observe que o valor de i é referenciado dentro do bloco de código. A documentação refere-se a esta seção como o corpo.
 */

namespace ConsoleApp2
{
   internal class Program
   {
      static void Main(string[] args)
      {
         for (int i = 1; i <= 100; i++)
         {

            string result = (i % 3 == 0 && i % 5 != 0) ? i + " - Fizz" : i.ToString();

            if (i % 5 == 0)
            {
               result = i + " - Buzz";
            }

            if (i % 3 == 0 && i % 5 == 0)
            {
               result = i + " - FizzBuzz";
            }

            Console.WriteLine(result);
         }
      }
   }
}
