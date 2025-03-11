namespace WFCadastrarEndereco
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblCEP = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(20, 21);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(20, 39);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(383, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(22, 99);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(28, 15);
            lblCEP.TabIndex = 2;
            lblCEP.Text = "CEP";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(378, 1);
            label2.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(26, 118);
            maskedTextBox1.Mask = "00000-999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(74, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 401);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(lblCEP);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private TextBox textBox1;
        private Label lblCEP;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
    }
}