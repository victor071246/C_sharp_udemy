﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " | abaixo do peso |");
            }
            else if ((valorIMC >= 20 )&& (valorIMC <= 24))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " | peso normal |");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " | acima do peso |");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " | PERIGO! Gordo! |");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + " | PERIGO! Muito Gordo!");

            }

        }
    }
}
