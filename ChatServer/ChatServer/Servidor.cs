using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    // Este delegate é necessário para especificar os parâmetros que estamos passando com o nosso evento
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
    internal class Servidor
    {
        // Esta hash table armazena os usuários e as conexões (acessado/consultado por usuário)
        public static Hashtable htUsuarios = new Hashtable(30); // 30 usuários é o limite definido
        //Esta hash table armazena os usuários e as conex~oes (acessada/consultada por conexão)
        public static Hashtable htConexoes = new Hashtable(30); // 30 conexões é o limite definido
        //Armazena o endereço ip
        private IPAddress enderecoIP;
        private int portaHost;
        private TcpClient TcpCliente;

        // O evento e o seu argumento irá notificar o formulário quando um usuário se conecta, desconecta
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        // O construtor define o endereço IP para aquele retornado pela instanciação do objeto
        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIP = endereco;
            portaHost = porta;
        }

        // A thread que irá tratar o escutador de conexões
        private Thread thrListener;

        // O objeto TCP object que escuta as conexões
        private TcpListener tlsCliente;

        // Irá dizer ao laço while para mante o monitoramento das conexões
        bool ServRodando = false;


        // Inclui o usuário nas tabelas hash
        public static void IncluirUsuario(TcpClient tcpUsuario, string strUsername)
        {
            // Primeiro inclui o nome e conexão associadas para ambas as hash tables
            Servidor.htUsuarios.Add(strUsername, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUsername);

            // Informa a nova conexão para todos os usuários e pra o formulário do servidor
            EnviarMensagemAdmin(htConexoes[tcpUsuario] + " entrou...");
        }

        // Remove o usuário das tabelas (hash tables)
        public static void RemoveUsuario(TcpClient tcpUsuario)
        {
            // Se o usuário exitir
            if (htConexoes[tcpUsuario] != null)
            {
                //Primeiro mostra a informação e informa os outros usuários sobre a conexão
                EnviarMensagemAdmin(htConexoes[tcpUsuario] + " saiu...");

                // Remove o usuário da hash table
                Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario);
            }
        }

        // Este evento é chamado quando queremos disparar o evento StatusChanged
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;

            if (statusHandler != null)
            {
                // invoca o delegate
                statusHandler(null, e);
            }
        }

        // Envia mensagens administrativas

        public static void EnviarMensagemAdmin(string Mensagem)
        {
            StreamWriter swSenderSender;

            //Exibe primeiro na aplicação
            e = new StatusChangedEventArgs("Administrador: " + Mensagem);
            OnStatusChanged(e);

            // Cria um array de clientes TCPs do tamanho do número de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            // Copia os objetos TcpClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            // Percorre a lista de clientes TCP
            for (int i = 0; i < tcpClientes.Length; i++)
            {
                // Tenta enviar uma mensagem para cada cliente
                try
                {
                    // Se a mensagem estiver me branco ou a conexão for nula, ele sai
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    // Envia a mensagem para o usuário atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine("Administrador: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch
                {
                    // Se houver um problema ou o uusário não exista, o usuário é removido
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        //Envia mnesagem de um usuário para todos os outros
        public static void EnviaMensagem(string Origem, string Mensagem)
        {
            StreamWriter swSenderSender;

            // Primeiro exibe a mensagem na aplica~ção
            e = new StatusChangedEventArgs(Origem + " disse : " + Mensagem);
            OnStatusChanged(e);

            // Cria um array de clientes TCPs do tamanho do número de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            // Copia os objetos TcpCliente no Array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);
            // Percorre a lista de clientes TCP

            for (int i = 0; i < tcpClientes.Length;i++)
            {
                // Tenta enviar a mensagem para cada cliente
                try
                {
                    // Se a mensagem estiver me branco ou a conexão for nula, ele sai
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    // Envia a mensagem para o usuário atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine(Origem +  " disse: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch
                {
                    // Se houver um problema ou o uusário não exista, o usuário é removido
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        public void IniciaAtendimento()
        {
            try
            {
                // Pega o IP
                IPAddress ipLocal = enderecoIP;
                int portaLocal = portaHost;

                // Cria um objeto TCP listener usando o IP do servidor e portas definidas
                tlsCliente = new TcpListener(ipLocal, portaLocal);

                // Inicia o TCP listerner e escuta as conexões
                tlsCliente.Start();

                // O laço While verifica se o servidor está rodando antes de chegar as conexões
                ServRodando = true;

                // Inicia uma nova thread que hospeda o listener
                thrListener = new Thread(MantemAtendimento);
                thrListener.IsBackground = true;
                thrListener.Start();

            }
            catch (Exception ex)
            {
                
            }
        }

        private void MantemAtendimento()
        {
            // Enquanto o servidor estiver rodando
            while (ServRodando)
            {
                // Aceita uma conexão pendente
                TcpCliente = tlsCliente.AcceptTcpClient();
                // Cria uma nova instância da conexão
                Conexao newConnection = new Conexao(TcpCliente);
            }
        }
    }
}
