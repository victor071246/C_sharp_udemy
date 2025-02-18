using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string path = @"C:\Users\victo\OneDrive\Área de Trabalho\programação\c_sharp_udemy\Arquivo\";
            bool res = Directory.Exists(path + "victor");
            //lista.Items.Add(res);

            //if (!res)
            //{
            //    Directory.CreateDirectory(path + "victor");
            //}

            //if (res)
            //{
            //    Directory.Delete(path + "victor");
            //}

            //if (res)
            //{
            //    Directory.Move(path + "victor", path + @"destino\victorCopia");
            //}

            //string[] dirs = Directory.GetDirectories(path);

            //foreach (string dir in dirs)
            //{
            //    lista.Items.Add(dir);
            //}

            //string[] files = Directory.GetFiles(path);

            //foreach (string file in files)
            //{
            //    lista.Items.Add(file);
            //}

            //string root = Directory.GetDirectoryRoot(path);
            //lista.Items.Add(root);

            //string[] drives = Directory.GetLogicalDrives();
            //lista.Items.AddRange(drives);

            //DirectoryInfo info = Directory.GetParent(path);
            //lista.Items.Add(info.FullName);

            string dir = Directory.GetCurrentDirectory();
            lista.Items.Add(dir);
        }
    }
}

//Directory.Exists();
//Directory.CreateDirecotry();
//Directory.Delete();
//Directory.Move();
//Directory.GetDirectories();
//Directory.GetFiles();
//Directory.GetDirectoryRoot();
//Directory.GetLogicalDrives();
//Directory.GetParent();
//Directory.GetCurrentDirectory();
