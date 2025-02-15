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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;


namespace Temporizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contador_Click(object sender, EventArgs e)
        {
            if (entrada.Visible)
            {
                entrada.Visible = false;
                listBox1.Visible = false;
            }
            else if(timer1.Enabled)
            {
                entrada.Visible = false;
                listBox1.Visible = false;
            }
            else
            {
                entrada.Visible = true;
                listBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool contador_zerado = (contador.Text == "00:00:00");
            #region Código antigo
            //string tempoProgramado = textBox1.Text;

            //if (timer1.Enabled)
            //{
            //    timer1.Stop();
            //    button1.Text = "Iniciar";
            //}
            //else
            //{
            //    if ((textBox1.Visible == true && tempoProgramado == "") && contador.Text == "00:00:00" && VerLetra(tempoProgramado))
            //    {
            //        textBox1.Text = "";
            //        MessageBox.Show("Insira um tempo válido no campo de texto e a escala de tempo que deseja utilizar");
            //    }
            //    else if ((tempoProgramado != "" || textBox1 != null) )
            //    {
            //        textBox1.Visible = false;
            //        listBox1.Visible = false;
            //        ConverterTempoParaTimer(tempoProgramado);
            //        textBox1.Text = "";
            //        timer1.Start();
            //        button1.Text = "Pausar";
            //    }
            //    else if ((contador.Text != null || contador.Text != "") && contador.Text != "00:00:00")
            //    {
            //        timer1.Start();
            //        button1.Text = "Pausar";
            //    }
            //    else
            //    {
            //        textBox1.Visible = false;
            //        listBox1.Visible = false;
            //        ConverterTempoParaTimer(tempoProgramado);
            //        textBox1.Text = "";
            //        timer1.Start();
            //        button1.Text = "Pausar";
            //    }
            //}
            #endregion
            if (contador_zerado && entrada.Text == "")
            {
                MessageBox.Show("Insira um tempo válido no campo de texto e a escala de tempo que deseja utilizar");
            }
            else if (!contador_zerado && entrada.Text == "" && entrada.Visible)
            {
                MessageBox.Show("Insira um tempo válido no campo de texto e a escala de tempo que deseja utilizar");
            }
            else if (VerLetra(entrada.Text))
            {
                MessageBox.Show("Insira um tempo válido por favor");
            }
            else if (!contador_zerado && timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Iniciar";
            }
            else if (!contador_zerado && !timer1.Enabled && !entrada.Visible)
            {
                timer1.Start();
                button1.Text = "Pausar";
            }
            else
            {
                ConverterTempoParaTimer(entrada.Text);
                entrada.Text = "";
                entrada.Visible = false;
                listBox1.Visible = false;
                timer1.Start();
                button1.Text = "Pausar";
            }
        }

        private bool VerLetra(string tempo) 
        {
            char[] caracteresIndevidos = {
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+',
            '{', '}', '[', ']', '|', '\\', ':', ';', '"', '\'', '<', '>', ',',
            '.', '?', '/', '~', '`', '\t', '\n', '\r', ' '  // Incluindo espaços e caracteres de controle
            };
            foreach (char caractere in caracteresIndevidos)
            {
                tempo.Contains(caractere);
                if(tempo.Contains(caractere) )
                {

                    return true;
                }
            }
            return false;
        }
        private void ConverterTempoParaTimer(string tempo_txt)
        {
            string selecionado = listBox1.SelectedItem.ToString();
            int tempo_int = int.Parse(tempo_txt);

            if (selecionado == "Horas")
            {
                TimeSpan timeSpan = TimeSpan.FromHours(tempo_int);
                contador.Text = timeSpan.ToString(@"hh\:mm\:ss");
            }
            else if (selecionado == "Minutos")
            {
                TimeSpan timeSpan = TimeSpan.FromMinutes(tempo_int);
                contador.Text = timeSpan.ToString(@"hh\:mm\:ss");
            }
            else
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(tempo_int);
                contador.Text = timeSpan.ToString(@"hh\:mm\:ss");
            }



        }

        private void DiminuirUmSegundo()
        {
            TimeSpan timeSpan = TimeSpan.Parse(contador.Text);
            double segundosTotais = timeSpan.TotalSeconds;
            segundosTotais -= 1;
            timeSpan = TimeSpan.FromSeconds(segundosTotais);
            contador.Text = timeSpan.ToString(@"hh\:mm\:ss");

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("Temporizador.Orbitron-Regular.ttf");
            byte[] fontData = new byte[fontStream.Length];
            fontStream.Read(fontData, 0, (int)fontStream.Length);
            fontStream.Close();

            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            privateFonts.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
            contador.Font = new Font(privateFonts.Families[0], 72, FontStyle.Regular);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiminuirUmSegundo();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 50;  // Raio da borda arredondada

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button1.Width - radius, button1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button1.Region = new Region(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
