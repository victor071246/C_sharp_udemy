﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Gabriel";
            //c.Saldo = 100;

            //Operação de Depósito
            double valor = 100;
            c.Depositar(valor);

            //Operação de Saque
            double valor2 = 50;
            c.Sacar(valor2);

            //Resultado saldo atual
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Cliente: " + c.Saldo);

            Console.ReadKey();
        }
    }
}
