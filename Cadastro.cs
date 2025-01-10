using System;
using System.Windows;
using MySql.Data.MySqlClient;
using SqlServerC;


namespace aula1_oláMundo
{
    internal class Cadastro
    {
        private int id;
        private string nome = "";
        private string email = "";
        private string cpf = "";
        private string endereco = "";

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        // Cadastro de funcionários no banco de dados
        public bool Cadastrar_funcionarios()
        {
            try
            {
                //manda os comandos direto com o banco de dados
                MySqlConnection mySqlConnetion = new MySqlConnection(Conn.bancoServidor);
                mySqlConnetion.Open();
                 
                string insert = $"INSERT INTO tb_cliente(cliente_nome,cliente_email, cliente_cpf,cliente_endereco) " +
                                $"VALUE('{Nome}','{Email}',{CPF} ,'{Endereco}')";

                MySqlCommand comandoSql = new MySqlCommand();
                comandoSql.CommandText = insert;
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch(Exception erro)
            {
                //Mensagem de erro quando não conseguir cadastrar os funcionários
                //Erro ligado ao banco de dados
                MessageBox.Show($"Erro no banco de dados - método cadastrarFuncionarios: {erro.Message}");
                return false;
            }
        }
    }
}
