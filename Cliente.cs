public class Cliente
{
    public int DNI{get; private set;}
    public string Nombre{get; private set;}
    public string Apellido{get; private set;}
    public DateTime FechaInscripcion{get; set;}
    public int TipoEntrada{get; set;}
    public int TotalAbonado{get;set;}
    public Cliente(int Dni, string nombre, string apellido, DateTime fecha, int tipoEntrada, int totalAbonado)
    {
        DNI = Dni;
        Nombre = nombre;
        Apellido = apellido;
        FechaInscripcion = fecha;
        TipoEntrada = tipoEntrada;
        TotalAbonado = totalAbonado;
    }
    public Cliente()
    {

    }
}