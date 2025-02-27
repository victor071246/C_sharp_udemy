namespace TransferirArquivosServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoIp = new System.Windows.Forms.TextBox();
            this.btnEstabelecerConexao = new System.Windows.Forms.Button();
            this.btnPararServidor = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.MaskedTextBox();
            this.txtPasta = new System.Windows.Forms.LinkLabel();
            this.listaLogs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor para Compartilhar Arquivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnderecoIp
            // 
            this.txtEnderecoIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoIp.Location = new System.Drawing.Point(145, 171);
            this.txtEnderecoIp.Name = "txtEnderecoIp";
            this.txtEnderecoIp.Size = new System.Drawing.Size(433, 29);
            this.txtEnderecoIp.TabIndex = 1;
            this.txtEnderecoIp.Text = "127.0.0.1";
            // 
            // btnEstabelecerConexao
            // 
            this.btnEstabelecerConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstabelecerConexao.Location = new System.Drawing.Point(145, 240);
            this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
            this.btnEstabelecerConexao.Size = new System.Drawing.Size(214, 42);
            this.btnEstabelecerConexao.TabIndex = 2;
            this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
            this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
            this.btnEstabelecerConexao.Click += new System.EventHandler(this.btnEstabelecerConexao_Click);
            // 
            // btnPararServidor
            // 
            this.btnPararServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararServidor.Location = new System.Drawing.Point(464, 240);
            this.btnPararServidor.Name = "btnPararServidor";
            this.btnPararServidor.Size = new System.Drawing.Size(214, 42);
            this.btnPararServidor.TabIndex = 3;
            this.btnPararServidor.Text = "Parar Servidor";
            this.btnPararServidor.UseVisualStyleBackColor = true;
            this.btnPararServidor.Click += new System.EventHandler(this.btnPararServidor_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(584, 171);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(94, 29);
            this.txtPorta.TabIndex = 5;
            this.txtPorta.Text = "1000";
            // 
            // txtPasta
            // 
            this.txtPasta.ActiveLinkColor = System.Drawing.Color.Snow;
            this.txtPasta.AutoSize = true;
            this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtPasta.LinkColor = System.Drawing.Color.Gray;
            this.txtPasta.Location = new System.Drawing.Point(64, 359);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(322, 25);
            this.txtPasta.TabIndex = 7;
            this.txtPasta.TabStop = true;
            this.txtPasta.Text = "Clique para selecionar a pasta...";
            this.txtPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPasta_LinkClicked);
            // 
            // listaLogs
            // 
            this.listaLogs.BackColor = System.Drawing.SystemColors.Window;
            this.listaLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLogs.FormattingEnabled = true;
            this.listaLogs.ItemHeight = 20;
            this.listaLogs.Location = new System.Drawing.Point(9, 402);
            this.listaLogs.Margin = new System.Windows.Forms.Padding(0);
            this.listaLogs.Name = "listaLogs";
            this.listaLogs.Size = new System.Drawing.Size(782, 164);
            this.listaLogs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.listaLogs);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.btnPararServidor);
            this.Controls.Add(this.btnEstabelecerConexao);
            this.Controls.Add(this.txtEnderecoIp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoIp;
        private System.Windows.Forms.Button btnEstabelecerConexao;
        private System.Windows.Forms.Button btnPararServidor;
        private System.Windows.Forms.MaskedTextBox txtPorta;
        private System.Windows.Forms.LinkLabel txtPasta;
        private System.Windows.Forms.ListBox listaLogs;
    }
}

