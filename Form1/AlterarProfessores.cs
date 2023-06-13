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
    public partial class Buscar_Professores : Form
    {
        public Buscar_Professores()
        {
            InitializeComponent();
        }

        private void Buscar_Professores_Load(object sender, EventArgs e)
        {

        }

        private void buscar()
        {
            //criando o objeto de conexão com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=braintag.mssql.somee.com;Database=braintag;User Id=DiogoCaxiado_SQLLogin_1;Password=auxuuds7cz;";

            //criando o objeto de comando de SQL para enviar instruções para o banco de dados
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection; //ligando o comando a conexão que configurada acima
            cmd.CommandText = "psUsuario";
            cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

            cmd.Parameters.AddWithValue("idUsuario", txtID.Text);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(); //executando o comando de busca no SQL e armazenando o resultado da busca em um leitor (matriz)

            if (reader.HasRows) //se o leitor tem linhas de dados
            {
                reader.Read(); //ler a próxima linha de dados

                //tipos de GET em C#

                //GetString = textos (VARCHAR)
                //GetDecimal = valores decimais (DECIMAL)
                //GetInt32 = números inteiros (INT)
                //GetInt64 = números inteiros (BIGINT)
                //GetDateTime = data (DATE, TIME ou DATETIME)

                txtNome.Text = reader.GetString(1);
                txtdtNascimento.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                txtCPF.Text = reader.GetDecimal(3).ToString();
                txtTipoUsuario.Text = reader.GetString(4);
                txtEmail.Text = reader.GetString(5);
                txtSenha.Text = reader.GetString(6);
            }

            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente atualizar?", "Aviso", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                //criando o objeto de conexão com banco de dados
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=braintag.mssql.somee.com;Database=braintag;User Id=DiogoCaxiado_SQLLogin_1;Password=auxuuds7cz;";

                //criando o objeto de comando de SQL para enviar instruções para o banco de dados
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //ligando o comando a conexão que configurada acima
                cmd.CommandText = "puUsuario";
                cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

                //vincular os campos do formulários aos parâmetros do procedimento
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("dtNascimento", Convert.ToDateTime(txtdtNascimento.Text));
                cmd.Parameters.AddWithValue("cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("tipoUsuario", txtTipoUsuario.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("idUsuario", txtID.Text);

                connection.Open();
                cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
                connection.Close();

                MessageBox.Show("Professor atualizado com sucesso.");
            }


        }

        private void labFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

  