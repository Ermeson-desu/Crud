using System;
using System.Windows;
using MySql.Data.MySqlClient;
using SqlServerC;


namespace aula1_oláMundo
{
     class Cadastro
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


        // Retorna uma conexão com o banco de dados MySQL
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(Conn.bancoServidor);
        }

        // Cadastro de funcionários no banco de dados
        public bool Cadastrar_funcionarios()
        {
            
            try
            {
                //manda os comandos direto com o banco de dados
                using (var connection = GetConnection())
                {
                    connection.Open();

                    //insert é o comando do database em Sql para inserir os valores na tabela
                    string insert = $"INSERT INTO tb_cliente(cliente_nome,cliente_email, cliente_cpf,cliente_endereco) " +
                                    $"VALUE('{Nome}','{Email}','{CPF}' ,'{Endereco}');";

                    MySqlCommand comandoSql = new MySqlCommand(insert,connection);
                    comandoSql.CommandText = insert;
                    comandoSql.ExecuteNonQuery();

                    return true;
                }
            }
            catch (MySqlException erro)
            {
                //Mensagem de erro quando não conseguir cadastrar os funcionários
                //Erro ligado ao banco de dados
                MessageBox.Show($"Erro no banco de dados - método cadastrarFuncionarios: {erro.Message}");
                return false;
            }
        }
    }
}
