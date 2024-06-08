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
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adicionarPessoasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            lblTitulo = new Label();
            lblSubTitulo = new Label();
            btnLista = new Button();
            btnCrud = new Button();
            btnBancoDados = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1165, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, adicionarPessoasToolStripMenuItem, sairToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(73, 24);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(210, 26);
            toolStripMenuItem1.Text = "Adicionar Lista";
            // 
            // adicionarPessoasToolStripMenuItem
            // 
            adicionarPessoasToolStripMenuItem.Name = "adicionarPessoasToolStripMenuItem";
            adicionarPessoasToolStripMenuItem.Size = new Size(210, 26);
            adicionarPessoasToolStripMenuItem.Text = "Adicionar Pessoas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(210, 26);
            sairToolStripMenuItem.Text = "Sair";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 741);
            Controls.Add(btnBancoDados);
            Controls.Add(btnCrud);
            Controls.Add(btnLista);
            Controls.Add(lblSubTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem adicionarPessoasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label lblTitulo;
        private Label lblSubTitulo;
        private Button btnLista;
        private Button btnCrud;
        private Button btnBancoDados;
    }
}
