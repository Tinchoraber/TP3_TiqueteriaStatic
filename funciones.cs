public static class Funciones
{
    public static int ingresarNumero(string msj)
    {
        int devolver;
        Console.WriteLine(msj);
        devolver = int.Parse(Console.ReadLine());
        while(devolver < 1 && devolver > 5 )
        {
            Console.WriteLine("Numero mal ingresado, volve a hacerlo");
            Console.WriteLine(msj);
            devolver = int.Parse(Console.ReadLine());
        }
        return devolver;
    }
    public static int ingresarDni(string msj)
    {
        int dni;
        Console.WriteLine(msj);
        dni = int.Parse(Console.ReadLine());
        while(dni < 0)
        {
            Console.WriteLine("Dni, mal ingresado");
            Console.WriteLine(msj);
            dni = int.Parse(Console.ReadLine());
        }
        return dni;
    }
    public static string ingresarTexto(string msj)
    {
        string devolver;
        Console.WriteLine(msj);
        devolver = Console.ReadLine();
        while(devolver == "")
        {
            Console.WriteLine("Error, datos mal ingresados, volve a hacerlo");
            Console.WriteLine(msj);
            devolver = Console.ReadLine();
        }
        return devolver;
    }
    public static DateTime ingresarFecha(string msj)
    {
        DateTime fecha;
        string fechaString = ingresarTexto(msj);
        bool pude = DateTime.TryParse(fechaString, out fecha);
        while(pude != true)
        {
            fechaString = ingresarTexto(msj);
            pude = DateTime.TryParse(fechaString, out fecha);
        }
        return fecha;
    }
    public static int ingresarTipoEntrada(string msj)
    {
        int tipo;
        Console.WriteLine(msj);
        tipo = int.Parse(Console.ReadLine());
        while(tipo < 1 && tipo > 4)
        {
            Console.WriteLine("Error, datos mal ingresados, volve a hacerlo");
            Console.WriteLine(msj);
            tipo = int.Parse(Console.ReadLine());
        }
        return tipo;
    }
    public static int calcularTotal(int tipo)
    {
        int total = 0;
        switch(tipo)
        {
            case 1:
            total = 15000;
            break;

            case 2: 
            total = 30000;
            break;

            case 3:
            total = 10000;
            break;

            case 4:
            total = 40000;
            break;
        }
        return total;
    }
    public static int ingresarIdEntrada(string msj)
    {
        int id;
        Console.WriteLine(msj);
        id = int.Parse(Console.ReadLine());
        while(id < 0)
        {
            Console.WriteLine("Datos erroneos, volve a ingresarlo");
            Console.WriteLine(msj);
            id = int.Parse(Console.ReadLine());
        }
        return id;
    }
}