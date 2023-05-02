using System.Collections.Generic;
int numero,tipoEntrada = 0, tipoEntrada1 = 0, tipoEntrada2 = 0, tipoEntrada3 = 0, tipoEntrada4 = 0, totalAbonado = 0;
Cliente cliente1 = new Cliente();
List<string> ListaEstadisticas = new List<string>();
do
{
    Console.WriteLine("1. Nueva Inscripción: ");
    Console.WriteLine("2. Obtener estadísticas del Evento.");
    Console.WriteLine("3. Buscar Cliente. ");
    Console.WriteLine("4. Cambiar entrada de un Cliente. ");
    Console.WriteLine("5, Salir");
    numero = Funciones.ingresarNumero("Ingrese su numero, tiene que ser entre 1 a 5");
    switch(numero)
    {
        case 1:
           cliente1 = nuevaInscripcion();
        break;

        case 2:
            obtenerEstadisticas(totalAbonado);
        break;

        case 3:
            buscarCliente();
        break;

        case 4:
            cambiarEntrada();
        break;
    }
}while(numero != 5);
    Cliente nuevaInscripcion()
    {
        int Dni = Funciones.ingresarDni("Ingrese su dni");
        string nombre = Funciones.ingresarTexto("Ingrese su nombre");
        string apellido = Funciones.ingresarTexto("Ingrese su apellido");
        DateTime fecha = Funciones.ingresarFecha("Ingrese la fecha de su inscripcion");
        tipoEntrada = Funciones.ingresarTipoEntrada("Ingrese el tipo de entrada, 1 es para dia 1, 2 es para el dia 2, 3 es para dia 3 y 4 es para el full pass");
        switch(tipoEntrada)
        {
            case 1: 
            tipoEntrada1++;
            break;

            case 2: 
            tipoEntrada2++;
            break;

            case 3:
            tipoEntrada3++;
            break;

            case 4: 
            tipoEntrada4++;
            break;
        }
        totalAbonado = Funciones.calcularTotal(tipoEntrada);
        cliente1 = new Cliente(Dni, nombre, apellido, fecha, tipoEntrada, totalAbonado);
        Tiquetera.agregarCliente(cliente1);
        return cliente1;
    }
    void obtenerEstadisticas(int totalAbonado)
    {
    ListaEstadisticas = Tiquetera.estadisticasTiquetera(tipoEntrada1, tipoEntrada2, tipoEntrada3, tipoEntrada4, totalAbonado);
    if(ListaEstadisticas[0] == "")
    {
        Console.WriteLine("No se anoto nadie");
    }
    else
    {
        for (int i = 0; i < ListaEstadisticas.Count(); i++)
        {
            Console.WriteLine(ListaEstadisticas[i]);
        }
    }
    }
    void buscarCliente()
    {
        int idEntrada = Funciones.ingresarIdEntrada("Ingrese el id de entrada");
        Cliente clienteBuscado = Tiquetera.buscarClienteClase(idEntrada);
        if(clienteBuscado.Nombre == "")
        {
            Console.WriteLine("No existe");
        }
        else
        {
            Console.WriteLine("El Dni es: " + clienteBuscado.DNI + " , el nombre es: " + clienteBuscado.Nombre + " , el apellido es: " + clienteBuscado.Apellido + ", la fecha de inscripcion fue: " + clienteBuscado.FechaInscripcion + " , el tipo de entrada es: " + clienteBuscado.TipoEntrada + " y el total abonado es: " + clienteBuscado.TotalAbonado);
        }
    }
    void cambiarEntrada()
    {
        int idEntrada = Funciones.ingresarIdEntrada("Ingrese el id de entrada");
        int nuevoTipoEntrada = Funciones.ingresarTipoEntrada("Ingrese un nuevo tipo de entrada");
        DateTime fechaNueva = Funciones.ingresarFecha("Ingrese la fecha de su inscripcion");
        bool pudo = Tiquetera.cambiarEntrada(idEntrada, nuevoTipoEntrada, fechaNueva);
    }