﻿using Condominio.DeskTop.Formularios.Fornecedor;
using Condominio.DeskTop.Formularios.Morador;
using System.Windows.Forms;

namespace Condominio.DeskTop.Formularios.MasterPage
{
    public partial class FrmMaster : Form
    {
        public FrmMaster()
        {
            InitializeComponent();
        }


        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var resultado = MessageBox.Show(@"Deseja sair da Aplicação?", @"Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void moradoresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmMorador = new FrmMorador { MdiParent = this };
            frmMorador.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmFornecedor = new FrmFornecedor() { MdiParent = this };
            frmFornecedor.Show();
        }
    }
}
