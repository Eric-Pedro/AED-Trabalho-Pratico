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
            txtUserID = new TextBox();
            txtData = new MaskedTextBox();
            txtSobrenome = new TextBox();
            txtSexo = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtCargo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            label7 = new Label();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            lblId = new Label();
            SuspendLayout();
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(74, 67);
            txtUserID.MaxLength = 10;
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(152, 37);
            txtUserID.TabIndex = 0;
            // 
            // txtData
            // 
            txtData.Location = new Point(568, 126);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(104, 27);
            txtData.TabIndex = 3;
            txtData.TextAlign = HorizontalAlignment.Center;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(113, 122);
            txtSobrenome.Multiline = true;
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(255, 37);
            txtSobrenome.TabIndex = 2;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(56, 189);
            txtSexo.Multiline = true;
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(255, 37);
            txtSexo.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(506, 189);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(214, 27);
            txtTelefone.TabIndex = 5;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(74, 250);
            txtCargo.Multiline = true;
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(255, 37);
            txtCargo.TabIndex = 6;
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
            // txtNome
            // 
            txtNome.Location = new Point(298, 67);
            txtNome.MaxLength = 10;
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 37);
            txtNome.TabIndex = 1;
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
            btnCadastrar.Location = new Point(298, 316);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(162, 46);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(614, 373);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(106, 37);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 21;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 422);
            Controls.Add(lblId);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(label7);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCargo);
            Controls.Add(txtTelefone);
            Controls.Add(txtSexo);
            Controls.Add(txtSobrenome);
            Controls.Add(txtData);
            Controls.Add(txtUserID);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Pessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserID;
        private MaskedTextBox txtData;
        private TextBox txtSobrenome;
        private TextBox txtSexo;
        private MaskedTextBox txtTelefone;
        private TextBox txtCargo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNome;
        private Label label7;
        private Button btnCadastrar;
        private Button btnVoltar;
        private Label lblId;
    }
}