using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores matemáticos
            //int num1 = 10;
            //int num2 = 2;
            ////int resultado = num1 + num2;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2); // Retorna o resto da divisão
            #endregion

            #region Precedência de Operadores
            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;

            //double res = (num1 + num2) * num3 /  (num3 / 3);
            #endregion

            #region Incremento e Decremento
            //int num1 = 10;

            //num1 = num1 + 1;
            //num1++;
            //++num1;
            //num1--;
            //--num1;

            //Console.WriteLine(num1++);
            //Console.WriteLine(num1);
            #endregion

            #region Operador de Concatenação
            //string nome = "Gabriel ";
            //string sobreNome = "Artigas";
            //string nomeCompleto = nome + sobreNome + " " + 1985;

            #endregion

            #region Operadores de Atribuição

            //int num1 = 13;

            //num1 = num1 + 20;
            //num1 += 20;
            //num1 -= 2;
            //num1 *= 3;
            //num1 /= 2;
            //num1 %= 2;
            //string nome = "Gabriel";
            //nome = "Artigas";

            #endregion

            #region Operadores de Igualdade

            //bool res = 100 == (50 * 2);
            //bool res2 = (200 / 2) != (100 + 100);

            //string nome = "Gabriel";
            //bool res3 = nome != "Lucas";

            #endregion

            #region Operadores Relacionais

            //bool res = 100 < 50 * 2;
            //bool res = 100 + 25 > 50 * 2;
            //bool res = 100 <= 50 * 2;
            //bool res = 75 >= 50 * 2;

            #endregion

            #region Operadores Lógicos

            bool res1 = 100 > 50;
            bool res2 = 60 == 50;

            bool final = res1 && res2;
            bool final2 = (100 >= 50) || (60 == 50);

            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
