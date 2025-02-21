using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Sql server CE
using System.Data.SqlServerCe;

//SQLite
using System.Data.SQLite;

// MySQL
using MySql.Data.MySqlClient;

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
            #region SQL Server CE
            //string baseDeDados = Application.StartupPath + @"\db\DSQLServer.sdf"; // retorna a pasta do executável, não incluindo seu nome
            //string strConexao = @"DataSource = " + baseDeDados + "; Password = '1234'";
            //SqlCeEngine db = new SqlCeEngine(strConexao);

            //if (!File.Exists(baseDeDados))
            //{
            //    db.CreateDatabase();
            //}

            //db.Dispose();

            //SqlCeConnection conexao = new SqlCeConnection(strConexao);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "O servidor Sql Server CE foi conectado com sucesso";
            //}
            //catch (Exception excecao)
            //{
            //    labelResultado.Text = "Erro ao estabelecer conexão com o Sql Server CE \n" + excecao;
            //}finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite

            //string baseDeDados = Application.StartupPath + @"\db\DBSQLite.db"; // retorna a pasta do executável, não incluindo seu nome
            //string strConexao = @"DataSource = " + baseDeDados + "; Version = 3";



            //if (!File.Exists(baseDeDados))
            //{
            //    SQLiteConnection.CreateFile(baseDeDados);
            //}

            //SQLiteConnection conexao = new SQLiteConnection(strConexao);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado SQLite";
            //}
            //catch (Exception excecao)
            //{
            //    labelResultado.Text = "Erro ao conectar com SQLite \n" + excecao;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql
            string strConnection = "server=127.0.0.1; User Id=root;password=root";
            //string strConnection2 = "server=127.0.0.1; User Id=root; database=curso_c#_db;password=root";

            MySqlConnection conexao = new MySqlConnection(strConnection);
            //conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();
                labelResultado.Text = "Banco de dados conectado";

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";

                comando.ExecuteNonQuery();

                labelResultado.Text = "Base de dados criada com sucesso";
                comando.Dispose();
            }
            catch (Exception ex) 
            {
                labelResultado.Text = "Erro ao conectar no banco de dados MySql " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }

            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            #region SQLServerCE
            //string baseDeDados = Application.StartupPath + @"\db\DSQLServer.sdf";
            //string strConexao = @"DataSource = " + baseDeDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConexao);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))"; //VARCHAR é NVARCHAR
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela pessoas criada com sucesso no SqlServerCE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //} finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite

            //string baseDeDados = Application.StartupPath + @"\db\DBSQLite.db"; // retorna a pasta do executável, não incluindo seu nome
            //string strConexao = @"DataSource = " + baseDeDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConexao);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))"; //VARCHAR é NVARCHAR
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela pessoas criada com sucesso no SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql

            string strConnection = "server=127.0.0.1; User Id=root; database=curso_db;password=root";
            MySqlConnection conexao = new MySqlConnection(strConnection);


            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))"; //VARCHAR é VARCHAR mesmo
                comando.ExecuteNonQuery();

                labelResultado.Text = "Tabela pessoas criada com sucesso no MySql";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SQLServerCE
            //string baseDeDados = Application.StartupPath + @"\db\DSQLServer.sdf";
            //string strConexao = @"DataSource = " + baseDeDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConexao);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES " +
            //        "("+ id + ", '" + nome + "', ' " + email + "')"; //VARCHAR é NVARCHAR
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido Sql Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDeDados = Application.StartupPath + @"\db\DBSQLite.db"; // retorna a pasta do executável, não incluindo seu nome
            //string strConexao = @"DataSource = " + baseDeDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConexao);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES " +
            //        "(" + id + ", '" + nome + "', ' " + email + "')"; //VARCHAR é NVARCHAR
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql
            string strConnection = "server=127.0.0.1; User Id=root; database=curso_db;password=root";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES " +
                    "(" + id + ", '" + nome + "', ' " + email + "')"; //VARCHAR é NVARCHAR
                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro inserido SQLite";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
