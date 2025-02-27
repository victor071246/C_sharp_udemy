﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForms
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive)
            {
                t.Start();
            }
        }

        private void Tarefa()
        {
            while (true)
            {
                //lblResultado.Text = DateTime.Now.Second.ToString();
                //DefinirValorPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString());
                lblResultado.Invoke(new Action(() => lblResultado.Text = DateTime.Now.Second.ToString()));
            }
            //DefinirValorPropriedade(lblResultado, "BackColor", Color.Red);


        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });
            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] propriedades = t.GetProperties();

                foreach (PropertyInfo p in propriedades)
                {
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }
    }
}
