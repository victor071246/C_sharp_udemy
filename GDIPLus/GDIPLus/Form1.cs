﻿using System;
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

            Pen lapis1 = new Pen(Color.Black, 5);

            Point[] pontos =
            {
                new Point(100, 100),
                new Point(300, 200),
                new Point(250, 250),
            };

            desenhador.DrawPolygon(lapis1, pontos);

            #endregion

            // Utilizar num picture box
            picture.BackgroundImage = folha;

            // Salvar o desenho em um arquivo
            folha.Save(@"C:\Users\victo\OneDrive\Área de Trabalho\programação\c_sharp_udemy\GDIPLus\desenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
