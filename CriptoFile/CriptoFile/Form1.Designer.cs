namespace CriptoFile
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
            this.botaoCriptografarArquivo = new System.Windows.Forms.Button();
            this.botaoExportarChavePublica = new System.Windows.Forms.Button();
            this.botaoImportarChavePublica = new System.Windows.Forms.Button();
            this.botaoDescriptografarArquivo = new System.Windows.Forms.Button();
            this.botaoObterChavePrivada = new System.Windows.Forms.Button();
            this.botaoCriarChavesAsm = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoCriptografarArquivo
            // 
            this.botaoCriptografarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriptografarArquivo.Location = new System.Drawing.Point(12, 329);
            this.botaoCriptografarArquivo.Name = "botaoCriptografarArquivo";
            this.botaoCriptografarArquivo.Size = new System.Drawing.Size(201, 49);
            this.botaoCriptografarArquivo.TabIndex = 0;
            this.botaoCriptografarArquivo.Text = "Criptografar arquivo";
            this.botaoCriptografarArquivo.UseVisualStyleBackColor = true;
            this.botaoCriptografarArquivo.Click += new System.EventHandler(this.botaoCriptografarArquivo_Click);
            // 
            // botaoExportarChavePublica
            // 
            this.botaoExportarChavePublica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExportarChavePublica.Location = new System.Drawing.Point(12, 389);
            this.botaoExportarChavePublica.Name = "botaoExportarChavePublica";
            this.botaoExportarChavePublica.Size = new System.Drawing.Size(201, 49);
            this.botaoExportarChavePublica.TabIndex = 1;
            this.botaoExportarChavePublica.Text = "Exportar chave pública";
            this.botaoExportarChavePublica.UseVisualStyleBackColor = true;
            this.botaoExportarChavePublica.Click += new System.EventHandler(this.botaoExportarChavePublica_Click);
            // 
            // botaoImportarChavePublica
            // 
            this.botaoImportarChavePublica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoImportarChavePublica.Location = new System.Drawing.Point(230, 389);
            this.botaoImportarChavePublica.Name = "botaoImportarChavePublica";
            this.botaoImportarChavePublica.Size = new System.Drawing.Size(201, 49);
            this.botaoImportarChavePublica.TabIndex = 3;
            this.botaoImportarChavePublica.Text = "Importar chave pública";
            this.botaoImportarChavePublica.UseVisualStyleBackColor = true;
            this.botaoImportarChavePublica.Click += new System.EventHandler(this.botaoImportarChavePublica_Click);
            // 
            // botaoDescriptografarArquivo
            // 
            this.botaoDescriptografarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDescriptografarArquivo.Location = new System.Drawing.Point(230, 329);
            this.botaoDescriptografarArquivo.Name = "botaoDescriptografarArquivo";
            this.botaoDescriptografarArquivo.Size = new System.Drawing.Size(201, 49);
            this.botaoDescriptografarArquivo.TabIndex = 2;
            this.botaoDescriptografarArquivo.Text = "Descriptografar arquivo";
            this.botaoDescriptografarArquivo.UseVisualStyleBackColor = true;
            this.botaoDescriptografarArquivo.Click += new System.EventHandler(this.botaoDescriptografarArquivo_Click);
            // 
            // botaoObterChavePrivada
            // 
            this.botaoObterChavePrivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoObterChavePrivada.Location = new System.Drawing.Point(449, 389);
            this.botaoObterChavePrivada.Name = "botaoObterChavePrivada";
            this.botaoObterChavePrivada.Size = new System.Drawing.Size(201, 49);
            this.botaoObterChavePrivada.TabIndex = 5;
            this.botaoObterChavePrivada.Text = "Obter chave privada";
            this.botaoObterChavePrivada.UseVisualStyleBackColor = true;
            this.botaoObterChavePrivada.Click += new System.EventHandler(this.botaoObterChavePrivada_Click);
            // 
            // botaoCriarChavesAsm
            // 
            this.botaoCriarChavesAsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriarChavesAsm.Location = new System.Drawing.Point(449, 329);
            this.botaoCriarChavesAsm.Name = "botaoCriarChavesAsm";
            this.botaoCriarChavesAsm.Size = new System.Drawing.Size(201, 49);
            this.botaoCriarChavesAsm.TabIndex = 4;
            this.botaoCriarChavesAsm.Text = "Criar chaves";
            this.botaoCriarChavesAsm.UseVisualStyleBackColor = true;
            this.botaoCriarChavesAsm.Click += new System.EventHandler(this.botaoCriarChavesAsm_Click);
            // 
            // txtChave
            // 
            this.txtChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChave.Location = new System.Drawing.Point(150, 245);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(363, 31);
            this.txtChave.TabIndex = 6;
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(9, 9);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(656, 166);
            this.resultado.TabIndex = 7;
            this.resultado.Text = "Chave não definida";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.botaoObterChavePrivada);
            this.Controls.Add(this.botaoCriarChavesAsm);
            this.Controls.Add(this.botaoImportarChavePublica);
            this.Controls.Add(this.botaoDescriptografarArquivo);
            this.Controls.Add(this.botaoExportarChavePublica);
            this.Controls.Add(this.botaoCriptografarArquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCriptografarArquivo;
        private System.Windows.Forms.Button botaoExportarChavePublica;
        private System.Windows.Forms.Button botaoImportarChavePublica;
        private System.Windows.Forms.Button botaoDescriptografarArquivo;
        private System.Windows.Forms.Button botaoObterChavePrivada;
        private System.Windows.Forms.Button botaoCriarChavesAsm;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label resultado;
    }
}

