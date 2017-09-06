using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //BUSCA E POPULA OS TEXTBOX COM O RESULTADO DA BUSCA

            string stringDeConexao = "Data Source = SYSTEM\\HAELSERVER; Initial Catalog = MDIestudo; Integrated Security = True";
            string QuerySQL = "";
            SqlConnection conexao = null;
            SqlCommand comando = null;
            SqlDataReader reader = null;

            try
            {
                //Montando a query para inserir na base
                //Repare nas aspas simples no campo varchar
                //e que não tem aspas simples no campo idade que e inteiro
                QuerySQL = "SELECT nome,senha,idade FROM usuario WHERE idUsuario=" + txtBoxId.Text;

                //PREPARA A CONEXAO
                conexao = new SqlConnection(stringDeConexao);

                //PREPARA A QUERY A SER EXECUTADA NO BANCO
                comando = new SqlCommand(QuerySQL, conexao);

                //ABRIR CONEXAO
                conexao.Open();

                //EXECUTAR QUERY NO BANCO
                reader = comando.ExecuteReader();


                // COMO SABERMOS QUE SÓ VEM UM REGISTRO DE NOSSO INTERESSE
                // USA-SE O IF, DO CONTRARIO USAR-SE IA UM LOOP (while por exemplo)
                if (reader.Read())
                {
                    txtBoxNome.Text = reader["nome"].ToString();
                    txtBoxSenha.Text = reader["senha"].ToString();
                    txtBoxIdade.Text = reader["idade"].ToString();
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
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
