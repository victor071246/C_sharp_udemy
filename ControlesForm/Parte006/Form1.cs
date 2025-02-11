﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkList.Items.Add("Carro", true);
            checkList.Items.Add("Moto"); // ele assume que é false
            checkList.Items.Add("Barco");
            checkList.Items.Add("Avião");

            int qtd = checkList.Items.Count;
            //MessageBox.Show("Quantidade de itens: " + qtd.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkList.Items.Clear();

            //checkList.Items.AddRange(new object[] { "Bike", "Mobilete", "Caminhão" });

            //bool res = checkList.Items.Contains("Moto");
            //if (res)
            //{
            //    MessageBox.Show("Moto foi checada e é verdadeiro");
            //}

            //checkList.Items.Remove("Moto");

            //checkList.Items.RemoveAt(2);

            //checkList.Items.Insert(1, "Cavalo");

            var items = checkList.CheckedItems;
            //var items = checkList.SelectedItems; // na seleção mesmo


            foreach (var item in items)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkList.SelectedItem.ToString();
        }
    }
}
