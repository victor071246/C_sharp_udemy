using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CriptoFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Criptografia.cspp = new CspParameters();
            Criptografia.EncrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Encrypt\";
            Criptografia.DecrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Decrypt\";
            Criptografia.SrcFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void botaoCriptografarArquivo_Click(object sender, EventArgs e)
        {
            if (Criptografia.rsa == null)
            {
                resultado.ForeColor = Color.Red;
                resultado.Text = "Chave não definida.";
            }
            else
            {
                // Mostra uma caixa de diálogo para escolher um arquivo para criptografar.
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.InitialDirectory = Criptografia.SrcFolder;
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialogo.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    // Passa o nome do arquivo com o caminho
                    string name = fInfo.FullName;
                    resultado.Text = Criptografia.EncryptFile(name);
                }
            }
        }

        private void botaoDescriptografarArquivo_Click(object sender, EventArgs e)
        {
            if (Criptografia.rsa == null)
            {
                resultado.ForeColor = Color.Red;
                resultado.Text = "Chave não definida.";
            }
            else
            {
                // Mostra uma caixa de diálogo para escolher um arquivo para criptografar.
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.InitialDirectory = Criptografia.SrcFolder;
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialogo.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    // Passa o nome do arquivo com o caminho
                    string name = fInfo.Name;
                    resultado.Text = Criptografia.DecryptFile(name);
                }
            }
        }

        private void botaoCriarChavesAsm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChave.Text))
            {
                resultado.ForeColor = Color.Red;
                resultado.Text = "Insira um valor para definir a chave pública.";
                txtChave.Focus();
                return;
            }

            Criptografia.keyName = txtChave.Text;
            resultado.ForeColor = Color.DarkBlue;
            resultado.Text = Criptografia.CreateAsmKeys();
        }

        private void botaoExportarChavePublica_Click(object sender, EventArgs e)
        {
            if (Criptografia.ExportPublicKey())
            {
                resultado.ForeColor = Color.DarkBlue;
                resultado.Text = "Chave pública exportada";
            }
            else
            {
                resultado.ForeColor = Color.Red;
                resultado.Text = "Chave pública não exportada";
            }
        }

        private void botaoImportarChavePublica_Click(object sender, EventArgs e)
        {
            Criptografia.keyName = "Pública";
            resultado.ForeColor = Color.DarkBlue;
            resultado.Text = Criptografia.ImportPublicKey();
        }

        private void botaoObterChavePrivada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChave.Text))
            {
                resultado.ForeColor = Color.Red;
                resultado.Text = "Insira um valor para definir a chave privada.";
                txtChave.Focus();
                return;
            }

            Criptografia.keyName = txtChave.Text;
            resultado.ForeColor = Color.DarkBlue;
            resultado.Text = Criptografia.GetPrivateKey();
        }
    }
}
