namespace dias_da_semana
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
            lblDia = new Label();
            lblDiaSemana = new Label();
            btnVerificar = new Button();
            btnFechar = new Button();
            txtDia = new TextBox();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDia.Location = new Point(107, 65);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(33, 21);
            lblDia.TabIndex = 0;
            lblDia.Text = "Dia";
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaSemana.ForeColor = Color.Red;
            lblDiaSemana.Location = new Point(146, 124);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(57, 20);
            lblDiaSemana.TabIndex = 1;
            lblDiaSemana.Text = "label2";
            lblDiaSemana.Click += lblDiaSemana_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(107, 186);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(203, 186);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(146, 63);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 289);
            ControlBox = false;
            Controls.Add(txtDia);
            Controls.Add(btnFechar);
            Controls.Add(btnVerificar);
            Controls.Add(lblDiaSemana);
            Controls.Add(lblDia);
            Name = "Form1";
            Text = "Seleciona  Dia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblDiaSemana;
        private Button btnVerificar;
        private Button btnFechar;
        private TextBox txtDia;
    }
}
