using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPLus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Criar uma folha em branco

            // Criar um desenhador

            // Utilizar o desenho ou imagem

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Folha em branco
            Bitmap folha = new Bitmap(picture.Width, picture.Height);

            // Criar desenhador
            Graphics desenhador = Graphics.FromImage(folha);

            // Desenhar na folha
            desenhador.Clear(Color.White);

            #region Linhas

            //Brush pincel1 = new SolidBrush(Color.Red);
            //Pen lapis1 = new Pen(pincel1, 5);
            //Point ponto1 = new Point(100, 200);
            //Point ponto2 = new Point(400, 100);

            //Pen lapis2 = new Pen(Color.Black, 10);
            //Point ponto3 = new Point(0, 0);
            //Point ponto4 = new Point(100, 200);

            ////desenhador.DrawLine(lapis1, ponto1, ponto2);
            ////desenhador.DrawLine(lapis2, ponto3, ponto4);

            //Point[] pontos =
            //{
            //    new Point(50, 50),
            //    new Point(250, 50),
            //    new Point(250, 150),
            //    new Point(100, 80),
            //    new Point(85, 140)
            //};

            //desenhador.DrawLines(lapis1, pontos); 

            #endregion

            #region Retângulos

            //Pen lapis1 = new Pen(Color.Black, 5);
            //Pen lapis2 = new Pen(Color.Blue, 10);

            //Rectangle rect1 = new Rectangle(100, 50, 300, 200);
            //Rectangle rect2 = new Rectangle(50, 85, 120, 40);
            //Rectangle rect3 = new Rectangle(120, 20, 145, 100);
            //Rectangle rect4 = new Rectangle(75, 200, 250, 100);

            ////desenhador.DrawRectangle(lapis1, rect1);
            ////desenhador.DrawRectangle(lapis2, 200, 100, 250, 250);

            //Rectangle[] retangulos = { rect1, rect2, rect3, rect4,
            //    new Rectangle(10, 30, 240, 85)};

            ////desenhador.DrawRectangles(lapis1, retangulos);

            //Brush pincel1 = new SolidBrush(Color.Red);
            //Brush pincel2 = new LinearGradientBrush(rect4, Color.Green, Color.Yellow, 45);

            ////desenhador.FillRectangle(pincel2, rect4);

            //desenhador.FillRectangles(pincel1, retangulos);
            #endregion

            #region Elipses e Círculos

            //Pen lapis1 = new Pen(Color.Black, 5);
            //Rectangle rect1 = new Rectangle(150, 50, 200, 150);

            //desenhador.DrawRectangle(lapis1, rect1);
            //desenhador.DrawEllipse(lapis1, rect1);

            //Brush pincel = new SolidBrush(Color.Yellow);
            //desenhador.FillEllipse(Brushes.Gray, rect1);

            #endregion

            #region Polígonos

            //Pen lapis1 = new Pen(Color.Black, 5);

            //Point[] pontos =
            //{
            //    new Point(100, 100),
            //    new Point(300, 200),
            //    new Point(250, 250),
            //    new Point(100, 200)
            //};

            ////desenhador.DrawPolygon(lapis1, pontos);
            //Brush pincel = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Orange, Color.Yellow, 45);
            //desenhador.FillPolygon(pincel, pontos);
            ////desenhador.FillPolygon(Brushes.Blue, pontos);

            #endregion

            #region Curvas

            //Pen lapis = new Pen(Color.Black, 5);

            //Point[] pontos =
            //{
            //    new Point(100, 50),
            //    new Point(200, 150),
            //    new Point(300, 100),
            //    new Point(500, 250),
            //    new Point(300, 300),
            //};

            ////desenhador.DrawCurve(lapis, pontos, 1.5f);
            ////desenhador.DrawClosedCurve(lapis, pontos, 1.5f, FillMode.Alternate);
            ////desenhador.DrawClosedCurve(lapis, pontos, 1.5f, FillMode.Winding);
            //desenhador.FillClosedCurve(Brushes.Red, pontos, FillMode.Winding, 1.5f);

            #endregion

            #region Arcos

            //Pen caneta = new Pen(Color.Black, 5);
            //Rectangle retangulo = new Rectangle(100, 50, 400, 300);

            ////desenhador.DrawRectangle(caneta, retangulo);
            //desenhador.DrawArc(caneta, retangulo, 45f, 250f);

            #endregion

            #region Bazier

            //Pen lapis = new Pen(Color.Black, 5);
            //Point p1 = new Point(50, 300);
            //Point p2 = new Point(200, 400);
            //Point p3 = new Point(300, 10);
            //Point p4 = new Point(500, 100);

            ////desenhador.DrawBezier(lapis, p1, p2, p3, p4);

            //Point[] pontos =
            //{
            //new Point(50, 300), // Início
            //new Point(200, 350),
            //new Point(300, 100),
            //new Point(400, 150), // Meio
            //new Point(500, 400),
            //new Point(550, 10),
            //new Point(600, 100) // Fim
            //};

            //desenhador.DrawBeziers(lapis, pontos);

            #endregion

            #region Pie

            //Pen lapis = new Pen(Color.Black, 5);
            //Rectangle retangulo = new Rectangle(50, 50, 300, 300);

            ////desenhador.DrawPie(lapis, retangulo, 270, 90);

            //desenhador.FillPie(Brushes.Red, retangulo, 270, 300);
            ////desenhador.DrawRectangle(lapis, retangulo);

            #endregion

            #region Path

            //Pen lapis = new Pen(Color.Black);
            //GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
            ////GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate);

            //graphicsPath.AddEllipse(new RectangleF(10, 10, 100, 150));
            //graphicsPath.AddEllipse(new RectangleF(50, 10, 100, 150));
            //graphicsPath.AddRectangle(new RectangleF(120, 50, 150, 100));

            ////desenhador.DrawPath(lapis, graphicsPath);
            //desenhador.FillPath(Brushes.Red, graphicsPath);

            #endregion

            #region Strings

            //string texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            //string texto = "Victor Dadério";
            //Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            ////Brush pincel = new LinearGradientBrush(new Rectangle(0,0, 400, 400), Color.ForestGreen, Color.DarkBlue, 45);
            //Point ponto = new Point(10, 20);
            //Rectangle retangulo = new Rectangle(10, 20, 500, 350);
            //StringFormat alinhamento = new StringFormat();

            ////desenhador.DrawRectangle(new Pen(Color.Red), retangulo);
            ////desenhador.DrawString(texto, letra, pincel, ponto);
            //alinhamento.Alignment = StringAlignment.Center;
            //alinhamento.LineAlignment = StringAlignment.Center;
            ////alinhamento.FormatFlags = StringFormatFlags.NoWrap;
            ////alinhamento.FormatFlags = StringFormatFlags.DirectionVertical;

            //desenhador.DrawString("Título da página", letra, Brushes.Red, retangulo, alinhamento);
            ////desenhador.DrawString(texto, letra, pincel, retangulo, alinhamento);
            //desenhador.DrawString(texto, letra, pincel, new Rectangle(10, 80, 550, 100));

            #endregion

            #region Imagens

            Image imgOrigem1 = Image.FromFile(Application.StartupPath + @"\imagens\10.jpg");
            Rectangle origem1 = new Rectangle(0, 0, imgOrigem1.Width, imgOrigem1.Height);
            Rectangle destino1 = new Rectangle(0, 0, picture.Width, picture.Height);

            Image imgOrigem2 = Image.FromFile(Application.StartupPath + @"\imagens\11.jpg");
            Rectangle origem2 = new Rectangle(40, 25, 150, 200);
            Rectangle destino2 = new Rectangle(170, 170, 150, 200);

            desenhador.DrawImage(imgOrigem1, destino1, origem1, GraphicsUnit.Pixel);
            desenhador.DrawImage(imgOrigem2, destino2, origem2, GraphicsUnit.Pixel);

            #endregion

            // Utilizar num picture box
            picture.BackgroundImage = folha;

            // Salvar o desenho em um arquivo
            folha.Save(@"C:\Users\victo\OneDrive\Área de Trabalho\programação\c_sharp_udemy\GDIPLus\desenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
