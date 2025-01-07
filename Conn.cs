using System;

namespace SqlServerC
{

    public class Conn
    {
        private string server = "MySQL80";
        private string database = "db_melodicca";
        private string user = "root";
        private string senha = "1234";

        public static string StrCon
        {
            get
            {
                return $"Data Source ={server}; Integrated Security= False; Initial Catalog = {database};" +
                    $"User ID = {user}; Password = {senha};";
            }
        }
    }
}
