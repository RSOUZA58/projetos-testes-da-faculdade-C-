namespace projeto_parâmetro_por_valor_e_por_referência
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
            lblVarA = new Label();
            lblVarB = new Label();
            lblResA = new Label();
            lblResB = new Label();
            btnValor = new Button();
            btnRef = new Button();
            txtVarA = new TextBox();
            txtVarB = new TextBox();
            txtResA = new TextBox();
            txtResB = new TextBox();
            btnlimpar = new Button();
            SuspendLayout();
            // 
            // lblVarA
            // 
            lblVarA.AutoSize = true;
            lblVarA.Location = new Point(20, 45);
            lblVarA.Name = "lblVarA";
            lblVarA.Size = new Size(58, 15);
            lblVarA.TabIndex = 0;
            lblVarA.Text = "Variável A";
            // 
            // lblVarB
            // 
            lblVarB.AutoSize = true;
            lblVarB.Location = new Point(20, 104);
            lblVarB.Name = "lblVarB";
            lblVarB.Size = new Size(57, 15);
            lblVarB.TabIndex = 1;
            lblVarB.Text = "Variável B";
            // 
            // lblResA
            // 
            lblResA.AutoSize = true;
            lblResA.Location = new Point(20, 273);
            lblResA.Name = "lblResA";
            lblResA.Size = new Size(58, 15);
            lblResA.TabIndex = 2;
            lblResA.Text = "Variável A";
            // 
            // lblResB
            // 
            lblResB.AutoSize = true;
            lblResB.Location = new Point(20, 366);
            lblResB.Name = "lblResB";
            lblResB.Size = new Size(57, 15);
            lblResB.TabIndex = 3;
            lblResB.Text = "variável B";
            // 
            // btnValor
            // 
            btnValor.Location = new Point(20, 198);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(99, 30);
            btnValor.TabIndex = 4;
            btnValor.Text = "Por Valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // btnRef
            // 
            btnRef.Location = new Point(152, 198);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(107, 30);
            btnRef.TabIndex = 5;
            btnRef.Text = "Por Referência";
            btnRef.UseVisualStyleBackColor = true;
            btnRef.Click += btnRef_Click;
            // 
            // txtVarA
            // 
            txtVarA.Location = new Point(137, 51);
            txtVarA.Name = "txtVarA";
            txtVarA.Size = new Size(100, 23);
            txtVarA.TabIndex = 6;
            // 
            // txtVarB
            // 
            txtVarB.Location = new Point(137, 101);
            txtVarB.Name = "txtVarB";
            txtVarB.Size = new Size(100, 23);
            txtVarB.TabIndex = 7;
            // 
            // txtResA
            // 
            txtResA.Location = new Point(127, 273);
            txtResA.Name = "txtResA";
            txtResA.Size = new Size(100, 23);
            txtResA.TabIndex = 8;
            // 
            // txtResB
            // 
            txtResB.Location = new Point(127, 358);
            txtResB.Name = "txtResB";
            txtResB.Size = new Size(100, 23);
            txtResB.TabIndex = 9;
            txtResB.TextChanged += textBox4_TextChanged;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(99, 152);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 10;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 461);
            Controls.Add(btnlimpar);
            Controls.Add(txtResB);
            Controls.Add(txtResA);
            Controls.Add(txtVarB);
            Controls.Add(txtVarA);
            Controls.Add(btnRef);
            Controls.Add(btnValor);
            Controls.Add(lblResB);
            Controls.Add(lblResA);
            Controls.Add(lblVarB);
            Controls.Add(lblVarA);
            Name = "Form1";
            Text = "Valor / Referência";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVarA;
        private Label lblVarB;
        private Label lblResA;
        private Label lblResB;
        private Button btnValor;
        private Button btnRef;
        private TextBox txtVarA;
        private TextBox txtVarB;
        private TextBox txtResA;
        private TextBox txtResB;
        private Button btnlimpar;
    }
}
