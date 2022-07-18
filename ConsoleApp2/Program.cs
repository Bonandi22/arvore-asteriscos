using System;



namespace Arvore_Asteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
           
            Console.WriteLine("Digite o numero de linhas para a arvore");
            N = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= N; i++)
            {
                for (int j = N; j > i; j--)
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


        }               
        

    }
}
