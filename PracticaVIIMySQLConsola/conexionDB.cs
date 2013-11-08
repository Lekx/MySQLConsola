using System;
using MySql.Data.MySqlClient;

namespace PracticaVIIMySQLConsola
{
    class conexionDb
    {
        protected MySqlConnection myConnection;
        public conexionDb()
        {
        }

        protected void abrirConexion()
        {
            string connectionString =
                "Server=localhost;" +
                "Database=fabrica;" +
                "User ID= root;" +
                "Password=;" +
                "Pooling=false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }

        protected void cerrarConexion()
        {
            this.myConnection.Close();
            this.myConnection = null;
        }
    }
}
