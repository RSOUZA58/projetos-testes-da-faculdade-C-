namespace mostrando_animais_com_patas
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

        private Button GetBtnPatas()
        {
            return btnPatas;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button btnPatas)
        {
            cboAnimais = new ComboBox();
            btnPatas = new Button();
            pctAnimais = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctAnimais).BeginInit();
            SuspendLayout();
            // 
            // cboAnimais
            // 
            cboAnimais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnimais.FormattingEnabled = true;
            cboAnimais.Items.AddRange(new object[] { "Cavalo", "Cachorro", "Gato", "Cobra", "Centopeia", "Passaro" });
            cboAnimais.Location = new Point(160, 84);
            cboAnimais.Name = "cboAnimais";
            cboAnimais.Size = new Size(256, 23);
            cboAnimais.TabIndex = 0;
            cboAnimais.SelectedIndexChanged += cboAnimais_SelectedIndexChanged;
            // 
            // btnPatas
            // 
            btnPatas.Location = new Point(211, 138);
            btnPatas.Name = "btnPatas";
            btnPatas.Size = new Size(173, 23);
            btnPatas.TabIndex = 1;
            btnPatas.Text = "Mostrar Patas";
            
            // 
            // pctAnimais
            // 
            pctAnimais.Location = new Point(67, 184);
            pctAnimais.Name = "pctAnimais";
            pctAnimais.Size = new Size(437, 254);
            pctAnimais.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAnimais.TabIndex = 2;
            pctAnimais.TabStop = false;
            pctAnimais.Click += pctAnimais_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(pctAnimais);
            Controls.Add(btnPatas);
            Controls.Add(cboAnimais);
            Name = "Form1";
            Text = "Animais";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctAnimais).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboAnimais;
        private Button btnPatas;
        private PictureBox pctAnimais;
    }
}
