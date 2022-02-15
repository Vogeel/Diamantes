using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            volta:
            Console.WriteLine("Digite um numero (ímpar) para fazer o diamante, confomre maior o numero, mais sera o desenho");

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 != 0)
            {
                for (int i = 0; i < ((numero - 1) / 2); i++) // i = linha que vai ser atribuida
                {
                    for (int lugarlinha = 0; lugarlinha < numero; lugarlinha++) // lugar linha = lugar em que o x vai estar
                    {
                        if (lugarlinha >= ((numero - 1) / 2) - i && lugarlinha <= ((numero - 1) / 2) + i) // numero -1 / 2 = linha central, onde sempre vai ter x
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("x");
                            Console.ResetColor();
                        }

                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                for (int i = ((numero - 1) / 2); i < numero; i++)
                {
                    for (int lugarlinha = 0; lugarlinha < numero; lugarlinha++)
                    {
                        if (lugarlinha > ((numero - 1) / 2) - (numero - i) && lugarlinha < ((numero - 1) / 2) + (numero - i))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("x");
                            Console.ResetColor();
                        }

                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro, seu número é invalido para esta ocasião.");
                Console.ResetColor();
                goto volta;
            }
            Console.ReadLine();
        }
    }
}
