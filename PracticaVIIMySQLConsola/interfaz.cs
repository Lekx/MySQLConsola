using MySql.Data.MySqlClient;
using System;
using System.Data;


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
                Console.WriteLine("\t----------- [ Menu de Acciones para sus Registros ] ----------");
                Console.Write("\n    [1] Mostrar ]  [2] Agregar ]  [3] Editar ]  [4] Eliminar ]  [5] Salir ]\n\n\t\t\tNumero de la acción a Realizar: ");

                opcionSeleccionada = Console.ReadLine();
                if (opcionSeleccionada != "5") 
                { 
                    Console.WriteLine("\n\t----------- [ Procesamiento de Acción Solicitada ] -----------\n");
                    opcionesDelMenu(opcionSeleccionada);

                    Console.WriteLine("\n\n\n\tPresione cualquier tecla para regresar al menu de acciones");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (opcionSeleccionada != "5");
            this.mrBones();
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
            this.dbApi.mostrarDatosDb();
        }

        private void agregar()
        {
            string consulta = "INSERT INTO persona VALUES('',";

            Console.Write("\t\tNombre: ");
            consulta += "'" + Console.ReadLine() + "', ";
            Console.Write("\t\tCodigo: ");
            consulta += "'" + Console.ReadLine() + "', ";
            Console.Write("\t\tTelefono: ");
            consulta += "'" + Console.ReadLine() + "', ";
            Console.Write("\t\temail: ");
            consulta += "'" + Console.ReadLine() + "' )";

            this.dbApi.ejecutarConsulta(consulta);

        }


        private void editar()
        {
            this.dbApi.mostrarDatosDb();

            Console.Write("\n\tPor Favor escriba el id de la tupla a editar o \"c\" para cancelar: ");
            string entradaUsuario = Console.ReadLine();
            if (entradaUsuario == "c" || entradaUsuario == "C")
                return;
            else 
            {
                Console.Write("\n\tRealmente quiere editar la tupla con el id " + entradaUsuario + " (s para continuar):");
            string corroboracion = Console.ReadLine();

                if (corroboracion == "s" || corroboracion == "S") 
                { 
                    int entradaDeUsuario;
                    if (Int32.TryParse(entradaUsuario, out entradaDeUsuario))
                    {
                        if (this.dbApi.verificarExistencia(entradaDeUsuario)) 
                        {
                            string valores = "";
                            Console.WriteLine("\t\tEditando id: " + entradaDeUsuario);
                            Console.Write("\t\tNombre: ");
                            valores += "nombre='" + Console.ReadLine() + "', ";
                            Console.Write("\t\tCodigo: ");
                            valores += "codigo='" + Console.ReadLine() + "', ";
                            Console.Write("\t\tTelefono: ");
                            valores += "telefono='" + Console.ReadLine() + "', ";
                            Console.Write("\t\temail: ");
                            valores += "email='" + Console.ReadLine() + "'";

                            this.dbApi.ejecutarConsulta("UPDATE persona SET " + valores + " WHERE id=" + entradaDeUsuario);
                        }
                        else
                            Console.WriteLine("\n\t\tEl id ingresado no existe, verifiquelo.");
                    }
                    else
                        Console.WriteLine("\n\tVerifique el id que ingresó, solo se aceptan numeros enteros.");
                }
            }
        }

        private void eliminar()
        {
            this.dbApi.mostrarDatosDb();

            Console.Write("\n\tPor Favor escriba el id de la tupla a eliminar o \"c\" para cancelar: ");
            string entradaUsuario = Console.ReadLine();

            if (entradaUsuario == "c" || entradaUsuario == "C")
                return;
            else
            {
                Console.Write("\n\tRealmente quiere editar la tupla con el id " + entradaUsuario + " (s para continuar):");
            string corroboracion = Console.ReadLine();

                if (corroboracion == "s" || corroboracion == "S") 
                { 
                    int entradaDeUsuario;
                    if (Int32.TryParse(entradaUsuario, out entradaDeUsuario))
                    {
                        if (this.dbApi.verificarExistencia(entradaDeUsuario))
                            this.dbApi.ejecutarConsulta("DELETE FROM persona WHERE id=" + entradaDeUsuario);
                        else
                            Console.WriteLine("\n\t\tEl id ingresado no existe, verifiquelo.");
                    }
                    else
                        Console.WriteLine("\n\tVerifique el id que ingresó, solo se aceptan numeros enteros.");
                }
            }
        }

        private void mrBones()
        {
             Console.WriteLine("\n\n\n\t\t\tHasta pronto!\n\t\t\tPresione cualquier tecla finalizar...\n\t\t\t  /");
             Console.WriteLine("\t\t▄█████▄ /");
             Console.WriteLine("\t\t █▀█▀█");
             Console.WriteLine("\t\t ▀█▀█▀ █ ");
             Console.WriteLine("\t\t  ▀█▀  █ ");
             Console.WriteLine("\t\t█▀███▀▀▀");
             Console.WriteLine("\t\t▀▀███");
             Console.WriteLine("\t\t  █▀█");
             Console.WriteLine("\t\t  █ █");
             Console.WriteLine("\t\t ▄█ █▄");
        }

    }
}
