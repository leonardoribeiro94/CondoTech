namespace Condominio.DeskTop.Formularios.MasterPage
{
    partial class FrmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaster));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.áreaDeLazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.registosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.registosToolStripMenuItem,
            this.senhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moradoresToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.visitantesToolStripMenuItem1,
            this.toolStripSeparator3,
            this.áreaDeLazerToolStripMenuItem,
            this.toolStripSeparator1});
            this.cadastrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem.Image")));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // moradoresToolStripMenuItem
            // 
            this.moradoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moradoresToolStripMenuItem.Image")));
            this.moradoresToolStripMenuItem.Name = "moradoresToolStripMenuItem";
            this.moradoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moradoresToolStripMenuItem.Text = "Moradores";
            this.moradoresToolStripMenuItem.Click += new System.EventHandler(this.moradoresToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedorToolStripMenuItem.Image")));
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // visitantesToolStripMenuItem1
            // 
            this.visitantesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("visitantesToolStripMenuItem1.Image")));
            this.visitantesToolStripMenuItem1.Name = "visitantesToolStripMenuItem1";
            this.visitantesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.visitantesToolStripMenuItem1.Text = "Visitantes";
            this.visitantesToolStripMenuItem1.Click += new System.EventHandler(this.visitantesToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // áreaDeLazerToolStripMenuItem
            // 
            this.áreaDeLazerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("áreaDeLazerToolStripMenuItem.Image")));
            this.áreaDeLazerToolStripMenuItem.Name = "áreaDeLazerToolStripMenuItem";
            this.áreaDeLazerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.áreaDeLazerToolStripMenuItem.Text = "Área de Lazer";
            this.áreaDeLazerToolStripMenuItem.Click += new System.EventHandler(this.áreaDeLazerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // registosToolStripMenuItem
            // 
            this.registosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informativoToolStripMenuItem,
            this.visitantesToolStripMenuItem});
            this.registosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registosToolStripMenuItem.Image")));
            this.registosToolStripMenuItem.Name = "registosToolStripMenuItem";
            this.registosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.registosToolStripMenuItem.Text = "Registros";
            // 
            // informativoToolStripMenuItem
            // 
            this.informativoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informativoToolStripMenuItem.Image")));
            this.informativoToolStripMenuItem.Name = "informativoToolStripMenuItem";
            this.informativoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.informativoToolStripMenuItem.Text = "Informativos";
            // 
            // visitantesToolStripMenuItem
            // 
            this.visitantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitantesToolStripMenuItem.Image")));
            this.visitantesToolStripMenuItem.Name = "visitantesToolStripMenuItem";
            this.visitantesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.visitantesToolStripMenuItem.Text = "Historico de Visitas";
            // 
            // senhaToolStripMenuItem
            // 
            this.senhaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("senhaToolStripMenuItem.Image")));
            this.senhaToolStripMenuItem.Name = "senhaToolStripMenuItem";
            this.senhaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.senhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 641);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondoTech";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMaster_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem áreaDeLazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitantesToolStripMenuItem1;
    }
}

