using System;

namespace NumerosImparesURI1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //Faz a leitura de um numero informado pelo usuario
            x = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= x; i++) 
            {
                
                //Imprime todos os numeros impares, inclusive o informado se for o caso
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
