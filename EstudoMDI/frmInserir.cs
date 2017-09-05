using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EstudoMDI
{
    public partial class frmInserir : Form
    {
        public frmInserir()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNome.Text = "";
            txtBoxIdade.Text = "";
            txtBoxSenha.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Você deseja realmente sair da aplicação ?", "Você esta prestes a sair da aplicação.", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void btnInserir_Click(object sender, EventArgs e)
        {
            //String de Conexão
            string stringsqlconexao = "Data Source = SYSTEM\\HAELSERVER; Initial Catalog = MDIestudo; Integrated Security = True";
            //Define a query sql como vazia
            string querySQL = null;

            //define comandos sql como vazio para posterior alimentação
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                querySQL = "INSERT INTO usuario(nomes,senha,idade)VALUES('" + txtBoxNome.Text + "','" + txtBoxSenha.Text + "'," + txtBoxIdade.Text + ")";

                //PREPARA A CONEXAO
                conexao = new SqlConnection(stringsqlconexao);

                //PREPARA A QUERY A SER EXECUTADA NO BANCO
                comando = new SqlCommand(querySQL, conexao);

                //ABRE A CONEXAO
                conexao.Open();

                //EXECUTA QUERY NO BANCO
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
                MessageBox.Show("" + err + "", "");
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
    }
}

        

        
    
