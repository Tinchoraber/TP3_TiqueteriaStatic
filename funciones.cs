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
}