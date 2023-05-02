public static class Tiquetera
{
    private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente>();
    private static int UltimoIdEntrada = 0;
    private static List<string> ListaEstadisticasTiquetera = new List<string>();

    public static int devolverUltimoIdEntrada()
    {
        return UltimoIdEntrada;
    }
    public static int agregarCliente(Cliente cliente1)
    {
        UltimoIdEntrada++;
        Console.WriteLine("Su id de de entrada es " + UltimoIdEntrada);
        DicClientes.Add(UltimoIdEntrada, cliente1);
        return UltimoIdEntrada;
    }
    public static Cliente buscarClienteClase(int idEntrada)
    {
        bool existe = DicClientes.ContainsKey(idEntrada);
        if (existe == true)
        {
            return DicClientes[idEntrada];

        }
        else
        {
            return new Cliente();
        }
    }
    public static bool cambiarEntrada(int idEntrada, int nuevoTipoEntrada, DateTime fecha)
    {
        bool pudo = false;
        if (Funciones.calcularTotal(nuevoTipoEntrada) < DicClientes[idEntrada].TotalAbonado)
        {
            pudo = true;
            DicClientes[idEntrada].TipoEntrada = nuevoTipoEntrada;
            DicClientes[idEntrada].TotalAbonado = Funciones.calcularTotal(nuevoTipoEntrada);
            DicClientes[idEntrada].FechaInscripcion = fecha;
        }
        else
        {
            pudo = false;
        }
        return pudo;
    }
    public static List<string> estadisticasTiquetera(int cantTipoEntrada1, int cantTipoEntrada2, int cantTipoEntrada3, int cantTpoEntrada4)
    {
        int cantidadInscriptos = DicClientes.Count();
        ListaEstadisticasTiquetera.Add("La cantidad de inscriptos es: " + cantidadInscriptos);
        double porcentaje = Funciones.calcularTipoEntrada(cantTipoEntrada1, cantidadInscriptos);
        double porcentaje2 = Funciones.calcularTipoEntrada(cantTipoEntrada2, cantidadInscriptos);
        double porcentaje3 = Funciones.calcularTipoEntrada(cantTipoEntrada3, cantidadInscriptos);
        double porcentaje4 = Funciones.calcularTipoEntrada(cantTpoEntrada4, cantidadInscriptos);
        ListaEstadisticasTiquetera.Add("El porcentaje de entradas de tipo 1 es: " + porcentaje + "%");
        ListaEstadisticasTiquetera.Add("El porcentaje de entradas de tipo 2 es: " + porcentaje2 + "%");
        ListaEstadisticasTiquetera.Add("El porcentaje de entradas de tipo 3 es: " + porcentaje3 + "%");
        ListaEstadisticasTiquetera.Add("El porcentaje de entradas de tipo 4 es: " + porcentaje4 + "%");
        int totalEntrada1 = Funciones.calcularTotalEntradas(15000, cantTipoEntrada1);
        int totalEntrada2 = Funciones.calcularTotalEntradas(30000, cantTipoEntrada2);
        int totalEntrada3 = Funciones.calcularTotalEntradas(10000, cantTipoEntrada3);
        int totalEntrada4 = Funciones.calcularTotalEntradas(40000, cantTpoEntrada4);
        ListaEstadisticasTiquetera.Add("La recaudacion de las entradas de tipo 1 es: " + totalEntrada1);
        ListaEstadisticasTiquetera.Add("La recaudacion de las entradas de tipo 2 es: " + totalEntrada2);
        ListaEstadisticasTiquetera.Add("La recaudacion de las entradas de tipo 3 es: " + totalEntrada3);
        ListaEstadisticasTiquetera.Add("La recaudacion de las entradas de tipo 4 es: " + totalEntrada4);
        int recaudacionTotal = Funciones.calcularRecaudacionTotal(totalEntrada1, totalEntrada2, totalEntrada3, totalEntrada4);
        ListaEstadisticasTiquetera.Add("La recaudacion toatl es: " + recaudacionTotal);
        return ListaEstadisticasTiquetera;
    }
}