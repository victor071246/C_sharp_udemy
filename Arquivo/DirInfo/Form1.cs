﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"C:\Users\victo\OneDrive\Área de Trabalho\programação\c_sharp_udemy\Arquivo\");

            lista.Items.Add(info.FullName);
            lista.Items.Add(info.Parent);
            lista.Items.Add(info.Name);
            lista.Items.Add(info.CreationTime.ToString());
            lista.Items.Add(info.Exists);
            lista.Items.Add(info.Root);
            lista.Items.Add("------------------");

            DirectoryInfo[] dirs = info.GetDirectories();
            foreach (DirectoryInfo item in dirs)
            {
                lista.Items.Add(item.FullName);
            }
            lista.Items.Add("------------------");

            FileInfo[] files = info.GetFiles();
            foreach (FileInfo item in files)
            {
                lista.Items.Add(item.Name);
            }
        }
    }
}
