namespace CrudAED
{
    partial class Form8
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
            dataGridView2 = new DataGridView();
            label1 = new Label();
            txtCargo2 = new TextBox();
            btnOkCargo = new Button();
            btnVoltarPesquisaCargo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 64);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1178, 602);
            dataGridView2.TabIndex = 0;
            dataGridView2.Visible = false;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold);
            label1.Location = new Point(758, 25);
            label1.Name = "label1";
            label1.Size = new Size(279, 18);
            label1.TabIndex = 1;
            label1.Text = "Informe o cargo que deseja pesquisar:";
            // 
            // txtCargo2
            // 
            txtCargo2.Location = new Point(1043, 16);
            txtCargo2.Name = "txtCargo2";
            txtCargo2.Size = new Size(107, 27);
            txtCargo2.TabIndex = 2;
            // 
            // btnOkCargo
            // 
            btnOkCargo.Location = new Point(1151, 12);
            btnOkCargo.Name = "btnOkCargo";
            btnOkCargo.Size = new Size(39, 31);
            btnOkCargo.TabIndex = 3;
            btnOkCargo.Text = "OK";
            btnOkCargo.UseVisualStyleBackColor = true;
            btnOkCargo.Click += btnOkCargo_Click;
            // 
            // btnVoltarPesquisaCargo
            // 
            btnVoltarPesquisaCargo.Location = new Point(12, 16);
            btnVoltarPesquisaCargo.Name = "btnVoltarPesquisaCargo";
            btnVoltarPesquisaCargo.Size = new Size(104, 34);
            btnVoltarPesquisaCargo.TabIndex = 4;
            btnVoltarPesquisaCargo.Text = "voltar";
            btnVoltarPesquisaCargo.UseVisualStyleBackColor = true;
            btnVoltarPesquisaCargo.Click += btnVoltarPesquisaCargo_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 678);
            Controls.Add(btnVoltarPesquisaCargo);
            Controls.Add(btnOkCargo);
            Controls.Add(txtCargo2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Name = "Form8";
            Text = "Pesquisar por Cargo";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Label label1;
        private TextBox txtCargo2;
        private Button btnOkCargo;
        private Button btnVoltarPesquisaCargo;
    }
}