using System;

namespace Aula_31_07_2018
{
    class Program
    {
        public static int Id1 { get; set; }

        public static int Id2 { get; set; }

        public static String Ope { get; set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Lucas viadão");

            Console.WriteLine("Digite o primeiro número: ");

            Id1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");

            Id2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha entre as 4 operações (+, -, /, *): ");

            Ope = Console.ReadLine();

            if (Ope == "+") {

                Console.WriteLine("Resultado: " + (Id1 + Id2));

            }
            else if (Ope == "-") {

                Console.WriteLine("Resultado: " + (Id1 - Id2));

            }
            else if (Ope == "/") {

                Console.WriteLine("Resultado: " + (Id1 / Id2));

            }
            else if (Ope == "*") {

                Console.WriteLine("Resultado: " + (Id1 * Id2));

            }

            Console.ReadKey();
        }
    }
}
