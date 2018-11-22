namespace projTransportes
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblAssentosLivres = new System.Windows.Forms.Label();
            this.lblLotacaoTotal = new System.Windows.Forms.Label();
            this.lblPrevisaoSaida = new System.Windows.Forms.Label();
            this.listarVeiculos = new System.Windows.Forms.ListBox();
            this.txtLotacao = new System.Windows.Forms.TextBox();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btn_AddCarro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.Limpar2 = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.listarVisitantes = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btn_limpar);
            this.gb1.Controls.Add(this.lblValor);
            this.gb1.Controls.Add(this.lblAssentosLivres);
            this.gb1.Controls.Add(this.lblLotacaoTotal);
            this.gb1.Controls.Add(this.lblPrevisaoSaida);
            this.gb1.Controls.Add(this.listarVeiculos);
            this.gb1.Controls.Add(this.txtLotacao);
            this.gb1.Controls.Add(this.txtMotorista);
            this.gb1.Controls.Add(this.txtPlaca);
            this.gb1.Controls.Add(this.btn_AddCarro);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(13, 13);
            this.gb1.Margin = new System.Windows.Forms.Padding(4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4);
            this.gb1.Size = new System.Drawing.Size(981, 170);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Cadastrar Veículos";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(144, 124);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(605, 123);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 17);
            this.lblValor.TabIndex = 11;
            // 
            // lblAssentosLivres
            // 
            this.lblAssentosLivres.AutoSize = true;
            this.lblAssentosLivres.Location = new System.Drawing.Point(605, 91);
            this.lblAssentosLivres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssentosLivres.Name = "lblAssentosLivres";
            this.lblAssentosLivres.Size = new System.Drawing.Size(0, 17);
            this.lblAssentosLivres.TabIndex = 10;
            // 
            // lblLotacaoTotal
            // 
            this.lblLotacaoTotal.AutoSize = true;
            this.lblLotacaoTotal.Location = new System.Drawing.Point(605, 58);
            this.lblLotacaoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLotacaoTotal.Name = "lblLotacaoTotal";
            this.lblLotacaoTotal.Size = new System.Drawing.Size(0, 17);
            this.lblLotacaoTotal.TabIndex = 9;
            // 
            // lblPrevisaoSaida
            // 
            this.lblPrevisaoSaida.AutoSize = true;
            this.lblPrevisaoSaida.Location = new System.Drawing.Point(605, 25);
            this.lblPrevisaoSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevisaoSaida.Name = "lblPrevisaoSaida";
            this.lblPrevisaoSaida.Size = new System.Drawing.Size(0, 17);
            this.lblPrevisaoSaida.TabIndex = 8;
            // 
            // listarVeiculos
            // 
            this.listarVeiculos.FormattingEnabled = true;
            this.listarVeiculos.ItemHeight = 16;
            this.listarVeiculos.Location = new System.Drawing.Point(328, 21);
            this.listarVeiculos.Margin = new System.Windows.Forms.Padding(4);
            this.listarVeiculos.Name = "listarVeiculos";
            this.listarVeiculos.Size = new System.Drawing.Size(268, 132);
            this.listarVeiculos.TabIndex = 7;
            // 
            // txtLotacao
            // 
            this.txtLotacao.Location = new System.Drawing.Point(84, 86);
            this.txtLotacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtLotacao.Name = "txtLotacao";
            this.txtLotacao.Size = new System.Drawing.Size(235, 22);
            this.txtLotacao.TabIndex = 6;
            // 
            // txtMotorista
            // 
            this.txtMotorista.Location = new System.Drawing.Point(84, 53);
            this.txtMotorista.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Size = new System.Drawing.Size(235, 22);
            this.txtMotorista.TabIndex = 5;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(84, 21);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(235, 22);
            this.txtPlaca.TabIndex = 4;
            // 
            // btn_AddCarro
            // 
            this.btn_AddCarro.Location = new System.Drawing.Point(17, 126);
            this.btn_AddCarro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddCarro.Name = "btn_AddCarro";
            this.btn_AddCarro.Size = new System.Drawing.Size(100, 28);
            this.btn_AddCarro.TabIndex = 3;
            this.btn_AddCarro.Text = "&Adicionar";
            this.btn_AddCarro.UseVisualStyleBackColor = true;
            this.btn_AddCarro.Click += new System.EventHandler(this.btn_AddCarro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lotação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motorista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.Limpar2);
            this.gb2.Controls.Add(this.btnCheckIn);
            this.gb2.Controls.Add(this.listarVisitantes);
            this.gb2.Controls.Add(this.txtNome);
            this.gb2.Controls.Add(this.txtInscricao);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Controls.Add(this.label7);
            this.gb2.Location = new System.Drawing.Point(13, 191);
            this.gb2.Margin = new System.Windows.Forms.Padding(4);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(4);
            this.gb2.Size = new System.Drawing.Size(976, 210);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            this.gb2.Text = "Cadastrar Visitante";
            // 
            // Limpar2
            // 
            this.Limpar2.Location = new System.Drawing.Point(139, 103);
            this.Limpar2.Margin = new System.Windows.Forms.Padding(4);
            this.Limpar2.Name = "Limpar2";
            this.Limpar2.Size = new System.Drawing.Size(100, 28);
            this.Limpar2.TabIndex = 10;
            this.Limpar2.Text = "Limpar";
            this.Limpar2.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(12, 103);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 28);
            this.btnCheckIn.TabIndex = 9;
            this.btnCheckIn.Text = "&Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // listarVisitantes
            // 
            this.listarVisitantes.FormattingEnabled = true;
            this.listarVisitantes.ItemHeight = 16;
            this.listarVisitantes.Location = new System.Drawing.Point(323, 21);
            this.listarVisitantes.Margin = new System.Windows.Forms.Padding(4);
            this.listarVisitantes.Name = "listarVisitantes";
            this.listarVisitantes.Size = new System.Drawing.Size(268, 180);
            this.listarVisitantes.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 53);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 22);
            this.txtNome.TabIndex = 6;
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(123, 21);
            this.txtInscricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(151, 22);
            this.txtInscricao.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nº de Inscrição";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 374);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblAssentosLivres;
        private System.Windows.Forms.Label lblLotacaoTotal;
        private System.Windows.Forms.Label lblPrevisaoSaida;
        private System.Windows.Forms.ListBox listarVeiculos;
        private System.Windows.Forms.TextBox txtLotacao;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btn_AddCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button Limpar2;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ListBox listarVisitantes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

