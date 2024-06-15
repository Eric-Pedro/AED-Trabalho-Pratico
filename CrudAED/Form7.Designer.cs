namespace CrudAED
{
    partial class Form7
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
            lblNome3 = new Label();
            txtNome3 = new TextBox();
            lblSobrenome3 = new Label();
            txtSobrenome3 = new TextBox();
            lblUsuarioID = new Label();
            txtUserID3 = new TextBox();
            lblData3 = new Label();
            txtData3 = new MaskedTextBox();
            lblSexo3 = new Label();
            txtSexo3 = new TextBox();
            lblTelefone3 = new Label();
            txtTelefone3 = new MaskedTextBox();
            lblCargo3 = new Label();
            txtCargo3 = new TextBox();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimparCrudAtualizar = new Button();
            btnVoltarCrudExcluir = new Button();
            lblID3 = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblNome3
            // 
            lblNome3.AutoSize = true;
            lblNome3.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNome3.Location = new Point(12, 107);
            lblNome3.Name = "lblNome3";
            lblNome3.Size = new Size(60, 19);
            lblNome3.TabIndex = 4;
            lblNome3.Text = "Nome:";
            lblNome3.Visible = false;
            // 
            // txtNome3
            // 
            txtNome3.Location = new Point(78, 99);
            txtNome3.Name = "txtNome3";
            txtNome3.Size = new Size(195, 27);
            txtNome3.TabIndex = 10;
            txtNome3.Visible = false;
            // 
            // lblSobrenome3
            // 
            lblSobrenome3.AutoSize = true;
            lblSobrenome3.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSobrenome3.Location = new Point(311, 107);
            lblSobrenome3.Name = "lblSobrenome3";
            lblSobrenome3.Size = new Size(105, 19);
            lblSobrenome3.TabIndex = 11;
            lblSobrenome3.Text = "Sobrenome:";
            lblSobrenome3.Visible = false;
            lblSobrenome3.Click += lblSobrenome2_Click;
            // 
            // txtSobrenome3
            // 
            txtSobrenome3.Location = new Point(422, 103);
            txtSobrenome3.Name = "txtSobrenome3";
            txtSobrenome3.Size = new Size(195, 27);
            txtSobrenome3.TabIndex = 12;
            txtSobrenome3.Visible = false;
            // 
            // lblUsuarioID
            // 
            lblUsuarioID.AutoSize = true;
            lblUsuarioID.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblUsuarioID.Location = new Point(118, 39);
            lblUsuarioID.Name = "lblUsuarioID";
            lblUsuarioID.Size = new Size(236, 19);
            lblUsuarioID.TabIndex = 13;
            lblUsuarioID.Text = "Informe o código do usuário:";
            // 
            // txtUserID3
            // 
            txtUserID3.Location = new Point(360, 31);
            txtUserID3.Name = "txtUserID3";
            txtUserID3.Size = new Size(154, 27);
            txtUserID3.TabIndex = 14;
            // 
            // lblData3
            // 
            lblData3.AutoSize = true;
            lblData3.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblData3.Location = new Point(12, 167);
            lblData3.Name = "lblData3";
            lblData3.Size = new Size(166, 19);
            lblData3.TabIndex = 15;
            lblData3.Text = "Data de Nascimento";
            lblData3.Visible = false;
            // 
            // txtData3
            // 
            txtData3.Location = new Point(184, 159);
            txtData3.Mask = "00/00/0000";
            txtData3.Name = "txtData3";
            txtData3.Size = new Size(127, 27);
            txtData3.TabIndex = 16;
            txtData3.ValidatingType = typeof(DateTime);
            txtData3.Visible = false;
            // 
            // lblSexo3
            // 
            lblSexo3.AutoSize = true;
            lblSexo3.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSexo3.Location = new Point(362, 167);
            lblSexo3.Name = "lblSexo3";
            lblSexo3.Size = new Size(54, 19);
            lblSexo3.TabIndex = 17;
            lblSexo3.Text = "Sexo:";
            lblSexo3.Visible = false;
            // 
            // txtSexo3
            // 
            txtSexo3.Location = new Point(422, 159);
            txtSexo3.Name = "txtSexo3";
            txtSexo3.Size = new Size(195, 27);
            txtSexo3.TabIndex = 18;
            txtSexo3.Visible = false;
            // 
            // lblTelefone3
            // 
            lblTelefone3.AutoSize = true;
            lblTelefone3.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTelefone3.Location = new Point(12, 235);
            lblTelefone3.Name = "lblTelefone3";
            lblTelefone3.Size = new Size(80, 19);
            lblTelefone3.TabIndex = 19;
            lblTelefone3.Text = "Telefone:";
            lblTelefone3.Visible = false;
            // 
            // txtTelefone3
            // 
            txtTelefone3.Location = new Point(98, 227);
            txtTelefone3.Mask = "(00) 00000-0000";
            txtTelefone3.Name = "txtTelefone3";
            txtTelefone3.Size = new Size(140, 27);
            txtTelefone3.TabIndex = 20;
            txtTelefone3.Visible = false;
            // 
            // lblCargo3
            // 
            lblCargo3.AutoSize = true;
            lblCargo3.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCargo3.Location = new Point(291, 235);
            lblCargo3.Name = "lblCargo3";
            lblCargo3.Size = new Size(63, 19);
            lblCargo3.TabIndex = 21;
            lblCargo3.Text = "Cargo:";
            lblCargo3.Visible = false;
            // 
            // txtCargo3
            // 
            txtCargo3.Location = new Point(360, 227);
            txtCargo3.Name = "txtCargo3";
            txtCargo3.Size = new Size(195, 27);
            txtCargo3.TabIndex = 22;
            txtCargo3.Visible = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(78, 313);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(135, 43);
            btnAtualizar.TabIndex = 23;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(244, 313);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(135, 43);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimparCrudAtualizar
            // 
            btnLimparCrudAtualizar.Location = new Point(422, 313);
            btnLimparCrudAtualizar.Name = "btnLimparCrudAtualizar";
            btnLimparCrudAtualizar.Size = new Size(135, 43);
            btnLimparCrudAtualizar.TabIndex = 25;
            btnLimparCrudAtualizar.Text = "Limpar";
            btnLimparCrudAtualizar.UseVisualStyleBackColor = true;
            btnLimparCrudAtualizar.Click += btnLimparCrudAtualizar_Click;
            // 
            // btnVoltarCrudExcluir
            // 
            btnVoltarCrudExcluir.Location = new Point(527, 366);
            btnVoltarCrudExcluir.Name = "btnVoltarCrudExcluir";
            btnVoltarCrudExcluir.Size = new Size(109, 36);
            btnVoltarCrudExcluir.TabIndex = 26;
            btnVoltarCrudExcluir.Text = "Voltar";
            btnVoltarCrudExcluir.UseVisualStyleBackColor = true;
            btnVoltarCrudExcluir.Click += btnVoltarCrudExcluir_Click;
            // 
            // lblID3
            // 
            lblID3.AutoSize = true;
            lblID3.Location = new Point(12, 34);
            lblID3.Name = "lblID3";
            lblID3.Size = new Size(0, 20);
            lblID3.TabIndex = 27;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(520, 29);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(51, 31);
            btnOk.TabIndex = 28;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 414);
            Controls.Add(btnOk);
            Controls.Add(lblID3);
            Controls.Add(btnVoltarCrudExcluir);
            Controls.Add(btnLimparCrudAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(txtCargo3);
            Controls.Add(lblCargo3);
            Controls.Add(txtTelefone3);
            Controls.Add(lblTelefone3);
            Controls.Add(txtSexo3);
            Controls.Add(lblSexo3);
            Controls.Add(txtData3);
            Controls.Add(lblData3);
            Controls.Add(txtUserID3);
            Controls.Add(lblUsuarioID);
            Controls.Add(txtSobrenome3);
            Controls.Add(lblSobrenome3);
            Controls.Add(txtNome3);
            Controls.Add(lblNome3);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Pessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome3;
        private TextBox txtNome3;
        private Label lblSobrenome3;
        private TextBox txtSobrenome3;
        private Label lblUsuarioID;
        private TextBox txtUserID3;
        private Label lblData3;
        private MaskedTextBox txtData3;
        private Label lblSexo3;
        private TextBox txtSexo3;
        private Label lblTelefone3;
        private MaskedTextBox txtTelefone3;
        private Label lblCargo3;
        private TextBox txtCargo3;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimparCrudAtualizar;
        private Button btnVoltarCrudExcluir;
        private Label lblID3;
        private Button btnOk;
    }
}