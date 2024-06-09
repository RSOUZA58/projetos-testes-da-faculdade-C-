namespace cauculadora_usando_alguns_componentes
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
            lblX = new Label();
            lblY = new Label();
            lblTotal = new Label();
            textX = new TextBox();
            textTotal = new TextBox();
            textY = new TextBox();
            grpAritmetica = new GroupBox();
            rdbDividir = new RadioButton();
            rdbSubtrair = new RadioButton();
            rdbMultiplicar = new RadioButton();
            rdbSomar = new RadioButton();
            btnLimpar = new Button();
            btnCalcular = new Button();
            btnFechar = new Button();
            grpAritmetica.SuspendLayout();
            SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(69, 37);
            lblX.Name = "lblX";
            lblX.Size = new Size(14, 15);
            lblX.TabIndex = 0;
            lblX.Text = "X";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(69, 79);
            lblY.Name = "lblY";
            lblY.Size = new Size(14, 15);
            lblY.TabIndex = 1;
            lblY.Text = "Y";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(69, 114);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // textX
            // 
            textX.Location = new Point(112, 34);
            textX.Name = "textX";
            textX.Size = new Size(100, 23);
            textX.TabIndex = 3;
            // 
            // textTotal
            // 
            textTotal.Location = new Point(112, 106);
            textTotal.Name = "textTotal";
            textTotal.ReadOnly = true;
            textTotal.Size = new Size(100, 23);
            textTotal.TabIndex = 4;
            // 
            // textY
            // 
            textY.Location = new Point(112, 71);
            textY.Name = "textY";
            textY.Size = new Size(100, 23);
            textY.TabIndex = 5;
            // 
            // grpAritmetica
            // 
            grpAritmetica.Controls.Add(rdbDividir);
            grpAritmetica.Controls.Add(rdbSubtrair);
            grpAritmetica.Controls.Add(rdbMultiplicar);
            grpAritmetica.Controls.Add(rdbSomar);
            grpAritmetica.Location = new Point(69, 170);
            grpAritmetica.Name = "grpAritmetica";
            grpAritmetica.Size = new Size(257, 197);
            grpAritmetica.TabIndex = 6;
            grpAritmetica.TabStop = false;
            grpAritmetica.Text = "Opereções";
            // 
            // rdbDividir
            // 
            rdbDividir.AutoSize = true;
            rdbDividir.Location = new Point(13, 129);
            rdbDividir.Name = "rdbDividir";
            rdbDividir.Size = new Size(59, 19);
            rdbDividir.TabIndex = 3;
            rdbDividir.TabStop = true;
            rdbDividir.Text = "Dividir";
            rdbDividir.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrair
            // 
            rdbSubtrair.AutoSize = true;
            rdbSubtrair.Location = new Point(13, 60);
            rdbSubtrair.Name = "rdbSubtrair";
            rdbSubtrair.Size = new Size(66, 19);
            rdbSubtrair.TabIndex = 2;
            rdbSubtrair.TabStop = true;
            rdbSubtrair.Text = "Subtrair";
            rdbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            rdbMultiplicar.AutoSize = true;
            rdbMultiplicar.Location = new Point(13, 95);
            rdbMultiplicar.Name = "rdbMultiplicar";
            rdbMultiplicar.Size = new Size(79, 19);
            rdbMultiplicar.TabIndex = 1;
            rdbMultiplicar.TabStop = true;
            rdbMultiplicar.Text = "Mutiplicar";
            rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbSomar
            // 
            rdbSomar.AutoSize = true;
            rdbSomar.Checked = true;
            rdbSomar.Location = new Point(13, 25);
            rdbSomar.Name = "rdbSomar";
            rdbSomar.Size = new Size(59, 19);
            rdbSomar.TabIndex = 0;
            rdbSomar.TabStop = true;
            rdbSomar.Text = "Somar";
            rdbSomar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(90, 413);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(206, 413);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(151, 461);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 545);
            Controls.Add(btnFechar);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpar);
            Controls.Add(grpAritmetica);
            Controls.Add(textY);
            Controls.Add(textTotal);
            Controls.Add(textX);
            Controls.Add(lblTotal);
            Controls.Add(lblY);
            Controls.Add(lblX);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Cauculadora";
            grpAritmetica.ResumeLayout(false);
            grpAritmetica.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblX;
        private Label lblY;
        private Label lblTotal;
        private TextBox textX;
        private TextBox textTotal;
        private TextBox textY;
        private GroupBox grpAritmetica;
        private RadioButton rdbDividir;
        private RadioButton rdbSubtrair;
        private RadioButton rdbMultiplicar;
        private RadioButton rdbSomar;
        private Button btnLimpar;
        private Button btnCalcular;
        private Button btnFechar;
    }
}
