namespace estrutura_de_repetição
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
            lstNumeros = new ListBox();
            btnfor = new Button();
            btnWhile = new Button();
            btnDo = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(26, 43);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(176, 379);
            lstNumeros.TabIndex = 0;
            // 
            // btnfor
            // 
            btnfor.Location = new Point(263, 107);
            btnfor.Name = "btnfor";
            btnfor.Size = new Size(98, 33);
            btnfor.TabIndex = 1;
            btnfor.Text = "Laço For";
            btnfor.UseVisualStyleBackColor = true;
            btnfor.Click += btnfor_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(263, 177);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(98, 33);
            btnWhile.TabIndex = 2;
            btnWhile.Text = "Laço While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // btnDo
            // 
            btnDo.Location = new Point(263, 247);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(98, 37);
            btnDo.TabIndex = 3;
            btnDo.Text = "Laço Do-While";
            btnDo.UseVisualStyleBackColor = true;
            btnDo.Click += btnDo_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(263, 323);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(98, 33);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 454);
            Controls.Add(btnLimpar);
            Controls.Add(btnDo);
            Controls.Add(btnWhile);
            Controls.Add(btnfor);
            Controls.Add(lstNumeros);
            Name = "Form1";
            Text = "Numeros Inteiros";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstNumeros;
        private Button btnfor;
        private Button btnWhile;
        private Button btnDo;
        private Button btnLimpar;
    }
}
