using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condição Encadeada
            //int valor = 25;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição Verdadeira");
            //}
            //else if (valor > 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição Alternativa 1");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição Alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição Alternativa final");
            //}
            //Console.ReadKey();
            #endregion

            #region Condição Aninhada
            //int numero = 7;

            //if (numero > 5)
            //{
            //    Console.Write("O Número é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" E também é Par");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" E também  é Impar");
            //    }
            //    Console.ReadKey();
            #endregion

            #region Operador ternário
                int numero = 3;
               //string mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

                // condição ? true : false;

                //mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

                //if (numero > 5)
                //{
                //    mensagem = "Maior que 5";
                //}
                //else
                //{
                //    mensagem = "Menor que 5";
                //}

                Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5");

                #endregion

                Console.ReadKey();
            }
        }
    }

  
   

