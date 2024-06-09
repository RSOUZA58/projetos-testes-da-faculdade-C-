namespace uninove_teste
{
    partial class form1
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
            lblnome = new Label();
            txtnome = new TextBox();
            btnmenssagem = new Button();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(17, 14);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(42, 15);
            lblnome.TabIndex = 0;
            lblnome.Text = "NOME";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(61, 6);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 1;
            // 
            // btnmenssagem
            // 
            btnmenssagem.BackColor = SystemColors.WindowText;
            btnmenssagem.ForeColor = SystemColors.ButtonFace;
            btnmenssagem.Location = new Point(73, 35);
            btnmenssagem.Name = "btnmenssagem";
            btnmenssagem.Size = new Size(88, 23);
            btnmenssagem.TabIndex = 2;
            btnmenssagem.Text = "menssagem";
            btnmenssagem.UseVisualStyleBackColor = false;
            btnmenssagem.Click += btnmenssagem_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnmenssagem);
            Controls.Add(txtnome);
            Controls.Add(lblnome);
            Name = "form1";
            Text = "hello word";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnome;
        private TextBox txtnome;
        private Button btnmenssagem;
    }
}
