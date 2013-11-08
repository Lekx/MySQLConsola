using System;


namespace PracticaVIIMySQLConsola
{
    class Interfaz
    {

        protected dbApi dbApi = new dbApi();

        public void menu()
        {

            string opcionSeleccionada;

            do
            {
                Console.WriteLine("\t\t---------- [ Menu Principal ] ----------");
                Console.Write("\n\n\t\t[1] Mostrar todos     ]\n\t\t[2] Agregar Registro  ]\n\t\t[3] Editar Registro   ]\n\t\t[4] Eliminar Registro ]\n\t\t[5] Salir\t      ]\n\n\t\tNumero de la acción a Realizar: ");

                opcionSeleccionada = Console.ReadLine();
                opcionesDelMenu(opcionSeleccionada);

                Console.ReadKey();
                Console.Clear();

            }
            while (opcionSeleccionada != "5");
        }


        private void opcionesDelMenu(string opcionSeleccionada)
        {


            switch (opcionSeleccionada)
            {
                case "1": mostrar();
                    break;
                case "2": agregar();
                    break;
                case "3": editar();
                    break;
                case "4": eliminar();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("\n\t\tError!!\n\t\tPor favor haga una elección valida acorde a un número del menú");
                    break;
            }

        }


        private void mostrar()
        {
            Console.WriteLine("\n\t\tMostrar datos MySQL\n\n");
            this.dbApi.mostrarInformacionDb();
        }

        private void agregar()
        {
            Console.WriteLine("\n\t\tAgregar datos MySQL");

        }

        private void editar()
        {
            Console.WriteLine("\n\t\tEditar datos MySQL");
        }
        private void eliminar()
        {
            Console.WriteLine("\n\t\tEliminar datos MySQL");
        }


    }
}
