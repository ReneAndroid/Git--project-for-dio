using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraModerna
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Digite o primeiro número a ser calculado");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número a ser calculado");
            double n2 = double.Parse(Console.ReadLine());

      

            int contador = 0;

            while (contador==0)
            {
                Console.WriteLine("Digite  se você que somar(+)| multiplicar(*)| subtrair(-) | dividir(/)|derivada do X¹ X², X³... (&)");
                String escolha = Console.ReadLine();
                double operador = 0;

                switch (escolha)
            {
                case "+":
                     operador = n1 + n2;
                    Console.WriteLine("O resultado é : " + (double)operador);
                       
                        break;
                case "*":
                        operador = n1 * n2;
                    Console.WriteLine("O resultado é : " + (double)operador);
                       
                        break;
                case "-":
                        operador = n1 - n2;
                    Console.WriteLine("O resultado é : " + (double)operador);
                        
                        break;
                case "/":
                        operador = n1 / n2;
                    Console.WriteLine("O resultado é : " + (double)operador);
                        
                    break;

                

                default:
                    Console.WriteLine("Tu digitou a opção errada jogador(a), escolha um simbolo aritimético aí");
                        
                        break;


            }

        }


            Console.ReadKey();








        }
    }
}
