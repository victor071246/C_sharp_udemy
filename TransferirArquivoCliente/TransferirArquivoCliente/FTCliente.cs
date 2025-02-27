using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    internal class FTCliente
    {
        static IPEndPoint ipEnd_Cliente;
        static Socket socket_cliente;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static Label LabelMensagem;

        public static void EnviarArquivo(string arquivo)
        {
            try
            {
                IPEndPoint ipEnd_Cliente = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
                socket_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta = arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);

                if(nomeArquivoByte.Length > 50000 * 1024)
                {
                    LabelMensagem.Invoke(new Action(() => 
                    { 
                        LabelMensagem.ForeColor = Color.Red;
                        LabelMensagem.Text = "O tamanho do arquivo é maior que 50Mb, tente um arquivo menor";
                    }));
                    return;
                }

                string caminhoCompleto = pasta + arquivo;
                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 0);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);
                socket_cliente.Connect(ipEnd_Cliente); 
                socket_cliente.Send(clientData, 0, clientData.Length, 0);
                socket_cliente.Close();

                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = $"Arquivo [{arquivo}] transferido";
                }));
            }
            catch (Exception ex) 
            {
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = $"Falha ao conectar, o servidor não está respondendo" + ex.Message;
                }));
            }
            finally
            {
                socket_cliente.Close();
            }
        }
    }
}
