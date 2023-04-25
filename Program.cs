int numero;
Cliente cliente = new Cliente();
do
{
    Console.WriteLine("1. Nueva Inscripción: ");
    Console.WriteLine("2. Obtener estadísticas del Evento.");
    Console.WriteLine("3. Buscar Cliente. ");
    Console.WriteLine("4. Cambiar entrada de un Cliente. ");
    numero = Funciones.ingresarNumero("Ingrese su numero, tiene que ser entre 1 a 5");
    switch(numero)
    {
        case 1:
           cliente = nuevaInscripcion();
        break;

        case 2:

        break;

        case 3:

        break;

        case 4:

        break;
    }
}while(numero != 5);
    Cliente nuevaInscripcion()
    {
        int Dni = Funciones.ingresarDni("Ingrese su dni");
        string nombre = Funciones.ingresarTexto("Ingrese su nombre");
        string apellido = Funciones.ingresarTexto("Ingrese su apellido");
    }