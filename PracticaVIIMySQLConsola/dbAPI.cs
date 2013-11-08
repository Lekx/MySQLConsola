using System;
using MySql.Data.MySqlClient;

namespace PracticaVIIMySQLConsola
{
    class dbApi : conexionDb
    {
        //id, nombre, codigo, telefono, email

        public void mostrarInformacionDb()
        {
            this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("select * from clientes", myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                int id = Convert.ToInt32(myReader["id_cliente"]);
                string nombre = myReader["nombre"].ToString();
                int tel = Convert.ToInt32(myReader["telefono"]);

                Console.WriteLine("\nID: " + id + "  Nombre: " + nombre + "  Telefono: " + tel);
            }
        }
    }
}
