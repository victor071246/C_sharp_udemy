﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        // Atributos / Campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // Métodos simples

        public void Cumprimentar()
        {
            Console.WriteLine("Olá, eu sou " + nome + " " + sobrenome);
        }
    }
}
