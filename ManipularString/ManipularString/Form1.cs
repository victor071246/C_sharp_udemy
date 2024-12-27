using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            //string texto = "Este tipo de variável é alfanumerica.";

            //if (texto.Contains("var"))
            //{
            //    label1.Text = "Contém.";
            //}
            //else
            //{
            //    label1.Text = "Não Contém.";
            //}

            //int num = 5400;
            //bool res = true;

            //label1.Text = num.ToString();
            //label1.Text = res.ToString();
            #endregion

            #region ToUpper/ ToLower
            //string nome = "Gabriel";

            ////string nomeMaiusculo = nome.ToUpper();



            //label1.Text = nome.ToLower();
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Gabriel Artigas";

            ////int indice = nome.IndexOf('a', 5, 4); 
            //int indice = nome.LastIndexOf("Artigas");

            //label1.Text = "Índice: " + indice;
            #endregion

            #region Insert / Replace
            //string nome = "Gabriel Artigas";

            ////string nomeFinal = nome.Insert(7, " Lucas ");

            //string nomeFinal = nome.Replace("Artigas", "Silva");

            //label1.Text = nomeFinal;
            #endregion

            #region Length / Substring
            //string nome = "Gabriel Artigas";

            //int tamanho = nome.Length;

            //label1.Text = "O nome " + nome + " contém " + tamanho + " letras";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(nome.IndexOf(" "), nome.Length);

            //label1.Text = parte;
            #endregion

            #region Split

            //string nomes = "Gabriel_+_Danny Arthur Glória Bia Flávio";

            ////char[] separador = { ' ', '-', '_' };

            ////string[] resultado = nomes.Split(separador);

            //string[] separador = { " ", "_ + _" };

            //string[] resultado = nomes.Split(separador, StringSplitOptions.None);

            //foreach (string nome in resultado)
            //{
            //    label1.Text += nome + "\n";
            //}
            #endregion

            #region StartsWith / EndsWith
            //string nome = "Gabriel";

            ////bool res = nome.StartsWith("gab", StringComparison.OrdinalIgnoreCase);

            //bool res = nome.EndsWith("EL", StringComparison.OrdinalIgnoreCase);

            //if (res)
            //{
            //    label1.Text = "Positivo.";
            //}
            //else
            //{
            //    label1.Text = "Negativo.";
            //}
            #endregion

            #region Trim / TrimStart / TrimEnd
            //string mensagem = "    Ola Gabriel   ";

            //string mensagem = "    -_ 5  Ola Gabriel  --__    ";
            //char[] c = { ' ', '-', '_', '5' };
            //string nova = mensagem.Trim(c);
            //mensagem.TrimStart()

            //label1.Text = ">" + mensagem.TrimEnd() + "<";
            #endregion

            #region Equals / CompareTo
            //string nome = "Lucas";

            //string nome2 = "Gabriel";

            //if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString(); // retorna um inteiro de acordo com a ordem alfabética, -1 se vem depois e 1 se vem antes
            #endregion

            decimal valor = 19.95m;
            int temp = 32;

            //string s = String.Format("O valor do produto é {0:N1} e a temperatura é {1}", valor, temp);
            //Para formatar com R$ é só colocar ao invés de N, o valor C

            //string s = String.Format("Hoje é {0:d} e são {1:t}", DateTime.Now);

            //Formatação de data ^^^^^^^^^ d de Date e t de Time
            //D e T maiúsculo servem para colocar tudo completo

            //string s = $"O valor do produto é {valor:C4} e a temperatura é {temp}";

            string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";

            label1.Text = s;
        }
    }
}
