namespace Condominio.DeskTop.Formularios.Senha.AlterarSenha
{
    partial class FrmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarSenha));
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaAnterior = new System.Windows.Forms.TextBox();
            this.groupBoxCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCadastrar
            // 
            this.groupBoxCadastrar.Controls.Add(this.txtNovaSenha);
            this.groupBoxCadastrar.Controls.Add(this.btnAtualizar);
            this.groupBoxCadastrar.Controls.Add(this.label8);
            this.groupBoxCadastrar.Controls.Add(this.txtConfirmarSenha);
            this.groupBoxCadastrar.Controls.Add(this.label5);
            this.groupBoxCadastrar.Controls.Add(this.label3);
            this.groupBoxCadastrar.Controls.Add(this.txtSenhaAnterior);
            this.groupBoxCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxCadastrar.Location = new System.Drawing.Point(2, 24);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(263, 276);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Alterar Senha";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(27, 118);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(204, 23);
            this.txtNovaSenha.TabIndex = 4;
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
            this.btnAtualizar.Location = new System.Drawing.Point(-7, 222);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(273, 48);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "  Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(27, 169);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(204, 23);
            this.txtConfirmarSenha.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nova Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha Anterior*";
            // 
            // txtSenhaAnterior
            // 
            this.txtSenhaAnterior.Location = new System.Drawing.Point(27, 61);
            this.txtSenhaAnterior.Name = "txtSenhaAnterior";
            this.txtSenhaAnterior.PasswordChar = '*';
            this.txtSenhaAnterior.Size = new System.Drawing.Size(204, 23);
            this.txtSenhaAnterior.TabIndex = 2;
            // 
            // FrmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 299);
            this.Controls.Add(this.groupBoxCadastrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaAnterior;
    }
}