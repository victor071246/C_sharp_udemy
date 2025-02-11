using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListViewItem item1 = new ListViewItem("Gabriel");
            item1.SubItems.Add("12 98545-1542");
            item1.SubItems.Add("gabriel@mail.com");

            lista.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Logan");
            item2.SubItems.Add("12 4524-35454");
            item2.SubItems.Add("logan@mail.com");

            lista.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Danny");
            item3.SubItems.Add("12 45645-8721");
            item3.SubItems.Add("danny@mail.com");
            
            lista.Items.Add(item3);

            ListViewItem item4 = new ListViewItem(new string[] {"Arthur", "13 3454-56454", "mail"});

            lista.Items.Add(item4);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.RemoveAt(0);
            //lista.Items.Clear();
            //lista.Items.Remove(lista.SelectedItems[0]);
            int qtdLinhasSelecionadas = lista.SelectedItems.Count;
            while (qtdLinhasSelecionadas > 0)
            {
                lista.Items.Remove(lista.SelectedItems[0]);
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lista.SelectedItems[0].Text);
        }
    }
}
