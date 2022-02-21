using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;           
        volta:
            DigitarNumero(numero);
          
            if (numero % 2 != 0)
            {
                ParteDeCimaELinhaAtribuida(numero);
                ParteDeBaixoELinhaAtribuida(numero);
            }

            else
            {
                MngErro ();
                goto volta;
            }
            Console.ReadLine();

            
        }

        private static int DigitarNumero(int numero)
        {
            numero = 0;

            Console.WriteLine("Digite um numero (ímpar) para fazer o diamante, confomre maior o numero, mais sera o desenho");

             numero = int.Parse(Console.ReadLine());

            return numero;
        }
      
        static void LugarDeXnaLinhaBaixo(int numero, int i)
        {
            for (int lugarlinha = 0; lugarlinha < numero; lugarlinha++)
            {
                XcentralBiaxo(numero, i, lugarlinha);
            }
            Console.WriteLine();
        }

        static void ParteDeBaixoELinhaAtribuida(int numero)
        {
            for (int i = ((numero - 1) / 2); i < numero; i++)
            {
                LugarDeXnaLinhaBaixo(numero, i);
            }
            Console.ReadKey();
        }

        private static void XcentralBiaxo(int numero, int i, int lugarlinha)
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

        private static void ParteDeCimaELinhaAtribuida(int numero)
        {
            for (int i = 0; i < ((numero - 1) / 2); i++) // i = linha que vai ser atribuida
            {
                LugarOndeXvaiEstarNaLinha(numero, i);
            }
        }

        static void LugarOndeXvaiEstarNaLinha(int numero, int i)
        {
            for (int lugarlinha = 0; lugarlinha < numero; lugarlinha++) // lugar linha = lugar em que o x vai estar
            {
                Xcentral(numero, i, lugarlinha);
            }
            Console.WriteLine();
        }

        private static void Xcentral(int numero, int i, int lugarlinha)
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

        private static void MngErro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro, seu número é invalido para esta ocasião.");
            Console.ResetColor();
        }

        
    }
}
