namespace mostrar_patas_2
{
    partial class from1
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
            pctAnimais = new PictureBox();
            btnPatas = new Button();
            cboAnimais = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pctAnimais).BeginInit();
            SuspendLayout();
            // 
            // pctAnimais
            // 
            pctAnimais.Location = new Point(23, 157);
            pctAnimais.Name = "pctAnimais";
            pctAnimais.Size = new Size(491, 281);
            pctAnimais.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAnimais.TabIndex = 0;
            pctAnimais.TabStop = false;
            // 
            // btnPatas
            // 
            btnPatas.Location = new Point(67, 114);
            btnPatas.Name = "btnPatas";
            btnPatas.Size = new Size(410, 23);
            btnPatas.TabIndex = 1;
            btnPatas.Text = "Mostrar Patas";
            btnPatas.UseVisualStyleBackColor = true;
            btnPatas.Click += btnPatas_Click;
            // 
            // cboAnimais
            // 
            cboAnimais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnimais.FormattingEnabled = true;
            cboAnimais.Items.AddRange(new object[] { "Cachorro", "Cavalo", "Centopeia", "Cobra", "Pássaro" });
            cboAnimais.Location = new Point(67, 61);
            cboAnimais.Name = "cboAnimais";
            cboAnimais.Size = new Size(410, 23);
            cboAnimais.Sorted = true;
            cboAnimais.TabIndex = 2;
            // 
            // from1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(cboAnimais);
            Controls.Add(btnPatas);
            Controls.Add(pctAnimais);
            Name = "from1";
            Text = "Animais";
            Load += from1_Load;
            ((System.ComponentModel.ISupportInitialize)pctAnimais).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctAnimais;
        private Button btnPatas;
        private ComboBox cboAnimais;
    }
}
