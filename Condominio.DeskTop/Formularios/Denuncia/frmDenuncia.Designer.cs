namespace Condominio.DeskTop.Formularios.Denuncia
{
    partial class FrmDenuncia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDenuncia));
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.ckbAnonimo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picDenuncia = new System.Windows.Forms.PictureBox();
            this.btnExibirImagem = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxCadastrar.SuspendLayout();
            this.groupBoxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDenuncia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCadastrar
            // 
            this.groupBoxCadastrar.Controls.Add(this.groupBoxDados);
            this.groupBoxCadastrar.Controls.Add(this.picDenuncia);
            this.groupBoxCadastrar.Controls.Add(this.btnExibirImagem);
            this.groupBoxCadastrar.Controls.Add(this.btnEnviar);
            this.groupBoxCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxCadastrar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(677, 401);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Cadastrar Denúncias";
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.ckbAnonimo);
            this.groupBoxDados.Controls.Add(this.label8);
            this.groupBoxDados.Controls.Add(this.txtEmail);
            this.groupBoxDados.Controls.Add(this.txtCelular);
            this.groupBoxDados.Controls.Add(this.label6);
            this.groupBoxDados.Controls.Add(this.label3);
            this.groupBoxDados.Controls.Add(this.txtDescricao);
            this.groupBoxDados.Controls.Add(this.label4);
            this.groupBoxDados.Controls.Add(this.txtNome);
            this.groupBoxDados.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxDados.Location = new System.Drawing.Point(173, 33);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(478, 297);
            this.groupBoxDados.TabIndex = 18;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados";
            // 
            // ckbAnonimo
            // 
            this.ckbAnonimo.AutoSize = true;
            this.ckbAnonimo.Location = new System.Drawing.Point(24, 24);
            this.ckbAnonimo.Name = "ckbAnonimo";
            this.ckbAnonimo.Size = new System.Drawing.Size(75, 19);
            this.ckbAnonimo.TabIndex = 19;
            this.ckbAnonimo.Text = "Anônimo";
            this.ckbAnonimo.UseVisualStyleBackColor = true;
            this.ckbAnonimo.Click += new System.EventHandler(this.ckbAnonimo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "E-mail*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(423, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(243, 74);
            this.txtCelular.Mask = "(00)00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(204, 23);
            this.txtCelular.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefone Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(24, 180);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(423, 102);
            this.txtDescricao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 23);
            this.txtNome.TabIndex = 0;
            // 
            // picDenuncia
            // 
            this.picDenuncia.Image = ((System.Drawing.Image)(resources.GetObject("picDenuncia.Image")));
            this.picDenuncia.Location = new System.Drawing.Point(11, 33);
            this.picDenuncia.Name = "picDenuncia";
            this.picDenuncia.Size = new System.Drawing.Size(138, 126);
            this.picDenuncia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDenuncia.TabIndex = 17;
            this.picDenuncia.TabStop = false;
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
            this.btnExibirImagem.Text = "   Imagem";
            this.btnExibirImagem.UseVisualStyleBackColor = false;
            this.btnExibirImagem.Click += new System.EventHandler(this.btnExibirImagem_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEnviar.Location = new System.Drawing.Point(465, 347);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(186, 48);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = " Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 444);
            this.Controls.Add(this.groupBoxCadastrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDenuncia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denúncia";
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDenuncia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox picDenuncia;
        private System.Windows.Forms.Button btnExibirImagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbAnonimo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxDados;
    }
}