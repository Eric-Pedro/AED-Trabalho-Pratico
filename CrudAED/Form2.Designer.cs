﻿namespace CrudAED
{
    partial class Form2
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
            btnBuscar = new Button();
            txtCaminho = new TextBox();
            btnEnviarLista = new Button();
            btnDeletarLista = new Button();
            btnVoltar1 = new Button();
            btnOrdenar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(413, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 33);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(62, 78);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(345, 27);
            txtCaminho.TabIndex = 1;
            // 
            // btnEnviarLista
            // 
            btnEnviarLista.Location = new Point(19, 229);
            btnEnviarLista.Name = "btnEnviarLista";
            btnEnviarLista.Size = new Size(172, 50);
            btnEnviarLista.TabIndex = 2;
            btnEnviarLista.Text = "Cadastrar Lista";
            btnEnviarLista.UseVisualStyleBackColor = true;
            btnEnviarLista.Click += btnEnviarLista_Click;
            // 
            // btnDeletarLista
            // 
            btnDeletarLista.Location = new Point(205, 229);
            btnDeletarLista.Name = "btnDeletarLista";
            btnDeletarLista.Size = new Size(172, 50);
            btnDeletarLista.TabIndex = 3;
            btnDeletarLista.Text = "Apagar Lista";
            btnDeletarLista.UseVisualStyleBackColor = true;
            btnDeletarLista.Click += btnDeletarLista_Click;
            // 
            // btnVoltar1
            // 
            btnVoltar1.Location = new Point(640, 412);
            btnVoltar1.Name = "btnVoltar1";
            btnVoltar1.Size = new Size(132, 50);
            btnVoltar1.TabIndex = 5;
            btnVoltar1.Text = "Voltar";
            btnVoltar1.UseVisualStyleBackColor = true;
            btnVoltar1.Click += btnVoltar1_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(393, 229);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(172, 50);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "Ordenar por nome";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(584, 229);
            button1.Name = "button1";
            button1.Size = new Size(172, 50);
            button1.TabIndex = 7;
            button1.Text = "Ordenar por Cargo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 494);
            Controls.Add(button1);
            Controls.Add(btnOrdenar);
            Controls.Add(btnVoltar1);
            Controls.Add(btnDeletarLista);
            Controls.Add(btnEnviarLista);
            Controls.Add(txtCaminho);
            Controls.Add(btnBuscar);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Lista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilePath;
        private Button buttonBrowse;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private TextBox txtCaminho;
        private Button btnEnviarLista;
        private Button btnDeletarLista;
        private Button button2;
        private Button btnVoltar1;
        private Button btnOrdenar;
        private Button button1;
    }
}