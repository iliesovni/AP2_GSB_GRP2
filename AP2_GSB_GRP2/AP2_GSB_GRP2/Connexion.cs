using AP2_GSB_GRP2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AP2_GSB_GRP2
{
    public class Connexion
    {
        private string serverName;
        private string database;
        private string connection_string;

        private SqlCommand _command;
        private SqlDataReader _reader;
        private SqlConnection connection;

        public Connexion(string serverName, string database)
            {
            this.serverName = serverName;
            this.database = database;
            this.connection_string = $@"Data Source={this.serverName};Initial Catalog={this.database};Integrated Security=True;MultipleActiveResultSets=True";
            this.connection = new SqlConnection(this.connection_string);
            this.connection.Open();
        }

        public SqlConnection getCo()
        {
            return this.connection;
        }

        public void Logout()
        {
            this.connection.Close();
        }
    }

}

