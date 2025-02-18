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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\Users\victo\OneDrive\Área de Trabalho\programação\c_sharp_udemy\Arquivo\";
            string arquivo = "teste.txt";

            //bool res = File.Exists(pasta + arquivo);
            //label1.Text = res.ToString();

            //File.Delete(pasta + arquivo);

            //if (!File.Exists(pasta + arquivo))
            //{
            //    File.Create(pasta + arquivo).Close();
            //    label1.Text = "Criado";
            //}
            //else
            //{
            //    label1.Text = "Arquivo já existe";
            //}

            //if (File.Exists(pasta + arquivo))
            //{
            //    File.Copy(pasta + arquivo, pasta + "copia", true);
            //    label1.Text = "Copiado";
            //}
            //else
            //{
            //    label1.Text = "O arquivo não existe.";
            //}

            //File.Move(pasta + arquivo, pasta + @"pasta_de_teste\");

            File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo", Encoding.Default);

            label1.Text = File.ReadAllText(pasta + arquivo, Encoding.Default);

            //label1.Text = File.GetCreationTime(pasta + arquivo).ToString();

            //File.SetCreationTime(pasta + arquivo, DateTime.Now);
        }
    }
}

// File.Exists()
// File.Delete()
// File.Create()
// File.Move()
// File.Copy()
// File.WriteAllText()
// File.ReadAllText()
