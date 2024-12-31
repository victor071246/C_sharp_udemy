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
    }
}
