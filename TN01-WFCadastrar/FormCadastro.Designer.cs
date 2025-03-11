namespace TN01_WFCadastrar
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
            lblTelefone = new Label();
            mkdTelefone = new MaskedTextBox();
            lblDataDeNascimento = new Label();
            dtpDataDeNascimento = new DateTimePicker();
            lblEscolaridade = new Label();
            cbxEscolaridade = new ComboBox();
            gbxSexo = new GroupBox();
            rdbNaoInformado = new RadioButton();
            rdbFeminino = new RadioButton();
            rdbMasculino = new RadioButton();
            lblRendaMensal = new Label();
            nudRendaMensal = new NumericUpDown();
            chkPossuiFilhos = new CheckBox();
            btnSalvar = new Button();
            gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).BeginInit();
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
            txtNomeCompleto.Size = new Size(281, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(20, 85);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(20, 103);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(124, 23);
            mkdTelefone.TabIndex = 2;
            // 
            // lblDataDeNascimento
            // 
            lblDataDeNascimento.AutoSize = true;
            lblDataDeNascimento.Location = new Point(187, 85);
            lblDataDeNascimento.Name = "lblDataDeNascimento";
            lblDataDeNascimento.Size = new Size(114, 15);
            lblDataDeNascimento.TabIndex = 4;
            lblDataDeNascimento.Text = "Data de Nascimento";
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Format = DateTimePickerFormat.Short;
            dtpDataDeNascimento.Location = new Point(187, 103);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new Size(114, 23);
            dtpDataDeNascimento.TabIndex = 3;
            // 
            // lblEscolaridade
            // 
            lblEscolaridade.AutoSize = true;
            lblEscolaridade.Location = new Point(20, 151);
            lblEscolaridade.Name = "lblEscolaridade";
            lblEscolaridade.Size = new Size(73, 15);
            lblEscolaridade.TabIndex = 6;
            lblEscolaridade.Text = "Escolaridade";
            // 
            // cbxEscolaridade
            // 
            cbxEscolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEscolaridade.FormattingEnabled = true;
            cbxEscolaridade.Items.AddRange(new object[] { "Analfabeto", "Ensino Fundamental Incompleto", "Ensino Fuldamental Completo", "Ensino Médio Incompleto", "Ensino Médio Completo", "Ensino Técnico Incomleto", "Ensino Técnico Completo", "Ensino Superior Incompleto", "Ensino Superior Completo", "Pós-Graduação Incompleto", "Pós-Graduação Completo" });
            cbxEscolaridade.Location = new Point(20, 169);
            cbxEscolaridade.Name = "cbxEscolaridade";
            cbxEscolaridade.Size = new Size(281, 23);
            cbxEscolaridade.TabIndex = 4;
            // 
            // gbxSexo
            // 
            gbxSexo.Controls.Add(rdbNaoInformado);
            gbxSexo.Controls.Add(rdbFeminino);
            gbxSexo.Controls.Add(rdbMasculino);
            gbxSexo.Location = new Point(19, 217);
            gbxSexo.Name = "gbxSexo";
            gbxSexo.Size = new Size(162, 100);
            gbxSexo.TabIndex = 5;
            gbxSexo.TabStop = false;
            gbxSexo.Text = "Sexo";
            // 
            // rdbNaoInformado
            // 
            rdbNaoInformado.AutoSize = true;
            rdbNaoInformado.Location = new Point(17, 72);
            rdbNaoInformado.Name = "rdbNaoInformado";
            rdbNaoInformado.Size = new Size(134, 19);
            rdbNaoInformado.TabIndex = 2;
            rdbNaoInformado.Text = "Prefiro Não Informar";
            rdbNaoInformado.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(17, 47);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 1;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(17, 22);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblRendaMensal
            // 
            lblRendaMensal.AutoSize = true;
            lblRendaMensal.Location = new Point(187, 217);
            lblRendaMensal.Name = "lblRendaMensal";
            lblRendaMensal.Size = new Size(81, 15);
            lblRendaMensal.TabIndex = 9;
            lblRendaMensal.Text = "Renda Mensal";
            // 
            // nudRendaMensal
            // 
            nudRendaMensal.DecimalPlaces = 2;
            nudRendaMensal.Location = new Point(187, 235);
            nudRendaMensal.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudRendaMensal.Name = "nudRendaMensal";
            nudRendaMensal.Size = new Size(114, 23);
            nudRendaMensal.TabIndex = 6;
            // 
            // chkPossuiFilhos
            // 
            chkPossuiFilhos.AutoSize = true;
            chkPossuiFilhos.Checked = true;
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
            chkPossuiFilhos.Location = new Point(187, 281);
            chkPossuiFilhos.Name = "chkPossuiFilhos";
            chkPossuiFilhos.Size = new Size(94, 19);
            chkPossuiFilhos.TabIndex = 7;
            chkPossuiFilhos.Text = "Possui Filhos";
            chkPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(121, 323);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 44);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnSalvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 401);
            Controls.Add(btnSalvar);
            Controls.Add(chkPossuiFilhos);
            Controls.Add(nudRendaMensal);
            Controls.Add(lblRendaMensal);
            Controls.Add(gbxSexo);
            Controls.Add(cbxEscolaridade);
            Controls.Add(lblEscolaridade);
            Controls.Add(dtpDataDeNascimento);
            Controls.Add(lblDataDeNascimento);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            Text = "FormCadastro";
            gbxSexo.ResumeLayout(false);
            gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Label lblTelefone;
        private MaskedTextBox mkdTelefone;
        private Label lblDataDeNascimento;
        private DateTimePicker dtpDataDeNascimento;
        private Label lblEscolaridade;
        private ComboBox cbxEscolaridade;
        private GroupBox gbxSexo;
        private RadioButton rdbNaoInformado;
        private RadioButton rdbFeminino;
        private RadioButton rdbMasculino;
        private Label lblRendaMensal;
        private NumericUpDown nudRendaMensal;
        private CheckBox chkPossuiFilhos;
        private Button btnSalvar;
    }
}