﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Méodos Simples
            //m.Cumprimentar();
            #endregion

            #region Métodos com parâmetros
            //m.Somar(10, 5);
            //m.Apresentar("Gabriel", 35);
            #endregion

            #region Passagem de parâmetros por valor e por referência
            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarValorRef(ref valor2);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Métodos com retorno de valores
            //string nomeCompleto = m.MontaNome("Gabriel", "Artigas");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPI();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);
            #endregion

            m.Cumprimentar();
            m.Cumprimentar("Gabriel");
            m.Cumprimentar("Gabriel", 18);

            bool res1 = m.Comparar(100, 50 * 2);
            bool res2 = m.Comparar("Gabriel", "gabriel");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            
            Console.ReadKey();
        }
    }
}
