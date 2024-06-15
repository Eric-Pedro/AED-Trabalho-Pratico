namespace CrudAED
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
            lblTitulo = new Label();
            lblSubTitulo = new Label();
            btnLista = new Button();
            btnCrud = new Button();
            btnBancoDados = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F);
            lblTitulo.Location = new Point(403, 121);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(363, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Seja bem vindo ao cadastro de pessoas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.AutoSize = true;
            lblSubTitulo.Font = new Font("Arial", 10F);
            lblSubTitulo.Location = new Point(450, 188);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(259, 19);
            lblSubTitulo.TabIndex = 2;
            lblSubTitulo.Text = "Escolha a opção que você deseja:";
            // 
            // btnLista
            // 
            btnLista.Location = new Point(226, 307);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(177, 52);
            btnLista.TabIndex = 3;
            btnLista.Text = "Adicionar Lista";
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // btnCrud
            // 
            btnCrud.Location = new Point(501, 307);
            btnCrud.Name = "btnCrud";
            btnCrud.Size = new Size(177, 52);
            btnCrud.TabIndex = 4;
            btnCrud.Text = "Gerenciar Pessoas";
            btnCrud.UseVisualStyleBackColor = true;
            btnCrud.Click += btnCrud_Click;
            // 
            // btnBancoDados
            // 
            btnBancoDados.Location = new Point(754, 307);
            btnBancoDados.Name = "btnBancoDados";
            btnBancoDados.Size = new Size(177, 52);
            btnBancoDados.TabIndex = 5;
            btnBancoDados.Text = "Visualizar Pessoas";
            btnBancoDados.UseVisualStyleBackColor = true;
            btnBancoDados.Click += btnBancoDados_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(969, 545);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(142, 61);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 741);
            Controls.Add(btnSair);
            Controls.Add(btnBancoDados);
            Controls.Add(btnCrud);
            Controls.Add(btnLista);
            Controls.Add(lblSubTitulo);
            Controls.Add(lblTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblSubTitulo;
        private Button btnLista;
        private Button btnCrud;
        private Button btnBancoDados;
        private Button btnSair;
    }
}
