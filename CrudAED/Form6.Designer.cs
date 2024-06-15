namespace CrudAED
{
    partial class Form6
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
            lblID2 = new Label();
            lblUsuarioID = new Label();
            txtUserID2 = new TextBox();
            lblNome2 = new Label();
            lblSobrenome2 = new Label();
            lblSexo2 = new Label();
            lblCargo2 = new Label();
            lblData2 = new Label();
            lblTelefone2 = new Label();
            txtNome2 = new TextBox();
            txtSobrenome2 = new TextBox();
            txtSexo2 = new TextBox();
            txtCargo2 = new TextBox();
            txtTelefone2 = new MaskedTextBox();
            txtData2 = new MaskedTextBox();
            btnPesquisar = new Button();
            btnVoltarCrudAtualizar = new Button();
            btnLimparCrudPesquisar = new Button();
            SuspendLayout();
            // 
            // lblID2
            // 
            lblID2.AutoSize = true;
            lblID2.Location = new Point(27, 27);
            lblID2.Name = "lblID2";
            lblID2.Size = new Size(0, 20);
            lblID2.TabIndex = 0;
            // 
            // lblUsuarioID
            // 
            lblUsuarioID.AutoSize = true;
            lblUsuarioID.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblUsuarioID.Location = new Point(246, 28);
            lblUsuarioID.Name = "lblUsuarioID";
            lblUsuarioID.Size = new Size(236, 19);
            lblUsuarioID.TabIndex = 1;
            lblUsuarioID.Text = "Informe o código do usuário:";
            // 
            // txtUserID2
            // 
            txtUserID2.Location = new Point(488, 20);
            txtUserID2.Name = "txtUserID2";
            txtUserID2.Size = new Size(154, 27);
            txtUserID2.TabIndex = 2;
            // 
            // lblNome2
            // 
            lblNome2.AutoSize = true;
            lblNome2.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNome2.Location = new Point(27, 109);
            lblNome2.Name = "lblNome2";
            lblNome2.Size = new Size(60, 19);
            lblNome2.TabIndex = 3;
            lblNome2.Text = "Nome:";
            lblNome2.Visible = false;
            // 
            // lblSobrenome2
            // 
            lblSobrenome2.AutoSize = true;
            lblSobrenome2.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSobrenome2.Location = new Point(312, 108);
            lblSobrenome2.Name = "lblSobrenome2";
            lblSobrenome2.Size = new Size(105, 19);
            lblSobrenome2.TabIndex = 4;
            lblSobrenome2.Text = "Sobrenome:";
            lblSobrenome2.Visible = false;
            // 
            // lblSexo2
            // 
            lblSexo2.AutoSize = true;
            lblSexo2.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSexo2.Location = new Point(332, 172);
            lblSexo2.Name = "lblSexo2";
            lblSexo2.Size = new Size(54, 19);
            lblSexo2.TabIndex = 5;
            lblSexo2.Text = "Sexo:";
            lblSexo2.Visible = false;
            // 
            // lblCargo2
            // 
            lblCargo2.AutoSize = true;
            lblCargo2.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCargo2.Location = new Point(323, 259);
            lblCargo2.Name = "lblCargo2";
            lblCargo2.Size = new Size(63, 19);
            lblCargo2.TabIndex = 6;
            lblCargo2.Text = "Cargo:";
            lblCargo2.Visible = false;
            // 
            // lblData2
            // 
            lblData2.AutoSize = true;
            lblData2.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblData2.Location = new Point(27, 172);
            lblData2.Name = "lblData2";
            lblData2.Size = new Size(166, 19);
            lblData2.TabIndex = 7;
            lblData2.Text = "Data de Nascimento";
            lblData2.Visible = false;
            // 
            // lblTelefone2
            // 
            lblTelefone2.AutoSize = true;
            lblTelefone2.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTelefone2.Location = new Point(27, 259);
            lblTelefone2.Name = "lblTelefone2";
            lblTelefone2.Size = new Size(80, 19);
            lblTelefone2.TabIndex = 8;
            lblTelefone2.Text = "Telefone:";
            lblTelefone2.Visible = false;
            // 
            // txtNome2
            // 
            txtNome2.Location = new Point(93, 100);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(195, 27);
            txtNome2.TabIndex = 9;
            txtNome2.Visible = false;
            // 
            // txtSobrenome2
            // 
            txtSobrenome2.Location = new Point(423, 100);
            txtSobrenome2.Name = "txtSobrenome2";
            txtSobrenome2.Size = new Size(195, 27);
            txtSobrenome2.TabIndex = 10;
            txtSobrenome2.Visible = false;
            // 
            // txtSexo2
            // 
            txtSexo2.Location = new Point(392, 164);
            txtSexo2.Name = "txtSexo2";
            txtSexo2.Size = new Size(195, 27);
            txtSexo2.TabIndex = 11;
            txtSexo2.Visible = false;
            // 
            // txtCargo2
            // 
            txtCargo2.Location = new Point(392, 251);
            txtCargo2.Name = "txtCargo2";
            txtCargo2.Size = new Size(195, 27);
            txtCargo2.TabIndex = 12;
            txtCargo2.Visible = false;
            // 
            // txtTelefone2
            // 
            txtTelefone2.Location = new Point(113, 251);
            txtTelefone2.Mask = "(00) 00000-0000";
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.Size = new Size(140, 27);
            txtTelefone2.TabIndex = 13;
            txtTelefone2.Visible = false;
            // 
            // txtData2
            // 
            txtData2.Location = new Point(199, 164);
            txtData2.Mask = "00/00/0000";
            txtData2.Name = "txtData2";
            txtData2.Size = new Size(127, 27);
            txtData2.TabIndex = 14;
            txtData2.ValidatingType = typeof(DateTime);
            txtData2.Visible = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(113, 325);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(173, 43);
            btnPesquisar.TabIndex = 15;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnVoltarCrudAtualizar
            // 
            btnVoltarCrudAtualizar.Location = new Point(513, 325);
            btnVoltarCrudAtualizar.Name = "btnVoltarCrudAtualizar";
            btnVoltarCrudAtualizar.Size = new Size(105, 43);
            btnVoltarCrudAtualizar.TabIndex = 16;
            btnVoltarCrudAtualizar.Text = "Voltar";
            btnVoltarCrudAtualizar.UseVisualStyleBackColor = true;
            btnVoltarCrudAtualizar.Click += btnVoltarCrudAtualizar_Click;
            // 
            // btnLimparCrudPesquisar
            // 
            btnLimparCrudPesquisar.Location = new Point(309, 325);
            btnLimparCrudPesquisar.Name = "btnLimparCrudPesquisar";
            btnLimparCrudPesquisar.Size = new Size(173, 43);
            btnLimparCrudPesquisar.TabIndex = 17;
            btnLimparCrudPesquisar.Text = "Limpar";
            btnLimparCrudPesquisar.UseVisualStyleBackColor = true;
            btnLimparCrudPesquisar.Click += btnLimparCrudPesquisar_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 404);
            Controls.Add(btnLimparCrudPesquisar);
            Controls.Add(btnVoltarCrudAtualizar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtData2);
            Controls.Add(txtTelefone2);
            Controls.Add(txtCargo2);
            Controls.Add(txtSexo2);
            Controls.Add(txtSobrenome2);
            Controls.Add(txtNome2);
            Controls.Add(lblTelefone2);
            Controls.Add(lblData2);
            Controls.Add(lblCargo2);
            Controls.Add(lblSexo2);
            Controls.Add(lblSobrenome2);
            Controls.Add(lblNome2);
            Controls.Add(txtUserID2);
            Controls.Add(lblUsuarioID);
            Controls.Add(lblID2);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisar Pessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID2;
        private Label lblUsuarioID;
        private TextBox txtUserID2;
        private Label lblNome2;
        private Label lblSobrenome2;
        private Label lblSexo2;
        private Label lblCargo2;
        private Label lblData2;
        private Label lblTelefone2;
        private TextBox txtNome2;
        private TextBox txtSobrenome2;
        private TextBox txtSexo2;
        private TextBox txtCargo2;
        private MaskedTextBox txtTelefone2;
        private MaskedTextBox txtData2;
        private Button btnPesquisar;
        private Button btnVoltarCrudAtualizar;
        private Button btnLimparCrudPesquisar;
    }
}