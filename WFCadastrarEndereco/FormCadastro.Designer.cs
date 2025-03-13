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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblCEP = new Label();
            label2 = new Label();
            mtbCep = new MaskedTextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            cbxUf = new ComboBox();
            lblUf = new Label();
            btnSalvar = new Button();
            chkSemNumero = new CheckBox();
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
            txtNomeCompleto.Location = new Point(22, 39);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(378, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(20, 99);
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
            // mtbCep
            // 
            mtbCep.Location = new Point(22, 117);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(103, 23);
            mtbCep.TabIndex = 2;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(22, 153);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 6;
            lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(20, 176);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(147, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(20, 235);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(163, 23);
            txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(20, 212);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 8;
            lblComplemento.Text = "Complemento";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(184, 176);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(184, 153);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 10;
            lblNumero.Text = "Número";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(207, 235);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(193, 23);
            txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(207, 212);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 12;
            lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(20, 297);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(231, 23);
            txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(20, 274);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 14;
            lblCidade.Text = "Cidade";
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(279, 297);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(121, 23);
            cbxUf.TabIndex = 8;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(279, 274);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 17;
            lblUf.Text = "UF";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(313, 345);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 44);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnSalvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(299, 176);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(101, 19);
            chkSemNumero.TabIndex = 19;
            chkSemNumero.Text = "Sem Número?";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 401);
            Controls.Add(chkSemNumero);
            Controls.Add(btnSalvar);
            Controls.Add(lblUf);
            Controls.Add(cbxUf);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(mtbCep);
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
        private TextBox txtLogradouro;
        private Label lblCEP;
        private Label label2;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private ComboBox cbxUf;
        private Label lblUf;
        private Button btnSalvar;
        private CheckBox chkSemNumero;
    }
}