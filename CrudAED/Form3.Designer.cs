namespace CrudAED
{
    partial class Form3
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
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 67);
            textBox1.MaxLength = 10;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 37);
            textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(568, 126);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(104, 27);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 122);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 37);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 189);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 37);
            textBox3.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(506, 189);
            maskedTextBox2.Mask = "(00) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(214, 27);
            maskedTextBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(74, 250);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 37);
            textBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.Location = new Point(232, 67);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(2, 126);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 8;
            label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.Location = new Point(2, 189);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 9;
            label3.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.Location = new Point(390, 126);
            label4.Name = "label4";
            label4.Size = new Size(172, 19);
            label4.TabIndex = 10;
            label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(329, 189);
            label5.Name = "label5";
            label5.Size = new Size(171, 19);
            label5.TabIndex = 11;
            label5.Text = "Número de Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.Location = new Point(5, 250);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 12;
            label6.Text = "Cargo:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(298, 67);
            textBox5.MaxLength = 10;
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(241, 37);
            textBox5.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.Location = new Point(2, 67);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 14;
            label7.Text = "UserId:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 329);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(162, 46);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(192, 329);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(162, 46);
            btnPesquisar.TabIndex = 16;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(377, 329);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(162, 46);
            btnAtualizar.TabIndex = 17;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(558, 329);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(162, 46);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(435, 250);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(162, 46);
            btnLimpar.TabIndex = 19;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(594, 23);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(126, 46);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 422);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnVoltar;
    }
}