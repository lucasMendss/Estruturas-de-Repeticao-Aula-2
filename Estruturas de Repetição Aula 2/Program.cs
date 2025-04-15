using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição_Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ExibeTabuada()
            {
                int num1 = 0;
                bool convertedToInt = false;

                while (!convertedToInt)
                {
                    Console.WriteLine("Digite um valor entre 1 e 10:");
                    convertedToInt = int.TryParse(Console.ReadLine(), out num1);

                    if (!convertedToInt || num1 < 1 || num1 > 10)
                    {
                        Console.WriteLine("Valor inválido!");
                        convertedToInt = false;
                    }
                }

                Console.Clear();
                Console.WriteLine("Tabuada do {0}:", num1);
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("{0} x {1} = {2} ", num1, i, num1 * i);
                }
            }

            void SomaInteiros ()
            {
                int soma = 0;
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("{0} + {1} = {2}",i, (i + 1), i + (i+1));
                    soma = soma + i;
                }
                Console.WriteLine("A soma dos 100 primeiros números inteiros é " + soma);
            }

            void Verifica10Numeros ()
            {
                int num = 0, maior = 0, menor = 0, soma = 0;
                for (int i = 1; i <= 10;  i++)
                {
                    bool convertedToInt = false;

                    while (!convertedToInt)
                    {
                        Console.WriteLine("Digite um valor ({0}º vez):", i);
                        convertedToInt = int.TryParse(Console.ReadLine(), out num);

                        if (!convertedToInt)
                        {
                            Console.WriteLine("Valor inválido!");
                            convertedToInt = false;
                        }
                    }

                    if (num >= maior)
                    {
                        maior = num;
                        menor = num;
                    }
                    else if (num <= menor)
                    {
                        menor = num;
                    }

                    soma = soma + num;
                }
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Maior:" + maior);
                Console.WriteLine("Menor:" + menor);
                Console.WriteLine("Soma dos valores: " + soma);
            }
            Verifica10Numeros();
            Console.ReadKey();
        }
    }
}
