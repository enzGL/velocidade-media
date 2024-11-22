using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocidademedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valida = true;
            int distancia = 0;
            int tempo = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("CALCULADORA DE VELOCIDADE MÉDIA");
            Console.ResetColor();

            try
            {
                while (valida)
                {
                    Console.Write("\n\nDigite a distancia da viagem em KM: ");
                    string input = Console.ReadLine();

                    try
                    {
                        distancia = int.Parse(input);

                        if (distancia == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Erro: A viagem precisa ter mais de 0 kms.");
                            Console.ResetColor ();
                        }
                        else
                        {
                            valida = false;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um número válido.");
                    }
                }

                while (valida)
                {
                    Console.Write("Digite o tempo em HRS: ");
                    string input2 = Console.ReadLine();

                    try
                    {
                        tempo = int.Parse(input2);

                        if (tempo == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Erro: A viagem precisa ter mais de 0 hrs.");
                        }
                        else
                        {
                            valida = false;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um número válido.");
                    }

                }

                double veloMedia = distancia / tempo;
                Console.WriteLine($"O resultado da divisão é: {veloMedia:F2}.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
