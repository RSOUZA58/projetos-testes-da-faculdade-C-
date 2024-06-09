namespace somar_pares__estrutura_de_repetição
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
            btnLimpar = new Button();
            btnCalcular = new Button();
            lblNúmero = new Label();
            lblSoma = new Label();
            txtNum = new TextBox();
            txtSoma = new TextBox();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(51, 98);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 36);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(193, 98);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(123, 36);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNúmero
            // 
            lblNúmero.AutoSize = true;
            lblNúmero.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNúmero.Location = new Point(51, 32);
            lblNúmero.Name = "lblNúmero";
            lblNúmero.Size = new Size(57, 16);
            lblNúmero.TabIndex = 2;
            lblNúmero.Text = "Número";
            // 
            // lblSoma
            // 
            lblSoma.AutoSize = true;
            lblSoma.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoma.Location = new Point(57, 200);
            lblSoma.Name = "lblSoma";
            lblSoma.Size = new Size(51, 20);
            lblSoma.TabIndex = 3;
            lblSoma.Text = "Soma";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(114, 32);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(151, 23);
            txtNum.TabIndex = 4;
            // 
            // txtSoma
            // 
            txtSoma.Location = new Point(114, 197);
            txtSoma.Name = "txtSoma";
            txtSoma.Size = new Size(151, 23);
            txtSoma.TabIndex = 5;
            txtSoma.TextChanged += txtSoma_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 236);
            Controls.Add(txtSoma);
            Controls.Add(txtNum);
            Controls.Add(lblSoma);
            Controls.Add(lblNúmero);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpar);
            Name = "Form1";
            Text = "Somar Pares";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnCalcular;
        private Label lblNúmero;
        private Label lblSoma;
        private TextBox txtNum;
        private TextBox txtSoma;
    }
}
