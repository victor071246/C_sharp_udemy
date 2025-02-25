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
            //lista_numeros.Add(5);
            //lista_numeros.Add(7);
            //lista_numeros.Add(13);
            //lista_numeros.Add(42);
            //lista_numeros.Add(23);
            //lista_numeros.Add(87);
            //lista_numeros.Add(91);
            //lista_numeros.Add(76);
            //lista_numeros.Add(19);
            //lista_numeros.Add(29);
            //lista_numeros.Add(33);
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

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Operador de Filtragem, a clausula where

            string txt = txtConsulta.Text.Trim().ToLower();
            var res = from nome in lista_nomes where nome.ToLower().Contains(txt) select nome;

            foreach (var item in res)
            {
                lista.Items.Add(item);
            }
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            // Operador de ordenação
            lista.Items.Clear();
            string txt = txtConsulta.Text;

            //var res = from num in lista_numeros orderby num descending where num <= 10 select num;

            //var res = from nome in lista_nomes orderby nome select nome;

            //foreach (var n in res)
            //{
            //    lista.Items.Add(n);
            //}

            var res = from produto in lista_produtos orderby produto.Key select produto;

            foreach (KeyValuePair<string, double> item in res)
            {
                lista.Items.Add(item.Key + " R$ " + item.Value);
            }

        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            // Operadores de Agrupamento
            lista.Items.Clear();
            txtConsulta.Text = "";

            var res = from estado in lista_estados group estado by estado.Value;

            foreach (var grupo in res)
            {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo)
                {
                    lista.Items.Add($"      {estado.Key}");
                }
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();
            //int cont1 = lista_nomes.Count();
            //int cont2 = (from nome in lista_nomes where nome.StartsWith("G") select nome).Count();
            //lista.Items.Add(cont1 + " nomes.");
            //lista.Items.Add(cont2 + " nomes começados com a letra G");



            //double media1 = lista_numeros.Average();
            //lista.Items.Add(media1 + " média dos valores na lista números");

            //var res1 = from num in lista_numeros where num < 10 select num;
            //double media2 = res1.Average();
            //lista.Items.Add(media2 + " média dos valores menores que 10");

            //int soma1 = lista_numeros.Sum();
            //lista.Items.Add(soma1 + " é a soma dos valores");

            //var res2 = from num in lista_numeros where num < 10 select num;
            //int soma2 = res2.Sum();
            //lista.Items.Add(soma1 + " soma dos valores < 10.");

            //// Também aplicados nas consultas
            //lista.Items.Add(lista_numeros.Min() + " valor mínimo em lista de números");
            //lista.Items.Add(lista_numeros.Max() + " valor máximo em lista de números");

            // Também aplicado nas consultas
            //long contagem = lista_numeros.LongCount();

            string maiorNome = lista_nomes.Aggregate(lista_nomes[0], (maior, proximo) => 
            {
                if (maior.ToString().Length > proximo.Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }
            });

            lista.Items.Add(maiorNome + " é o maior nome da lista");
        }

        private void btnOperadoresDeElemento_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            int primeiro = lista_numeros.FirstOrDefault();
            lista.Items.Add(primeiro);
        }
    }
}
