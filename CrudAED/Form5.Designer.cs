namespace CrudAED
{
    partial class Form5
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
            lblTextoEscolha = new Label();
            btnCrudCadastrar = new Button();
            btnCrudPesquisar = new Button();
            button3 = new Button();
            btnVoltarForm5 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTextoEscolha
            // 
            lblTextoEscolha.AutoSize = true;
            lblTextoEscolha.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTextoEscolha.Location = new Point(140, 95);
            lblTextoEscolha.Name = "lblTextoEscolha";
            lblTextoEscolha.Size = new Size(348, 24);
            lblTextoEscolha.TabIndex = 0;
            lblTextoEscolha.Text = "Selecione a opção que você deseja:";
            // 
            // btnCrudCadastrar
            // 
            btnCrudCadastrar.Font = new Font("Arial", 9F);
            btnCrudCadastrar.Location = new Point(191, 172);
            btnCrudCadastrar.Name = "btnCrudCadastrar";
            btnCrudCadastrar.Size = new Size(255, 70);
            btnCrudCadastrar.TabIndex = 1;
            btnCrudCadastrar.Text = "Cadastrar";
            btnCrudCadastrar.UseVisualStyleBackColor = true;
            btnCrudCadastrar.Click += btnCrudCadastrar_Click;
            // 
            // btnCrudPesquisar
            // 
            btnCrudPesquisar.Location = new Point(191, 276);
            btnCrudPesquisar.Name = "btnCrudPesquisar";
            btnCrudPesquisar.Size = new Size(255, 70);
            btnCrudPesquisar.TabIndex = 2;
            btnCrudPesquisar.Text = "Pesquisar";
            btnCrudPesquisar.UseVisualStyleBackColor = true;
            btnCrudPesquisar.Click += btnCrudPesquisar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(191, 472);
            button3.Name = "button3";
            button3.Size = new Size(255, 70);
            button3.TabIndex = 3;
            button3.Text = "Atualizar/Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnVoltarForm5
            // 
            btnVoltarForm5.Location = new Point(245, 558);
            btnVoltarForm5.Name = "btnVoltarForm5";
            btnVoltarForm5.Size = new Size(125, 49);
            btnVoltarForm5.TabIndex = 4;
            btnVoltarForm5.Text = "Voltar";
            btnVoltarForm5.UseVisualStyleBackColor = true;
            btnVoltarForm5.Click += btnVoltarForm5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(191, 378);
            button1.Name = "button1";
            button1.Size = new Size(255, 70);
            button1.TabIndex = 5;
            button1.Text = "Pesquisar por Cargo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 660);
            Controls.Add(button1);
            Controls.Add(btnVoltarForm5);
            Controls.Add(button3);
            Controls.Add(btnCrudPesquisar);
            Controls.Add(btnCrudCadastrar);
            Controls.Add(lblTextoEscolha);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoEscolha;
        private Button btnCrudCadastrar;
        private Button btnCrudPesquisar;
        private Button button3;
        private Button btnVoltarForm5;
        private Button button1;
    }
}