using System;

namespace Tabuada_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual Tabuada você quer saber?");
            int tabuada = int.Parse(Console.ReadLine());

            int contador = 0;

            while(contador <= 10){

                Console.WriteLine(tabuada * contador);
                contador = contador + 1;
                
            }
        }
    }
}
