using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int largura;
        int altura;
        int num_linhas;
        int pagina;
        int num_paginas;
        
        public Form1()
        {
            InitializeComponent();
            pagina = 0;
            num_paginas = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                largura = printDocument1.DefaultPageSettings.Bounds.Width;
                altura = printDocument1.DefaultPageSettings.Bounds.Height;
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region Parte 1

            //string texto = "Trabalhando com impressão.";
            //Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Point pontoInicial = new Point(100, 50);
            //Point segundoPonto = new Point(100, 150);

            //// Desenhar o documento a ser impresso;
            //e.Graphics.DrawString(texto, letra, pincel, pontoInicial);
            //e.Graphics.DrawString("Victor Dadério", letra, Brushes.Red, segundoPonto);
            //e.Graphics.FillRectangle(Brushes.Green, new Rectangle(100, 200, 400, 100));
            #endregion

            #region Parte 2

            //#region texto
            //string texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            //#endregion

            ////Rectangle area = printDocument1.DefaultPageSettings.Bounds;
            //int x = printDocument1.DefaultPageSettings.Bounds.X;
            //int y = printDocument1.DefaultPageSettings.Bounds.Y;
            //int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            //int altura = printDocument1.DefaultPageSettings.Bounds.Height;


            //string titulo = "Título da Página";
            //Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            //Brush pincelTitulo = new SolidBrush(Color.Red);
            ////Point pontoInicial = new Point(100, 50);
            //Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
            //StringFormat formatacaoTitulo = new StringFormat();
            //formatacaoTitulo.Alignment = StringAlignment.Center;
            //formatacaoTitulo.LineAlignment = StringAlignment.Center;


            //Font letraTexto = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincelTexto = new SolidBrush(Color.Black);
            ////Point pontoInicial = new Point(100, 50);
            //Rectangle areaTexto = new Rectangle(x + 50, y + 100, largura - 100, 100);

            //// Desenhar o documento a ser impresso;
            ////e.Graphics.DrawString(texto, letra, pincel, pontoInicial);
            //e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo,  formatacaoTitulo);
            //e.Graphics.DrawString(texto, letraTexto, pincelTexto, areaTexto);

            ////e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTitulo);
            ////e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);
            #endregion

            #region Parte 3



            List<string> linhas = new List<string>()
            {
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "10. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "20. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "30. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "40. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "50. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "60. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "70. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "80. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "90. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
               "100. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
            };

            string titulo = "Título da Página";
            Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Red);
            //Point pontoInicial = new Point(100, 50);
            Rectangle areaTitulo = new Rectangle(x, y, largura - 100, 100);
            StringFormat formatacaoTitulo = new StringFormat();
            formatacaoTitulo.Alignment = StringAlignment.Center;
            formatacaoTitulo.LineAlignment = StringAlignment.Center;


            // Desenhar o documento a ser impresso;
            Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);



            while (num_linhas < linhas.Count)
            {
                if (num_linhas == 0)
                {
                    e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo, formatacaoTitulo);
                    y += 150;

                }
                e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x, y));
                y += 30;
                num_linhas++;

                if (y >= altura - 50)
                {
                    // Mudar de página
                    y = 50;
                    e.HasMorePages = true;
                    num_paginas++;
                    break;
                }

            }

            #endregion
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;
            printPreviewControl1.Document = printDocument1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                printPreviewControl1.StartPage = --pagina;
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (pagina < num_paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }
        }

        private void btnVisualizarPadrao_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
