internal class Program
{
    private static void Main(string[] args)
    {
        //Creamos el sujeto
        Sujeto miSujeto = new Sujeto("");
        //Creamos a los observadores
        Observador a = new Observador("MARIO", miSujeto);
        Observador b = new Observador("MARIA", miSujeto);
        Observador c = new Observador("MARCOS", miSujeto);

        //trabajamos
        for (int n = 0; n < 5; n++)
            miSujeto.Trabajo();

        //Alguien se sale de la lista
        /*Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-------- Alguien cancelo su suscripción -------");

        miSujeto.Desuscribir(a);
        //miSujeto.Desuscribir(b);
        //miSujeto.Desuscribir(c);

        for (int n = 0; n < 5; n++)
            miSujeto.Trabajo();*/
    }
}