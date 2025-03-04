using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        // Trata o nome do usuário
        private string NomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        // Necessário para atualizar o formulário com mensagens da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        // Necessário para definir o formulário para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool Conectado;

        public Form1()
        {
            // Na saída da aplicação : desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Se não está conectado, aguarda a conexão
            if (!Conectado)
            {
                // Inicializa a conexão
                InicializarConexao();
            }
            else
            {
                // Se esta conectado, então desconecta
                FechaConexao("Desconectado a pedido do usuário.");
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se pressionou a tecla Enter
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }

        private void InicializarConexao()
        {
            try
            {

            }
            catch (Exception ex)
            {
                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.ForeColor = Color.Red;
                    labelStatus.Text = "Erro na conexão com o servidor : " + ex.Message;
                }));
            }
        }

        private void RecebeMensagens()
        {

        }

        private void AtualizaLog(string strMensagem)
        {

        }

        private void EnviaMensagem()
        {
            
        }

        private void FechaConexao(string Motivo)
        {

        }
        
        public void OnApplicationExit(object sender, EventArgs e)
        {

        }
    }
}
