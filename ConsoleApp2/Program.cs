using System;



namespace Arvore_asteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            String rep;

            Console.WriteLine("Digite o numero de linhas para a arvore");
            N = Convert.ToInt32(Console.ReadLine());

            do
            {

                for (int i = 0; i <= N; i++)
                {

                    for (int j = N; j >= i; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Deseja alterar o tamando da arvore? S ou N");
                rep = Console.ReadLine();

                if (rep == "S" || rep == "s")
                {

                    Console.WriteLine("Digite o novo tamando da arvore");
                    N = Convert.ToInt32(Console.ReadLine());
                }

            } while (rep == "S" || rep == "s");


        }

    }
}
