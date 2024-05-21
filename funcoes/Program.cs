using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual forma geométrica você deseja medir a área? ");
            string figura = Console.ReadLine().ToUpper();

            switch (figura)
            {
                case "QUADRADO":
                    Quadrado();

                    break;

                case "LOSANGO":
                    Losango();

                    break;

                case "TRAPEZIO":
                    Trapezio();

                    break;

                case "RETÂNGULO":
                    Retangulo();
                    break;

            }


        }

        static void Quadrado()
        {
            Console.WriteLine("Qual é o valor do lado: ");
            double lado = double.Parse(Console.ReadLine());
            double area = lado * lado;
            Console.WriteLine("A área do quadrado é " + area);
        }

        static void Losango()
        {
            Console.WriteLine("Digite o valor da diagonal maior do losango que você deseja calcular: ");
            double Dm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da diagonal menor do losango que você deseja calcular: ");
            double dm = double.Parse(Console.ReadLine());
            double area = (Dm * dm) / 2;
            Console.WriteLine("A área do losango é de " + area);
        }

        static void Trapezio()
        {
            Console.WriteLine("Digite o valor da primeira base do trapézio que você deseja calcular: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da segunda base do trapézio que você deseja calcular: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do trapézio que você deseja calcular: ");
            double h = double.Parse(Console.ReadLine());
            double area = (b1 + b2) * h / 2;
            Console.WriteLine("A área do trapézio é de " + area);
        }

        static void Retangulo()
        {
            Console.WriteLine("Digite o valor da base do retângulo que você deseja calcular: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do retângulo que você deseja calcular: ");
            double h = double.Parse(Console.ReadLine());
            double area = b * h;
            Console.WriteLine("A área do retângulo é de " + area);
        }




    }
}
