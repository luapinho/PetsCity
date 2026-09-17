namespace PetsCity
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
            lblNomePet = new Label();
            lblPrecoServico = new Label();
            lblQuantidade = new Label();
            lblIdadeAnimal = new Label();
            lblNome = new Label();
            txtNomePet = new TextBox();
            txtPrecoServico = new TextBox();
            txtQuantidade = new TextBox();
            txtIdadeAnimal = new TextBox();
            lblDesconto = new Label();
            lblValorFinal = new Label();
            lblStatus = new Label();
            btnCalcular = new Button();
            lblParcela = new Label();
            SuspendLayout();
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Location = new Point(26, 25);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(57, 15);
            lblNomePet.TabIndex = 0;
            lblNomePet.Text = "NomePet";
            // 
            // lblPrecoServico
            // 
            lblPrecoServico.AutoSize = true;
            lblPrecoServico.Location = new Point(26, 65);
            lblPrecoServico.Name = "lblPrecoServico";
            lblPrecoServico.Size = new Size(78, 15);
            lblPrecoServico.TabIndex = 1;
            lblPrecoServico.Text = "Preco Serviço";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(26, 112);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblIdadeAnimal
            // 
            lblIdadeAnimal.AutoSize = true;
            lblIdadeAnimal.Location = new Point(26, 161);
            lblIdadeAnimal.Name = "lblIdadeAnimal";
            lblIdadeAnimal.Size = new Size(77, 15);
            lblIdadeAnimal.TabIndex = 3;
            lblIdadeAnimal.Text = "Idade Animal";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(279, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            lblNome.Click += label5_Click;
            // 
            // txtNomePet
            // 
            txtNomePet.Location = new Point(132, 17);
            txtNomePet.Name = "txtNomePet";
            txtNomePet.Size = new Size(100, 23);
            txtNomePet.TabIndex = 5;
            // 
            // txtPrecoServico
            // 
            txtPrecoServico.Location = new Point(132, 57);
            txtPrecoServico.Name = "txtPrecoServico";
            txtPrecoServico.Size = new Size(100, 23);
            txtPrecoServico.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(132, 109);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 8;
            txtQuantidade.TextChanged += textBox3_TextChanged;
            // 
            // txtIdadeAnimal
            // 
            txtIdadeAnimal.Location = new Point(132, 161);
            txtIdadeAnimal.Name = "txtIdadeAnimal";
            txtIdadeAnimal.Size = new Size(100, 23);
            txtIdadeAnimal.TabIndex = 9;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(279, 60);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(102, 15);
            lblDesconto.TabIndex = 10;
            lblDesconto.Text = "Valor de Desconto";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(279, 97);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(61, 15);
            lblValorFinal.TabIndex = 11;
            lblValorFinal.Text = "Valor Final";
            lblValorFinal.Click += lblValorFinal_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(279, 169);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(120, 396);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 27);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(279, 136);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(45, 15);
            lblParcela.TabIndex = 14;
            lblParcela.Text = "Parcela";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblParcela);
            Controls.Add(btnCalcular);
            Controls.Add(lblStatus);
            Controls.Add(lblValorFinal);
            Controls.Add(lblDesconto);
            Controls.Add(txtIdadeAnimal);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPrecoServico);
            Controls.Add(txtNomePet);
            Controls.Add(lblNome);
            Controls.Add(lblIdadeAnimal);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPrecoServico);
            Controls.Add(lblNomePet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePet;
        private Label lblPrecoServico;
        private Label lblQuantidade;
        private Label lblIdadeAnimal;
        private Label lblNome;
        private TextBox txtNomePet;
        private TextBox txtPrecoServico;
        private TextBox txtQuantidade;
        private TextBox txtIdadeAnimal;
        private Label lblDesconto;
        private Label lblValorFinal;
        private Label lblStatus;
        private Button btnCalcular;
        private Label lblParcela;
    }
}
