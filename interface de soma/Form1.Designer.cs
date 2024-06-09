namespace interface_de_soma
{
    partial class frmSoma
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
            textA = new TextBox();
            textB = new TextBox();
            btnInteiros = new Button();
            btnReais = new Button();
            textResultado = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 9F);
            lblA.Location = new Point(53, 14);
            lblA.Name = "lblA";
            lblA.Size = new Size(15, 15);
            lblA.TabIndex = 0;
            lblA.Text = "A";
            lblA.Click += label1_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 9F);
            lblB.Location = new Point(53, 46);
            lblB.Name = "lblB";
            lblB.Size = new Size(14, 15);
            lblB.TabIndex = 1;
            lblB.Text = "B";
            lblB.Click += label2_Click;
            // 
            // textA
            // 
            textA.Location = new Point(87, 11);
            textA.Name = "textA";
            textA.Size = new Size(100, 23);
            textA.TabIndex = 2;
            textA.TextChanged += textA_TextChanged;
            // 
            // textB
            // 
            textB.Location = new Point(87, 43);
            textB.Name = "textB";
            textB.Size = new Size(100, 23);
            textB.TabIndex = 3;
            // 
            // btnInteiros
            // 
            btnInteiros.Location = new Point(193, 11);
            btnInteiros.Name = "btnInteiros";
            btnInteiros.Size = new Size(101, 23);
            btnInteiros.TabIndex = 4;
            btnInteiros.Text = "Inteiros";
            btnInteiros.UseVisualStyleBackColor = true;
            btnInteiros.Click += button1_Click;
            // 
            // btnReais
            // 
            btnReais.Location = new Point(193, 43);
            btnReais.Name = "btnReais";
            btnReais.Size = new Size(101, 23);
            btnReais.TabIndex = 5;
            btnReais.Text = "Reais";
            btnReais.UseVisualStyleBackColor = true;
            btnReais.Click += btnReais_Click;
            // 
            // textResultado
            // 
            textResultado.Location = new Point(86, 82);
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(100, 23);
            textResultado.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F);
            lblResultado.Location = new Point(12, 85);
            lblResultado.Name = "lblResultado";
            lblResultado.Padding = new Padding(6, 3, 3, 3);
            lblResultado.Size = new Size(68, 21);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            lblResultado.Click += label3_Click;
            // 
            // frmSoma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 139);
            Controls.Add(lblResultado);
            Controls.Add(textResultado);
            Controls.Add(btnReais);
            Controls.Add(btnInteiros);
            Controls.Add(textB);
            Controls.Add(textA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "frmSoma";
            Text = "Soma";
            Load += frmSoma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private TextBox textA;
        private TextBox textB;
        private Button btnInteiros;
        private Button btnReais;
        private TextBox textResultado;
        private Label lblResultado;
    }
}
