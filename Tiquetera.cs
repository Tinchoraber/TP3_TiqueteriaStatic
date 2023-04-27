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
    public static List<string> estadisticasTiquetera()
    {
        int cantidadInscriptos = DicClientes.Count();
        ListaEstadisticasTiquetera.Add("La cantidad de inscriptos es: " + cantidadInscriptos);
    }
}