using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Task Parte 1
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            //Task t2 = Task.Run(Tarefa);

            //Task.Run(Tarefa);

            //    Task.Factory.StartNew(Tarefa);

            //    Task.Run(() => 
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Console.WriteLine("Tarefa anônima");
            //        }
            //    });

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Principal");
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            Task[] tasks =
            {
                Task.Factory.StartNew(() => { }),
                Task.Factory.StartNew(() => { }),
                Task.Factory.StartNew(() => { }),

            };
            
        }
        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do task");
            }
        }
    }
}
