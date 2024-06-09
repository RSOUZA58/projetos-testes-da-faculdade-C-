namespace pedido_pizzaria
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
            lblSabores = new Label();
            cboSabores = new ComboBox();
            grpIngredientes = new GroupBox();
            chkAzeitona = new CheckBox();
            chkCebola = new CheckBox();
            btnImprimir = new Button();
            btnLimpar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpBorda = new GroupBox();
            rdbComBorda = new RadioButton();
            rdbSemBorda = new RadioButton();
            grpIngredientes.SuspendLayout();
            grpBorda.SuspendLayout();
            SuspendLayout();
            // 
            // lblSabores
            // 
            lblSabores.AutoSize = true;
            lblSabores.Location = new Point(51, 47);
            lblSabores.Name = "lblSabores";
            lblSabores.Size = new Size(98, 15);
            lblSabores.TabIndex = 0;
            lblSabores.Text = "Sabores da Pizzas";
            // 
            // cboSabores
            // 
            cboSabores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSabores.FormattingEnabled = true;
            cboSabores.Items.AddRange(new object[] { "Atum", "Calabresa", "Mussarela", "Palmito" });
            cboSabores.Location = new Point(155, 44);
            cboSabores.Name = "cboSabores";
            cboSabores.Size = new Size(197, 23);
            cboSabores.Sorted = true;
            cboSabores.TabIndex = 1;
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(chkAzeitona);
            grpIngredientes.Controls.Add(chkCebola);
            grpIngredientes.Location = new Point(43, 109);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(173, 100);
            grpIngredientes.TabIndex = 2;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Ingredientes Adicionais";
            // 
            // chkAzeitona
            // 
            chkAzeitona.AutoSize = true;
            chkAzeitona.Location = new Point(19, 59);
            chkAzeitona.Name = "chkAzeitona";
            chkAzeitona.Size = new Size(72, 19);
            chkAzeitona.TabIndex = 1;
            chkAzeitona.Text = "Azeitona";
            chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            chkCebola.AutoSize = true;
            chkCebola.Location = new Point(19, 25);
            chkCebola.Name = "chkCebola";
            chkCebola.Size = new Size(63, 19);
            chkCebola.TabIndex = 0;
            chkCebola.Text = "Cebola";
            chkCebola.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(51, 215);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(165, 29);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir Pedido";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(249, 215);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(200, 29);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar Pedido";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork_1;
            // 
            // grpBorda
            // 
            grpBorda.Controls.Add(rdbComBorda);
            grpBorda.Location = new Point(249, 109);
            grpBorda.Name = "grpBorda";
            grpBorda.Size = new Size(200, 100);
            grpBorda.TabIndex = 5;
            grpBorda.TabStop = false;
            grpBorda.Text = "Borda";
            // 
            // rdbComBorda
            // 
            rdbComBorda.AutoSize = true;
            rdbComBorda.Location = new Point(7, 59);
            rdbComBorda.Name = "rdbComBorda";
            rdbComBorda.Size = new Size(139, 19);
            rdbComBorda.TabIndex = 0;
            rdbComBorda.Text = "Com Borda Recheada";
            rdbComBorda.UseVisualStyleBackColor = true;
            rdbComBorda.CheckedChanged += rdbComBorda_CheckedChanged;
            // 
            // rdbSemBorda
            // 
            rdbSemBorda.AutoSize = true;
            rdbSemBorda.Checked = true;
            rdbSemBorda.Location = new Point(256, 131);
            rdbSemBorda.Name = "rdbSemBorda";
            rdbSemBorda.Size = new Size(82, 19);
            rdbSemBorda.TabIndex = 1;
            rdbSemBorda.TabStop = true;
            rdbSemBorda.Text = "Sem Borda";
            rdbSemBorda.UseVisualStyleBackColor = true;
            rdbSemBorda.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 329);
            Controls.Add(rdbSemBorda);
            Controls.Add(grpBorda);
            Controls.Add(btnLimpar);
            Controls.Add(btnImprimir);
            Controls.Add(grpIngredientes);
            Controls.Add(cboSabores);
            Controls.Add(lblSabores);
            Name = "Form1";
            Text = "Pizzaria";
            Load += Form1_Load;
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            grpBorda.ResumeLayout(false);
            grpBorda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSabores;
        private ComboBox cboSabores;
        private GroupBox grpIngredientes;
        private CheckBox chkAzeitona;
        private CheckBox chkCebola;
        private Button btnImprimir;
        private Button btnLimpar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpBorda;
        private RadioButton rdbSemBorda;
        private RadioButton rdbComBorda;
    }
}
