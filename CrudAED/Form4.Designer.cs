namespace CrudAED
{
    partial class Form4
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
            dataGrid = new DataGridView();
            label1 = new Label();
            btnVoltarBanco = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 55);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1023, 674);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 1;
            label1.Text = "Banco de Dados:";
            // 
            // btnVoltarBanco
            // 
            btnVoltarBanco.Location = new Point(1057, 675);
            btnVoltarBanco.Name = "btnVoltarBanco";
            btnVoltarBanco.Size = new Size(96, 54);
            btnVoltarBanco.TabIndex = 2;
            btnVoltarBanco.Text = "Voltar";
            btnVoltarBanco.UseVisualStyleBackColor = true;
            btnVoltarBanco.Click += btnVoltarBanco_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 741);
            Controls.Add(btnVoltarBanco);
            Controls.Add(label1);
            Controls.Add(dataGrid);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exibição Banco de Dados";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private Label label1;
        private Button btnVoltarBanco;
    }
}