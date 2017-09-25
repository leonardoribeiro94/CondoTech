namespace Condominio.DeskTop.Formularios.Visitante.NovaVisita
{
    partial class FrmNovaVisita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovaVisita));
            this.tblCtrlNovaVisita = new System.Windows.Forms.TabControl();
            this.tabMoradorConsulta = new System.Windows.Forms.TabPage();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.dgvNovaVisita = new System.Windows.Forms.DataGridView();
            this.tabMoradorCadastro = new System.Windows.Forms.TabPage();
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbVisitante = new System.Windows.Forms.ComboBox();
            this.cmbMorador = new System.Windows.Forms.ComboBox();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tblCtrlNovaVisita.SuspendLayout();
            this.tabMoradorConsulta.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovaVisita)).BeginInit();
            this.tabMoradorCadastro.SuspendLayout();
            this.groupBoxCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCtrlNovaVisita
            // 
            this.tblCtrlNovaVisita.Controls.Add(this.tabMoradorConsulta);
            this.tblCtrlNovaVisita.Controls.Add(this.tabMoradorCadastro);
            this.tblCtrlNovaVisita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCtrlNovaVisita.Location = new System.Drawing.Point(0, 0);
            this.tblCtrlNovaVisita.Name = "tblCtrlNovaVisita";
            this.tblCtrlNovaVisita.SelectedIndex = 0;
            this.tblCtrlNovaVisita.Size = new System.Drawing.Size(701, 444);
            this.tblCtrlNovaVisita.TabIndex = 3;
            this.tblCtrlNovaVisita.Click += new System.EventHandler(this.tblCtrlVisitante_Click);
            // 
            // tabMoradorConsulta
            // 
            this.tabMoradorConsulta.Controls.Add(this.grpPesquisa);
            this.tabMoradorConsulta.Controls.Add(this.dgvNovaVisita);
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
            this.grpPesquisa.Text = "Consultar Visitas";
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
            this.txtNomeConsulta.Size = new System.Drawing.Size(335, 23);
            this.txtNomeConsulta.TabIndex = 0;
            this.txtNomeConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomeConsulta_KeyUp);
            // 
            // dgvNovaVisita
            // 
            this.dgvNovaVisita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNovaVisita.Location = new System.Drawing.Point(12, 133);
            this.dgvNovaVisita.Name = "dgvNovaVisita";
            this.dgvNovaVisita.RowTemplate.Height = 20;
            this.dgvNovaVisita.Size = new System.Drawing.Size(675, 251);
            this.dgvNovaVisita.TabIndex = 0;
            this.dgvNovaVisita.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNovaVisita_CellDoubleClick);
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
            this.groupBoxCadastrar.Controls.Add(this.label2);
            this.groupBoxCadastrar.Controls.Add(this.txtCodigo);
            this.groupBoxCadastrar.Controls.Add(this.cmbVisitante);
            this.groupBoxCadastrar.Controls.Add(this.cmbMorador);
            this.groupBoxCadastrar.Controls.Add(this.txtSaida);
            this.groupBoxCadastrar.Controls.Add(this.txtEntrada);
            this.groupBoxCadastrar.Controls.Add(this.label6);
            this.groupBoxCadastrar.Controls.Add(this.label5);
            this.groupBoxCadastrar.Controls.Add(this.label8);
            this.groupBoxCadastrar.Controls.Add(this.txtDescricao);
            this.groupBoxCadastrar.Controls.Add(this.label9);
            this.groupBoxCadastrar.Controls.Add(this.label4);
            this.groupBoxCadastrar.Controls.Add(this.btnAtualizar);
            this.groupBoxCadastrar.Controls.Add(this.btnInserir);
            this.groupBoxCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxCadastrar.Location = new System.Drawing.Point(29, 24);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(634, 364);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Cadastrar Visita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(11, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 23);
            this.txtCodigo.TabIndex = 26;
            // 
            // cmbVisitante
            // 
            this.cmbVisitante.FormattingEnabled = true;
            this.cmbVisitante.Location = new System.Drawing.Point(326, 101);
            this.cmbVisitante.Name = "cmbVisitante";
            this.cmbVisitante.Size = new System.Drawing.Size(282, 23);
            this.cmbVisitante.TabIndex = 25;
            // 
            // cmbMorador
            // 
            this.cmbMorador.FormattingEnabled = true;
            this.cmbMorador.Location = new System.Drawing.Point(11, 101);
            this.cmbMorador.Name = "cmbMorador";
            this.cmbMorador.Size = new System.Drawing.Size(282, 23);
            this.cmbMorador.TabIndex = 25;
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(161, 154);
            this.txtSaida.Mask = "00/00/0000 90:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(132, 23);
            this.txtSaida.TabIndex = 24;
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Location = new System.Drawing.Point(11, 154);
            this.txtEntrada.Mask = "00/00/0000 90:00";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(132, 23);
            this.txtEntrada.TabIndex = 24;
            this.txtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Horário de Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Horário de Saída";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(11, 207);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(598, 72);
            this.txtDescricao.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Morador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Visitante*";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(173, 293);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 40);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "  Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInserir.Location = new System.Drawing.Point(11, 293);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(152, 40);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = " Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FrmNovaVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 444);
            this.Controls.Add(this.tblCtrlNovaVisita);
            this.Name = "FrmNovaVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Visita";
            this.Load += new System.EventHandler(this.FrmNovaVisita_Load);
            this.tblCtrlNovaVisita.ResumeLayout(false);
            this.tabMoradorConsulta.ResumeLayout(false);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovaVisita)).EndInit();
            this.tabMoradorCadastro.ResumeLayout(false);
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tblCtrlNovaVisita;
        private System.Windows.Forms.TabPage tabMoradorConsulta;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.DataGridView dgvNovaVisita;
        private System.Windows.Forms.TabPage tabMoradorCadastro;
        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ComboBox cmbMorador;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.ComboBox cmbVisitante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}