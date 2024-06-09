namespace projeto_verifica_maior_numero
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
            lblA = new Label();
            lblB = new Label();
            lblMaior = new Label();
            btnVerificar = new Button();
            btnLimpar = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            txtMaior = new TextBox();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(22, 49);
            lblA.Name = "lblA";
            lblA.Size = new Size(15, 15);
            lblA.TabIndex = 0;
            lblA.Text = "A";
            lblA.Click += lblA_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(22, 120);
            lblB.Name = "lblB";
            lblB.Size = new Size(14, 15);
            lblB.TabIndex = 1;
            lblB.Text = "B";
            // 
            // lblMaior
            // 
            lblMaior.AutoSize = true;
            lblMaior.Location = new Point(22, 182);
            lblMaior.Name = "lblMaior";
            lblMaior.Size = new Size(38, 15);
            lblMaior.TabIndex = 2;
            lblMaior.Text = "Maior";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(259, 45);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar ";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(259, 112);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(109, 45);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 6;
            // 
            // txtB
            // 
            txtB.Location = new Point(109, 112);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 7;
            // 
            // txtMaior
            // 
            txtMaior.Location = new Point(109, 174);
            txtMaior.Name = "txtMaior";
            txtMaior.ReadOnly = true;
            txtMaior.Size = new Size(100, 23);
            txtMaior.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 240);
            Controls.Add(txtMaior);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnLimpar);
            Controls.Add(btnVerificar);
            Controls.Add(lblMaior);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Verificar Maior";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private Label lblMaior;
        private Button btnVerificar;
        private Button btnLimpar;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtMaior;
    }
}
