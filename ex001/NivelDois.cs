using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Semestral_Att
{
    class NivelDois : Adivinhacao
    {
        public void Play()
        {
            Random objRandom = new Random();
            NumeroSorteado = objRandom.Next(1, 40 + 1);
            /*Console.WriteLine($"** Numero sorteado: {NumeroSorteado} **"); //Numero Sorteado
            Console.WriteLine();*/
            Chances = 10;

            while (Chances > 0)
            {
                Console.Write("Digite um numero: ");
                NumeroEscolhido = int.Parse(Console.ReadLine());

                if (NumeroEscolhido == NumeroSorteado)
                {
                    Console.WriteLine("Parabens, voce acertou!");
                    Console.WriteLine();
                    Chances = -10;
                }
                else
                {
                    Chances--;
                    if (NumeroEscolhido > NumeroSorteado)
                    {
                        Console.WriteLine($"Numero maior que o sorteado! Chances restantes: {Chances}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Numero menor que o sorteado! Chances restantes: {Chances}");
                        Console.WriteLine();
                    }
                }
            }

            if (Chances == 0)
            {
                Console.WriteLine("Acabaram as chances, você perdeu!");
                Console.WriteLine();
            }

            Console.WriteLine();

        }
    }
}
