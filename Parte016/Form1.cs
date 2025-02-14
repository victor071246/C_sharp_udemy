using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Parte016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radio1.Checked = false;
            radio2.Checked = false;
            radio3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio1.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radio2.Checked)
            {
                this.BackColor = Color.Green;

            }
            else if (radio3.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1.Checked)
            {
                MessageBox.Show("Cor vermelha será aplicada");
            }
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2.Checked)
            {
                MessageBox.Show("Cor verde será aplicada");
            }

        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio3.Checked)
            {
                MessageBox.Show("Cor azul será aplicada");
            }
        }
    }
}
