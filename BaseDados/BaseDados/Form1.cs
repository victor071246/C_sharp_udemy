using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Sql server CE
using System.Data.SqlServerCe;
using System.IO;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string baseDeDados = Application.StartupPath + @"\db\DSQLServer.sdf"; // retorna a pasta do executável, não incluindo seu nome
            string strConexao = @"DataSource = " + baseDeDados + "; Password = '1234'";
            SqlCeEngine db = new SqlCeEngine(strConexao);

            if (!File.Exists(baseDeDados))
            {
                db.CreateDatabase();
            }

            db.Dispose();
            
            SqlCeConnection conexao = new SqlCeConnection(strConexao);
            //conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();
                labelResultado.Text = "O servidor Sql Server CE foi conectado com sucesso";
            }
            catch (Exception excecao)
            {
                labelResultado.Text = "Erro ao estabelecer conexão com o Sql Server CE \n" + excecao;
            }finally
            {
                conexao.Close();
            }
        }
    }
}
