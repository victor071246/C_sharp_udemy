﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

                socket.Connect(endPoint);

                Console.WriteLine("Conectado com exito...");
                Console.WriteLine("Insira a informação para enviar: ");
                Console.WriteLine();

                string info = Console.ReadLine();

                byte[] infoEnviar = Encoding.UTF8.GetBytes(info);

                socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None);
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível conectar-se ao servidor");
            }

            socket.Close();
            Console.Write("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
