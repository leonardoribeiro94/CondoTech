namespace Condominio.DeskTop.Formularios.AreaDeLazer
{
    partial class FrmAreaDeLazer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAreaDeLazer));
            this.tblCtrlMorador = new System.Windows.Forms.TabControl();
            this.tabMoradorConsulta = new System.Windows.Forms.TabPage();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDataNascimentoConsulta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.dgvAreaDeLazer = new System.Windows.Forms.DataGridView();
            this.tabMoradorCadastro = new System.Windows.Forms.TabPage();
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.groupBoxDadosAreaDeLazer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picAreaDeLazer = new System.Windows.Forms.PictureBox();
            this.btnExcluirMorador = new System.Windows.Forms.Button();
            this.btnAtualizarMorador = new System.Windows.Forms.Button();
            this.btnExibirImagem = new System.Windows.Forms.Button();
            this.btnInserirMorador = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tblCtrlMorador.SuspendLayout();
            this.tabMoradorConsulta.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaDeLazer)).BeginInit();
            this.tabMoradorCadastro.SuspendLayout();
            this.groupBoxCadastrar.SuspendLayout();
            this.groupBoxDadosAreaDeLazer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAreaDeLazer)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCtrlMorador
            // 
            this.tblCtrlMorador.Controls.Add(this.tabMoradorConsulta);
            this.tblCtrlMorador.Controls.Add(this.tabMoradorCadastro);
            this.tblCtrlMorador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCtrlMorador.Location = new System.Drawing.Point(0, 0);
            this.tblCtrlMorador.Name = "tblCtrlMorador";
            this.tblCtrlMorador.SelectedIndex = 0;
            this.tblCtrlMorador.Size = new System.Drawing.Size(701, 444);
            this.tblCtrlMorador.TabIndex = 1;
            // 
            // tabMoradorConsulta
            // 
            this.tabMoradorConsulta.Controls.Add(this.grpPesquisa);
            this.tabMoradorConsulta.Controls.Add(this.dgvAreaDeLazer);
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
            this.grpPesquisa.Controls.Add(this.txtDataNascimentoConsulta);
            this.grpPesquisa.Controls.Add(this.label2);
            this.grpPesquisa.Controls.Add(this.label1);
            this.grpPesquisa.Controls.Add(this.txtNomeConsulta);
            this.grpPesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.grpPesquisa.Location = new System.Drawing.Point(25, 18);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(633, 92);
            this.grpPesquisa.TabIndex = 1;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Consultar Morador";
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
            // txtDataNascimentoConsulta
            // 
            this.txtDataNascimentoConsulta.Location = new System.Drawing.Point(243, 43);
            this.txtDataNascimentoConsulta.Mask = "00/00/0000";
            this.txtDataNascimentoConsulta.Name = "txtDataNascimentoConsulta";
            this.txtDataNascimentoConsulta.Size = new System.Drawing.Size(130, 23);
            this.txtDataNascimentoConsulta.TabIndex = 2;
            this.txtDataNascimentoConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome completo";
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(7, 43);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(204, 23);
            this.txtNomeConsulta.TabIndex = 0;
            // 
            // dgvAreaDeLazer
            // 
            this.dgvAreaDeLazer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaDeLazer.Location = new System.Drawing.Point(12, 133);
            this.dgvAreaDeLazer.Name = "dgvAreaDeLazer";
            this.dgvAreaDeLazer.Size = new System.Drawing.Size(675, 251);
            this.dgvAreaDeLazer.TabIndex = 0;
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
            this.groupBoxCadastrar.Controls.Add(this.btnExcluirMorador);
            this.groupBoxCadastrar.Controls.Add(this.btnAtualizarMorador);
            this.groupBoxCadastrar.Controls.Add(this.btnExibirImagem);
            this.groupBoxCadastrar.Controls.Add(this.btnInserirMorador);
            this.groupBoxCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxCadastrar.Location = new System.Drawing.Point(23, 19);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(631, 336);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Cadastrar Área de Lazer";
            // 
            // groupBoxDadosAreaDeLazer
            // 
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label3);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtDescricao);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label9);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.label4);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtCodigo);
            this.groupBoxDadosAreaDeLazer.Controls.Add(this.txtNome);
            this.groupBoxDadosAreaDeLazer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDadosAreaDeLazer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxDadosAreaDeLazer.Location = new System.Drawing.Point(173, 33);
            this.groupBoxDadosAreaDeLazer.Name = "groupBoxDadosAreaDeLazer";
            this.groupBoxDadosAreaDeLazer.Size = new System.Drawing.Size(442, 233);
            this.groupBoxDadosAreaDeLazer.TabIndex = 18;
            this.groupBoxDadosAreaDeLazer.TabStop = false;
            this.groupBoxDadosAreaDeLazer.Text = "Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(23, 103);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(372, 112);
            this.txtDescricao.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome*";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(24, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 46);
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
            // btnExcluirMorador
            // 
            this.btnExcluirMorador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnExcluirMorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirMorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirMorador.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluirMorador.ForeColor = System.Drawing.Color.White;
            this.btnExcluirMorador.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirMorador.Image")));
            this.btnExcluirMorador.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExcluirMorador.Location = new System.Drawing.Point(335, 285);
            this.btnExcluirMorador.Name = "btnExcluirMorador";
            this.btnExcluirMorador.Size = new System.Drawing.Size(152, 40);
            this.btnExcluirMorador.TabIndex = 16;
            this.btnExcluirMorador.Text = " Excluir";
            this.btnExcluirMorador.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarMorador
            // 
            this.btnAtualizarMorador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.btnAtualizarMorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizarMorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarMorador.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAtualizarMorador.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarMorador.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarMorador.Image")));
            this.btnAtualizarMorador.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAtualizarMorador.Location = new System.Drawing.Point(173, 285);
            this.btnAtualizarMorador.Name = "btnAtualizarMorador";
            this.btnAtualizarMorador.Size = new System.Drawing.Size(152, 40);
            this.btnAtualizarMorador.TabIndex = 15;
            this.btnAtualizarMorador.Text = "  Atualizar";
            this.btnAtualizarMorador.UseVisualStyleBackColor = false;
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
            this.btnExibirImagem.Click += new System.EventHandler(this.btnExibirImagem_Click);
            // 
            // btnInserirMorador
            // 
            this.btnInserirMorador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.btnInserirMorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserirMorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirMorador.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInserirMorador.ForeColor = System.Drawing.Color.White;
            this.btnInserirMorador.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirMorador.Image")));
            this.btnInserirMorador.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInserirMorador.Location = new System.Drawing.Point(11, 285);
            this.btnInserirMorador.Name = "btnInserirMorador";
            this.btnInserirMorador.Size = new System.Drawing.Size(152, 40);
            this.btnInserirMorador.TabIndex = 14;
            this.btnInserirMorador.Text = " Inserir";
            this.btnInserirMorador.UseVisualStyleBackColor = false;
            this.btnInserirMorador.Click += new System.EventHandler(this.btnInserirMorador_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAreaDeLazer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 444);
            this.Controls.Add(this.tblCtrlMorador);
            this.Name = "FrmAreaDeLazer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAreaDeLazer";
            this.Load += new System.EventHandler(this.FrmAreaDeLazer_Load);
            this.tblCtrlMorador.ResumeLayout(false);
            this.tabMoradorConsulta.ResumeLayout(false);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaDeLazer)).EndInit();
            this.tabMoradorCadastro.ResumeLayout(false);
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxDadosAreaDeLazer.ResumeLayout(false);
            this.groupBoxDadosAreaDeLazer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAreaDeLazer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tblCtrlMorador;
        private System.Windows.Forms.TabPage tabMoradorConsulta;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtDataNascimentoConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.DataGridView dgvAreaDeLazer;
        private System.Windows.Forms.TabPage tabMoradorCadastro;
        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.Button btnExcluirMorador;
        private System.Windows.Forms.Button btnAtualizarMorador;
        private System.Windows.Forms.Button btnInserirMorador;
        private System.Windows.Forms.Button btnExibirImagem;
        private System.Windows.Forms.PictureBox picAreaDeLazer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxDadosAreaDeLazer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
    }
}