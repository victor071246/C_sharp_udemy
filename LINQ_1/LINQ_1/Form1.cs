using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;


        public Form1()
        {
            InitializeComponent();


            #region Lista de Nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Victor");
            lista_nomes.Add("João");
            lista_nomes.Add("Moisés");
            lista_nomes.Add("Fábio");
            lista_nomes.Add("Joazir");
            lista_nomes.Add("Felipe");
            lista_nomes.Add("Pedro");
            lista_nomes.Add("Jhonatan");
            lista_nomes.Add("Pietro");
            lista_nomes.Add("Renan");
            lista_nomes.Add("Vinícius");
            lista_nomes.Add("Gustavo");
            lista_nomes.Add("Heitor");
            lista_nomes.Add("Emerson");
            lista_nomes.Add("Carlos");
            lista_nomes.Add("Paulo");
            #endregion

            #region Lista de Números
            lista_numeros = new List<int>();
            lista_numeros.Add(5);
            lista_numeros.Add(7);
            lista_numeros.Add(13);
            lista_numeros.Add(42);
            lista_numeros.Add(23);
            lista_numeros.Add(87);
            lista_numeros.Add(91);
            lista_numeros.Add(76);
            lista_numeros.Add(19);
            lista_numeros.Add(29);
            lista_numeros.Add(33);
            #endregion

            #region Lista de Produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Teclado USB", 49.95);
            lista_produtos.Add("Teclado PS2", 45.95);
            lista_produtos.Add("Teclado Gamer", 358.99);
            lista_produtos.Add("Mouse", 29.5);
            lista_produtos.Add("Monitor", 780.85);
            lista_produtos.Add("Memória 16 Gb", 700.00);
            lista_produtos.Add("Memória 8 Gb", 375.65);
            lista_produtos.Add("Processador", 1250);
            lista_produtos.Add("Placa Mãe", 623.75);
            lista_produtos.Add("Gabinete mATX", 150);
            lista_produtos.Add("Gabinete ATX", 190);
            #endregion

            #region Lista de Estados
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de Janeiro", "Brasil");
            lista_estados.Add("Nova York", "Estados Unidos");
            lista_estados.Add("São Paulo", "Brasil");
            lista_estados.Add("Porto", "Portugal");
            lista_estados.Add("Lisboa", "Portugal");
            lista_estados.Add("Bahia", "Brasil");
            lista_estados.Add("Washington", "Estados Unidos");
            lista_estados.Add("Algarve", "Portugal");
            #endregion
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Obter a fonte dos dados.
            // Criar a consulta.
            // Executar a consulta.

            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

            //foreach (int numero in res)
            //{
            //    lista.Items.Add(numero);
            //}

            //Método comum
            //foreach (int num in lista_numeros)
            //{
            //    if (num % 2 == 0)
            //    {
            //        lista.Items.Add(num);
            //    }
            //}

            string txt = txtConsulta.Text;
            IEnumerable<string> res2 = from nome in lista_nomes where nome.StartsWith(txt) select nome;

            lista.Items.AddRange(res2.ToArray());

            //foreach (string n in res2)
            //{
            //    lista.Items.Add(n);
            //}
        }
    }
}
