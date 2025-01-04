namespace ProjetoAplicacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSenha = new Button();
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnSenha
            // 
            btnSenha.Location = new Point(142, 327);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(239, 70);
            btnSenha.TabIndex = 0;
            btnSenha.Text = "Esqueci a senha";
            btnSenha.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(460, 327);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(239, 70);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 87);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 121);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(281, 121);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(295, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(btnSenha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSenha;
        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
    }
}
