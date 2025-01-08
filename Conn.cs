using System;
using System.Windows;
using System.Data.SqlClient;

namespace SqlServerC
{

    public class Conn
    {
        private string server = "MySQL80";
        private string database = "db_melodicca";
        private string user = "root";
        private string senha = "1234";
        private const string server = "melodiccaConections";
        private const string database = "db_crud";
        private const string user = "root";
        private const string senha = "1234";

        public static string StrCon
        {
            get
            {
                return $"Data Source ={server}; Integrated Security= False; Initial Catalog = {database};" +
                    $"User ID = {user}; Password = {senha};";
            }
        }
        //conexão com o banco de dados 
        static public string bancoServidor = $"server = {server}; database = {database}; user id = {user}; password = {senha}";
        
    }
}
