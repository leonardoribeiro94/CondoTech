namespace Condominio.DeskTop.Formularios.Visitante
{
    partial class FrmVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisitante));
            this.tblCtrlAreaDeLazer = new System.Windows.Forms.TabControl();
            this.tabMoradorConsulta = new System.Windows.Forms.TabPage();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.dgvVisitante = new System.Windows.Forms.DataGridView();
            this.tabMoradorCadastro = new System.Windows.Forms.TabPage();
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.groupBoxDadosAreaDeLazer = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picAreaDeLazer = new System.Windows.Forms.PictureBox();
            this.btnExcluirAreaDeLazer = new System.Windows.Forms.Button();
            this.btnAtualizarAreaDeLazer = new System.Windows.Forms.Button();
            this.btnExibirImagem = new System.Windows.Forms.Button();
            this.btnInserirAreaDeLazer = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tblCtrlAreaDeLazer.SuspendLayout();
            this.tabMoradorConsulta.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).BeginInit();
            this.tabMoradorCadastro.SuspendLayout();
            this.groupBoxCadastrar.SuspendLayout();
            this.groupBoxDadosAreaDeLazer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAreaDeLazer)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCtrlAreaDeLazer
            // 
            this.tblCtrlAreaDeLazer.Controls.Add(this.tabMoradorConsulta);
            this.tblCtrlAreaDeLazer.Controls.Add(this.tabMoradorCadastro);
            this.tblCtrlAreaDeLazer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCtrlAreaDeLazer.Location = new System.Drawing.Point(0, 0);
            this.tblCtrlAreaDeLazer.Name = "tblCtrlAreaDeLazer";
            this.tblCtrlAreaDeLazer.SelectedIndex = 0;
            this.tblCtrlAreaDeLazer.Size = new System.Drawing.Size(701, 444);
            this.tblCtrlAreaDeLazer.TabIndex = 2;
            // 
            // tabMoradorConsulta
            // 
            this.tabMoradorConsulta.Controls.Add(this.grpPesquisa);
            this.tabMoradorConsulta.Controls.Add(this.dgvVisitante);
            this.tabMoradorConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabMoradorConsulta.Name = "tabMoradorConsulta";
            this.tabMoradorConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoradorConsulta.Size = new System.Drawing.Size(693, 418);
            this.tabMoradorConsulta.TabIndex = 0;
            this.tabMoradorConsulta.Text = "Consulta";
            this.tabMoradorConsulta.UseVisualStyleBackColor = true;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.label1);
            this.grpPesquisa.Controls.Add(this.txtNomeConsulta);
            this.grpPesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.grpPesquisa.Location = new System.Drawing.Point(25, 18);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(633, 92);
            this.grpPesquisa.TabIndex = 1;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Consultar Visitantes";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(397, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(204, 43);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "     Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Visitante";
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(10, 43);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(346, 23);
            this.txtNomeConsulta.TabIndex = 0;
            // 
            // dgvVisitante
            // 
            this.dgvVisitante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVisitante.Location = new System.Drawing.Point(12, 133);
            this.dgvVisitante.Name = "dgvVisitante";
            this.dgvVisitante.RowTemplate.Height = 20;
            this.dgvVisitante.Size = new System.Drawing.Size(675, 251);
            this.dgvVisitante.TabIndex = 0;
            // 
            // tabMoradorCadastro
            // 
            this.tabMoradorCadastro.Controls.Add(this.groupBoxCadastrar);
            this.tabMoradorCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabMoradorCadastro.Name = "tabMoradorCadastro";
            this.tabMoradorCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoradorCadastro.Size = new System.Drawing.Size(693, 418);
            this.tabMoradorCadastro.TabIndex = 1;
            this.tabMoradorCadastro.Text = "Cadastro";
            this.tabMoradorCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBoxCadastrar
            // 
            this.groupBoxCadastrar.Controls.Add(this.groupBoxDadosAreaDeLazer);
            this.groupBoxCadastrar.Controls.Add(this.picAreaDeLazer);
            this.groupBoxCadastrar.Controls.Add(this.btnExcluirAreaDeLazer);
            this.groupBoxCadastrar.Controls.Add(this.btnAtualizarAreaDeLazer);
            this.groupBoxCadastrar.Controls.Add(this.btnExibirImagem);
            this.groupBoxCadastrar.Controls.Add(this.btnInserirAreaDeLazer);
            this.groupBoxCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxCadastrar.Location = new System.Drawing.Point(23, 19);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(631, 336);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Cadastrar Visitante";
            // 
            // groupBoxDadosAreaDeLazer
            // 
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtCpf);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label7);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtCelular);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label6);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtTelefoneFixo);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label5);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label8);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtEmail);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label9);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label4);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtCodigo);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtNome);
            this.groupBoxDadosAreaDeLazer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDadosAreaDeLazer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxDadosAreaDeLazer.Location = new System.Drawing.Point(173, 33);
            this.groupBoxDadosAreaDeLazer.Name = "groupBoxDadosAreaDeLazer";
            this.groupBoxDadosAreaDeLazer.Size = new System.Drawing.Size(423, 216);
            this.groupBoxDadosAreaDeLazer.TabIndex = 18;
            this.groupBoxDadosAreaDeLazer.TabStop = false;
            this.groupBoxDadosAreaDeLazer.Text = "Dados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "E-mail*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(369, 23);
            this.txtEmail.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome*";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(24, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 23);
            this.txtNome.TabIndex = 3;
            // 
            // picAreaDeLazer
            // 
            this.picAreaDeLazer.Image = ((System.Drawing.Image)(resources.GetObject("picAreaDeLazer.Image")));
            this.picAreaDeLazer.Location = new System.Drawing.Point(11, 33);
            this.picAreaDeLazer.Name = "picAreaDeLazer";
            this.picAreaDeLazer.Size = new System.Drawing.Size(138, 126);
            this.picAreaDeLazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAreaDeLazer.TabIndex = 17;
            this.picAreaDeLazer.TabStop = false;
            // 
            // btnExcluirAreaDeLazer
            // 
            this.btnExcluirAreaDeLazer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnExcluirAreaDeLazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirAreaDeLazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAreaDeLazer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluirAreaDeLazer.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAreaDeLazer.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirAreaDeLazer.Image")));
            this.btnExcluirAreaDeLazer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExcluirAreaDeLazer.Location = new System.Drawing.Point(335, 285);
            this.btnExcluirAreaDeLazer.Name = "btnExcluirAreaDeLazer";
            this.btnExcluirAreaDeLazer.Size = new System.Drawing.Size(152, 40);
            this.btnExcluirAreaDeLazer.TabIndex = 16;
            this.btnExcluirAreaDeLazer.Text = " Excluir";
            this.btnExcluirAreaDeLazer.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarAreaDeLazer
            // 
            this.btnAtualizarAreaDeLazer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.btnAtualizarAreaDeLazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizarAreaDeLazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarAreaDeLazer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAtualizarAreaDeLazer.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarAreaDeLazer.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarAreaDeLazer.Image")));
            this.btnAtualizarAreaDeLazer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAtualizarAreaDeLazer.Location = new System.Drawing.Point(173, 285);
            this.btnAtualizarAreaDeLazer.Name = "btnAtualizarAreaDeLazer";
            this.btnAtualizarAreaDeLazer.Size = new System.Drawing.Size(152, 40);
            this.btnAtualizarAreaDeLazer.TabIndex = 15;
            this.btnAtualizarAreaDeLazer.Text = "  Atualizar";
            this.btnAtualizarAreaDeLazer.UseVisualStyleBackColor = false;
            // 
            // btnExibirImagem
            // 
            this.btnExibirImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnExibirImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExibirImagem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirImagem.ForeColor = System.Drawing.Color.Black;
            this.btnExibirImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnExibirImagem.Image")));
            this.btnExibirImagem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExibirImagem.Location = new System.Drawing.Point(11, 165);
            this.btnExibirImagem.Name = "btnExibirImagem";
            this.btnExibirImagem.Size = new System.Drawing.Size(138, 42);
            this.btnExibirImagem.TabIndex = 14;
            this.btnExibirImagem.Text = "   Selecionar";
            this.btnExibirImagem.UseVisualStyleBackColor = false;
            // 
            // btnInserirAreaDeLazer
            // 
            this.btnInserirAreaDeLazer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.btnInserirAreaDeLazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserirAreaDeLazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirAreaDeLazer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInserirAreaDeLazer.ForeColor = System.Drawing.Color.White;
            this.btnInserirAreaDeLazer.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirAreaDeLazer.Image")));
            this.btnInserirAreaDeLazer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInserirAreaDeLazer.Location = new System.Drawing.Point(11, 285);
            this.btnInserirAreaDeLazer.Name = "btnInserirAreaDeLazer";
            this.btnInserirAreaDeLazer.Size = new System.Drawing.Size(152, 40);
            this.btnInserirAreaDeLazer.TabIndex = 14;
            this.btnInserirAreaDeLazer.Text = " Inserir";
            this.btnInserirAreaDeLazer.UseVisualStyleBackColor = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(262, 103);
            this.txtCpf.Mask = "000000000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(133, 23);
            this.txtCpf.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cpf*";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(24, 103);
            this.txtCelular.Mask = "(00)00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(106, 23);
            this.txtCelular.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefone Celular";
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.Location = new System.Drawing.Point(146, 103);
            this.txtTelefoneFixo.Mask = "(00)0000-0000";
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(110, 23);
            this.txtTelefoneFixo.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefone Fixo";
            // 
            // FrmVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 444);
            this.Controls.Add(this.tblCtrlAreaDeLazer);
            this.Name = "FrmVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitante";
            this.tblCtrlAreaDeLazer.ResumeLayout(false);
            this.tabMoradorConsulta.ResumeLayout(false);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).EndInit();
            this.tabMoradorCadastro.ResumeLayout(false);
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxDadosAreaDeLazer.ResumeLayout(false);
            this.groupBoxDadosAreaDeLazer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAreaDeLazer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tblCtrlAreaDeLazer;
        private System.Windows.Forms.TabPage tabMoradorConsulta;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.DataGridView dgvVisitante;
        private System.Windows.Forms.TabPage tabMoradorCadastro;
        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.GroupBox groupBoxDadosAreaDeLazer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox picAreaDeLazer;
        private System.Windows.Forms.Button btnExcluirAreaDeLazer;
        private System.Windows.Forms.Button btnAtualizarAreaDeLazer;
        private System.Windows.Forms.Button btnExibirImagem;
        private System.Windows.Forms.Button btnInserirAreaDeLazer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixo;
        private System.Windows.Forms.Label label5;
    }
}