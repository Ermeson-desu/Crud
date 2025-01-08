using System;
using System.Windows;
using System.Data.SqlClient;

namespace SqlServerC
{

    public class Conn
    {
        private const string server = "melodiccaConections";
        private const string database = "db_crud";
        private const string user = "root";
        private const string senha = "1234";
        
        //conexão com o banco de dados 
        static public string bancoServidor = $"server = {server}; database = {database}; user id = {user}; password = {senha}";
        
    }
}
