﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo while
            //int valor = 0;
            //while (valor < 10) 
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //}
            #endregion

            #region Ciclo do-while
            //int valor = 0;
            //do
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //} while (valor < 10);
            #endregion

            #region Ciclo for
            //for (int i = 0, j = 10; i < 10; i++, j--)
            //{
            //    Console.WriteLine("I = " + i + " | J = " + j);
            //}
            #endregion

            #region Ciclo forEach

            string[] nomes = { "Gabriel", "Danny", "Arthur", "João" };

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
