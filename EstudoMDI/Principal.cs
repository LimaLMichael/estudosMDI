using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoMDI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

            

       

              
        private void inserirMenuStripCel_Click(object sender, EventArgs e)
        {
            frmInserir formInserir = new frmInserir();
            formInserir.MdiParent = this;
            formInserir.Show();
        }

        private void sairDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Você deseja realmente sair da aplicação ?", "Você esta prestes a sair da aplicação.", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void alterarMenuStripCel_Click(object sender, EventArgs e)
        {
            FrmAlterar formAlterar = new FrmAlterar();
            formAlterar.MdiParent = this;
            formAlterar.Show();
        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusca formBusca = new FrmBusca();
            formBusca.MdiParent= this;
            formBusca.Show();
        }

        private void deletarMenuStripCel_Click(object sender, EventArgs e)
        {
            frmDeletar formDeletar = new frmDeletar();
            formDeletar.MdiParent = this;
            formDeletar.Show();
        }
    }
}
