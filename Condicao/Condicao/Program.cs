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
            #region Condição Simples
            //int valor = 10;
            //if (valor >= 10)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    Console.WriteLine("B");
            //}

            #endregion

            #region Condição Encadeada
            //int valor = 15;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição retornou verdadeira");
            //}
            //else if (valor >= 5 && valor < 10) {
            //    Console.WriteLine("Condição alternativa 1");
            //} 
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternativa 1");

            //}
            //else
            //{
            //    Console.WriteLine("Condição alternativa final");
            //}
            #endregion

            #region Condição Aninhada
            //int numero = 10;

            //if (numero < 5) 
            //{
            //    Console.Write("O número é maior que 5");

            //    if (numero % 2 == 0) 
            //    {
            //        Console.WriteLine(" e também é par");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" mas não é par");
            //    }
            //}
            #endregion

            #region Operador Ternário

            int numero = 10;
            //string mensagem = "";

            // condição ? true : false;

            //mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";


            //if (numero > 5)
            //{
            //    mensagem = "maior que 5";
            //}
            //else
            //{
            //    mensagem = "menor que 5";
            //}

            //Console.WriteLine(numero > 5 ? "Maior que 5": "Menor que 5");
            #endregion

            Console.ReadKey();
        }
    }
}
