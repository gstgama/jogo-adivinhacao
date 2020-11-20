using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Semestral_Att
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar como deixar numeros sorteados em ordem crescente
           
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("========== :: BEM VINDO AO JOGO DE ADIVINHAÇÃO :: ==========");
                Console.WriteLine();

                Adivinhacao objJogo = new Adivinhacao();

                Console.Write("Nome: ");
                objJogo.Nome = Console.ReadLine();

                Console.WriteLine("* Nível 1 - números de 1 a 20, com 5 chances para acertar.");
                Console.WriteLine("* Nível 2- números de 1 a 40, com 10 chances para acertar.");
                Console.Write($"{objJogo.Nome}, escolha o nivel: ");
                objJogo.Nivel = int.Parse(Console.ReadLine());

                NivelUm objNivelUm = new NivelUm();
                NivelDois objNivelDois = new NivelDois();

                if (objJogo.Nivel == 1)
                {
                    objNivelUm.Play();
                }
                else if (objJogo.Nivel == 2)
                {
                    objNivelDois.Play();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Nivel não existente! ");
                    Console.WriteLine();
                }

                Console.WriteLine("Deseja jogar novamente? ");
                objJogo.JogarNovamente = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (objJogo.JogarNovamente == "SIM")
                {
                    sair = false;
                }
                else if (objJogo.JogarNovamente == "NAO")
                {
                    sair = true;
                }
                
                /*{
                    Console.WriteLine("* Nível 1 - números de 1 a 20, com 5 chances para acertar.");
                    Console.WriteLine("* Nível 2 - números de 1 a 40, com 10 chances para acertar.");
                    Console.Write($"{objJogo.Nome}, escolha o nivel: ");
                    objJogo.Nivel = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (objJogo.Nivel == 1)
                    {
                        objNivelUm.Play();
                    }
                    else if (objJogo.Nivel == 2)
                    {
                        objNivelDois.Play();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nivel não existente! ");
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("========== :: Fim de jogo :: ==========");
                }*/
            }

            Console.WriteLine();
            Console.WriteLine("========== :: Fim de jogo :: ==========");
        }
    }
}
