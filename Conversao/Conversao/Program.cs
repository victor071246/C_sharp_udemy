using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversão Implícita
            //byte num1 = 100; //8 bis de 0 a 255
            //ushort num2; // 16 bits, 0 a 65.535

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num3 = num1;
            //num2 = num1;

            //int numero = 'C';
            #endregion

            ushort num1 = 500;
            byte num2 = (byte)num1;

            float num3 = 2500.786f;
            int num4 = (int)num3;

            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
