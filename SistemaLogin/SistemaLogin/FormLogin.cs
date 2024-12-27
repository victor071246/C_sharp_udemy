﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                this.Close(); // O this não é necessário aqui porque ele entende que a classe principal, no caso o FormLogin é quem está sendo referenciado
            }
            else
            {
                MessageBox.Show("Acesso Negado!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
