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
    public partial class FrmBusca : Form
    {
        public FrmBusca()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNome.Text = "";
            txtBoxIdade.Text = "";
            txtBoxSenha.Text = "";
            txtBoxId.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Você deseja realmente sair da aplicação ?", "Você esta prestes a sair da aplicação.", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
