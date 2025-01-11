using System;
using System.Windows;

namespace SqlServerC
{

    public class Conn
    {
          private const string server = @"localhost";
          private const string database = "db_crud";
          private const string user = "root";
          private const string senha = "";
          private const string port = "3306";
        
          //conexão com o banco de dados 
          static public string bancoServidor = $"Server={server};port={port};User ID={user};Password={senha}; Database={database};";

    }
}
