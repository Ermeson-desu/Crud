using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using SqlServerC;

namespace aula1_oláMundo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //manda os dados para o banco de dados
        private void butom_enviar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(Verificar_preenchimento())
                {
                    Cadastro cadFuncionario = new Cadastro();
                    cadFuncionario.Nome = txtbox_nome.Text;
                    cadFuncionario.Email = txtbox_email.Text;
                    cadFuncionario.CPF = txtbox_cpf.Text;
                    cadFuncionario.Endereco = txtbox_endereco.Text;

                    Verificar_cadastro(cadFuncionario);
                    Limpar_campos();
                }
                else
                {
                    MessageBox.Show("Por favor preencha todos os campos corretamente.");
                    Limpar_campos();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show($"Erro ao cadastra funcionário: {erro.Message}");
            }
        }


        //Verifica se o usuário preencheu corretamente todos os campos da planilha
        private bool Verificar_preenchimento()
        {
            return !txtbox_nome.Text.Equals("") && !txtbox_email.Text.Equals("") && 
                   !txtbox_cpf.Text.Equals("") && !txtbox_endereco.Text.Equals("")? true:false;
        }

        //limpa todos os campos e retorna para o campo do nome 
        private void Limpar_campos()
        {
            txtbox_nome.Clear();
            txtbox_email.Clear();
            txtbox_cpf.Clear();
            txtbox_endereco.Clear();
            txtbox_nome.Focus();
        }

        //dá um feedback ao usuário, se o cadastro foi bem sucedido ou não 
        private void Verificar_cadastro(Cadastro cadFuncionario)
        { 
            if (cadFuncionario.Cadastrar_funcionarios())
            {
                MessageBox.Show("Cadastrado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar, tente novamente.");
            }
        }
    }
}