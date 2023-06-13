class Observador: IObservador
{
    private string nombre;
    private Sujeto sujeto;

    public Observador(string pNombre, Sujeto pSujeto)
    {
        nombre = pNombre;
        sujeto = pSujeto;
        sujeto.Suscribir(this);
    }

    //Este metodo es usado por el sujeto en actualizar

    public void Actualizar(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Actualizar, {0}-{1}", nombre, mensaje);
    }

    
}