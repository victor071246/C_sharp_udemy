﻿namespace Parte016
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio1
            // 
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(59, 114);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(250, 40);
            this.radio1.TabIndex = 0;
            this.radio1.Text = "Vermelho";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(59, 160);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(250, 40);
            this.radio2.TabIndex = 1;
            this.radio2.Text = "Verde";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.Location = new System.Drawing.Point(59, 206);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(250, 40);
            this.radio3.TabIndex = 2;
            this.radio3.Text = "Azul";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.Button button1;
    }
}

