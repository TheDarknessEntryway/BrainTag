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

namespace Form1
{
    public partial class buscarAlunos : Form
    {
        public buscarAlunos()
        {
            InitializeComponent();
        }

        int idFuncionario;

        private void button1_Click(object sender, EventArgs e)

        {
            string sql = "SELECT * FROM Funcionario WHERE nome LIKE '%" + txtNomeAluno.Text + "%' ORDER BY idFuncionario DESC ";
            listarAlunos(sql);
        }

       private void listarAlunos (string sql)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=braintag.mssql.somee.com;Database=braintag;User Id=DiogoCaxiado_SQLLogin_1;Password=auxuuds7cz;";
            //Adaptor de dados que buscará os dados e organizará para enviar para o grid
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            //Objeto de coleção de dados que será utilizado para "espelhar" os dados no grid
            DataSet ds = new DataSet();

            //O adaptador abrirá a conexão, executará o comando de busca, preencherá o dataset e encerrará a conexão
            adapter.Fill(ds);

            //Vínculando o grid a uma fonte de dados
            gridBuscarAlunos.DataSource = ds.Tables[0];



        }

        private void gridBuscarAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluirAlunos.Enabled = true;
            idFuncionario = Convert.ToInt32(gridBuscarAlunos.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnExcluirAlunos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Aviso!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //criando o objeto de conexão com banco de dados
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=braintag.mssql.somee.com;Database=braintag;User Id=DiogoCaxiado_SQLLogin_1;Password=auxuuds7cz;";

                //criando o objeto de comando de SQL para enviar instruções para o banco de dados
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //ligando o comando a conexão que configurada acima
                cmd.CommandText = "pdFuncionario";
                cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

                //vincular os campos do formulários aos parâmetros do procedimento
                cmd.Parameters.AddWithValue("idFuncionario", txtNomeAluno.Text);

                connection.Open();
                cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
                connection.Close();

                MessageBox.Show("Aluno excluído com sucesso!");

                string sql = "SELECT * FROM Funcionario WHERE nome LIKE '%" + txtNomeAluno.Text + "%' ORDER BY idFuncionario DESC ";
                listarAlunos(sql);
            }
        }

        private void buscarAlunos_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Funcionario WHERE nome LIKE '%" + txtNomeAluno.Text + "%' ORDER BY idFuncionario DESC ";
            listarAlunos(sql);
        }

       
        }
    }       

