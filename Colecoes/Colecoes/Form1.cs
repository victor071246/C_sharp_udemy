using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //Array
            string[] nomes = new string[3];
            nomes[0] = "Gabriel";
            nomes[1] = "Arthur";
            nomes[2] = "Danny";

            // Lista Genérica
            List<string> nomes2 = new List<string>();

            nomes2.Add("Lucas");
            nomes2.Add("Beatriz");
            nomes2.AddRange(nomes);
            string item = nomes2[3];

            //if (nomes2.Remove("Lucas")) 
            //{
            //    MessageBox.Show("Lucas removido");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível remover");
            //};

            //if (nomes2.Contains("Danny"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém");
            //};

            //MessageBox.Show("Número de elementos: " + nomes2.Count());
            //nomes2.Sort();

            //MessageBox.Show("Gabriel está no índice: " + nomes2.IndexOf("Gabriel"));

            //nomes2.Insert(2, "João");

            //nomes2.RemoveAt(1);

            //nomes2.Clear();

            //nomes2.Add("Arthur");

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }

        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos;
            veiculos = new HashSet<string>()
            {
                "Carro",
                "Moto",
                "Avião",
                "Helicóptero",
                "Barco"
            };

            //MessageBox.Show(veiculos.ElementAt(2));


            //if (veiculos.Add("Cavalo"))
            //{
            //    MessageBox.Show("Item adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado");
            //}

            //if (veiculos.Contains("Carro"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém");
            //}

            //veiculos.Contains("");
            //veiculos.Count();
            //veiculos.Remove("");
            //veiculos.Clear();
            //MessageBox.Show(veiculos.First());
            MessageBox.Show(veiculos.Last());

            foreach (var item in veiculos)
            {
                lista.Items.Add(item);
            }

            veiculos.Add("");
        }

        private void btnDitcionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 150, "Danny" },
                { 200, "Arthur" },
                { 80, "Danny" }
            };

            alunos.Add(100, "Gabriel");

            //if (alunos.ContainsKey(810))
            //{
            //    MessageBox.Show("Contém a chave 80");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém a chave 80");
            //};

            if (alunos.ContainsValue("Jonas"))
            {
                MessageBox.Show("Contém o aluno Jonas");
            }
            else
            {
                MessageBox.Show("Não contém o aluno Jonas");
            };

            //alunos.Remove(80);
            //alunos.Clear();

            //KeyValuePair<int, string> primeiro = alunos.First();
            //MessageBox.Show("Primeiro " + primeiro.Key + " " + primeiro.Value);
            //MessageBox.Show("Primeiro " + alunos.Last().Key + " " + alunos.Last().Value);



            foreach (KeyValuePair <int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }

            //MessageBox.Show("Quantidade de alunos: " + alunos.Count);


            //alunos.Remove(1);
            //alunos.Clear();
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Danny" },
                { 10, "Gabriel" },
                { 17, "Arthur" },
            };

            alunos.Add(14, "Glória");
            //alunos.Reverse();

            //alunos.Remove(10);
            //alunos.RemoveAt(0);
            //alunos.Count();
            //alunos.ContainsKey(50);
            //alunos.ContainsValue("Danny")


            foreach (KeyValuePair<int, string> item in alunos.Reverse())
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>
            {
                { 4512, "Gabriel" },
                { 1542, "Arthur" },
                { 2145, "Danny" },
            };

            alunos.Add(5478, "Flávio");

            // alunos.Remove(120);
            // alunos.Count;
            // alunos.Clear();
            //alunos.ContainsKey(1542);
            //alunos.ContainsValue("Danny");
            MessageBox.Show(alunos.ElementAt(0).ToString());

            foreach (KeyValuePair<int, string> item in alunos.Reverse())
            {
                lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();


            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Gabriel", "Danny", "Arthur", "Flávio", "Beatriz"
            };

            if (!nomes.Add("Lucas"))
            {
                MessageBox.Show("o valor não pode ser repetido");
            };

            //nomes.Reverse();
            //nomes.Remove("Flávio");
            // nomes.Element(1)
            //MessageBox.Show(nomes.ElementAt(1));
            //MessageBox.Show(nomes.First());
            // nomes.Count;
            //nomes.Clear();



            foreach (string nome in nomes.Reverse())
            {
                lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Gabriel");
            fila.Enqueue("Danny");
            fila.Enqueue("Arthur");

            foreach (string item in fila)
            {
                lista.Items.Add(item);
            }

            MessageBox.Show(fila.Count().ToString());


            //MessageBox.Show("Primeiro da fila: " + fila.Peek());
            //MessageBox.Show(fila.Count.ToString());//apenas mostra o elemento objeto da fila

            //MessageBox.Show("Primeiro da fila: " + fila.Dequeue());
            //MessageBox.Show(fila.Count.ToString());//mostra e remove o elemento objeto da fila

            //MessageBox.Show("Primeiro da fila: " + fila.First());
            //MessageBox.Show(fila.Count.ToString());//retorna o primeiro elemento da fila

            //MessageBox.Show("Primeiro da fila: " + fila.Last());
            //MessageBox.Show(fila.Count.ToString());//retorna o último elemento da fila

            //fila.Clear();
            while (fila.Count > 0)
            {
                MessageBox.Show("Primeiro da fila: " + fila.Dequeue());
                MessageBox.Show(fila.Count.ToString());//mostra e remove o elemento objeto da fila
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }

        }
    }
}
