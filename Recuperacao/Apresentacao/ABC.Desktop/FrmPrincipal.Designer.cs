namespace ABC.Desktop
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtDataNascimento = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            txtCargo = new TextBox();
            label8 = new Label();
            txtEmpresa = new TextBox();
            label9 = new Label();
            txtDataContato = new MaskedTextBox();
            label10 = new Label();
            txtObservacoes = new TextBox();
            label11 = new Label();
            dtgListaContatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Excluir = new DataGridViewImageColumn();
            btnCadastrar = new Button();
            BtnEditar = new Button();
            label12 = new Label();
            txtPesquisaContatos = new TextBox();
            txtCep = new MaskedTextBox();
            txtBairro = new TextBox();
            label13 = new Label();
            txtCidade = new TextBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgListaContatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 58);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 119);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(205, 58);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 177);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 3;
            label4.Text = "Cep";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(174, 119);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 4;
            label5.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 23);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(205, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(21, 143);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 8;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(174, 143);
            txtDataNascimento.Mask = "      00 /00 /0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(100, 23);
            txtDataNascimento.TabIndex = 9;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 22);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 10;
            label6.Text = "Campo de Dados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(431, 22);
            label7.Name = "label7";
            label7.Size = new Size(181, 21);
            label7.TabIndex = 11;
            label7.Text = "Informações Adicionais";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(440, 83);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(161, 23);
            txtCargo.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(440, 59);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 12;
            label8.Text = "Cargo";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(642, 83);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(161, 23);
            txtEmpresa.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(642, 59);
            label9.Name = "label9";
            label9.Size = new Size(72, 21);
            label9.TabIndex = 14;
            label9.Text = "Empresa";
            // 
            // txtDataContato
            // 
            txtDataContato.Location = new Point(440, 143);
            txtDataContato.Mask = "      00 /00 /0000";
            txtDataContato.Name = "txtDataContato";
            txtDataContato.Size = new Size(100, 23);
            txtDataContato.TabIndex = 17;
            txtDataContato.ValidatingType = typeof(DateTime);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(436, 119);
            label10.Name = "label10";
            label10.Size = new Size(129, 21);
            label10.TabIndex = 16;
            label10.Text = "Data de Contato";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(593, 143);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(210, 65);
            txtObservacoes.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(593, 119);
            label11.Name = "label11";
            label11.Size = new Size(105, 21);
            label11.TabIndex = 18;
            label11.Text = "Observações";
            // 
            // dtgListaContatos
            // 
            dtgListaContatos.AllowUserToAddRows = false;
            dtgListaContatos.AllowUserToDeleteRows = false;
            dtgListaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaContatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column5, Column3, Column10, Excluir });
            dtgListaContatos.Location = new Point(3, 313);
            dtgListaContatos.Name = "dtgListaContatos";
            dtgListaContatos.ReadOnly = true;
            dtgListaContatos.RowHeadersVisible = false;
            dtgListaContatos.RowTemplate.Height = 25;
            dtgListaContatos.Size = new Size(821, 309);
            dtgListaContatos.TabIndex = 22;
            dtgListaContatos.CellContentClick += dtgListaContatos_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Nome";
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Telefone";
            Column4.HeaderText = "Telefone";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DataNascimento";
            Column5.HeaderText = "Data de Nascimento";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Email";
            Column3.HeaderText = "E-mail";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 230;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Empresa";
            Column10.HeaderText = "Empresa";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Image = (Image)resources.GetObject("Excluir.Image");
            Excluir.Name = "Excluir";
            Excluir.ReadOnly = true;
            Excluir.Resizable = DataGridViewTriState.True;
            Excluir.SortMode = DataGridViewColumnSortMode.Automatic;
            Excluir.Width = 50;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(0, 192, 0);
            btnCadastrar.Location = new Point(51, 239);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 32);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "Cadastrar Usuário";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.DodgerBlue;
            BtnEditar.Location = new Point(195, 239);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(112, 32);
            BtnEditar.TabIndex = 25;
            BtnEditar.Text = "Editar Usuário";
            BtnEditar.UseVisualStyleBackColor = false;

            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(466, 286);
            label12.Name = "label12";
            label12.Size = new Size(169, 21);
            label12.TabIndex = 26;
            label12.Text = "Pesquisa de Contatos:";
            // 
            // txtPesquisaContatos
            // 
            txtPesquisaContatos.Location = new Point(637, 284);
            txtPesquisaContatos.Name = "txtPesquisaContatos";
            txtPesquisaContatos.Size = new Size(187, 23);
            txtPesquisaContatos.TabIndex = 27;
            txtPesquisaContatos.TextChanged += txtPesquisaContatos_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(21, 201);
            txtCep.Mask = "     00000-999";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 28;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(276, 201);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(133, 23);
            txtBairro.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(276, 177);
            label13.Name = "label13";
            label13.Size = new Size(54, 21);
            label13.TabIndex = 29;
            label13.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(134, 201);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(125, 23);
            txtCidade.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(134, 177);
            label14.Name = "label14";
            label14.Size = new Size(61, 21);
            label14.TabIndex = 31;
            label14.Text = "Cidade";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 631);
            Controls.Add(txtCidade);
            Controls.Add(label14);
            Controls.Add(txtBairro);
            Controls.Add(label13);
            Controls.Add(txtCep);
            Controls.Add(txtPesquisaContatos);
            Controls.Add(label12);
            Controls.Add(BtnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(dtgListaContatos);
            Controls.Add(txtObservacoes);
            Controls.Add(label11);
            Controls.Add(txtDataContato);
            Controls.Add(label10);
            Controls.Add(txtEmpresa);
            Controls.Add(label9);
            Controls.Add(txtCargo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário ABC";
            ((System.ComponentModel.ISupportInitialize)dtgListaContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtDataNascimento;
        private Label label6;
        private Label label7;
        private TextBox txtCargo;
        private Label label8;
        private TextBox txtEmpresa;
        private Label label9;
        private MaskedTextBox txtDataContato;
        private Label label10;
        private TextBox txtObservacoes;
        private Label label11;
        private DataGridView dtgListaContatos;
        private Button btnCadastrar;
        private Button BtnEditar;
        private Label label12;
        private TextBox txtPesquisaContatos;
        private MaskedTextBox txtCep;
        private TextBox txtBairro;
        private Label label13;
        private TextBox txtCidade;
        private Label label14;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewImageColumn Excluir;
    }
}