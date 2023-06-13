class Sujeto
{
    private List<IObservador> observadores = new List<IObservador>();
    private string mensaje;
    private Random rnd = new Random();
    private int n;

    public int N { get => n; set => N  =value;}
    
    public Sujeto(string mensaje)
    {
        this.mensaje = mensaje;
    }


    public void Suscribir(IObservador suscrito)
    {
        //Lo adicionamos a la lista
        observadores.Add(suscrito);

    }

    public void Desuscribir(IObservador suscrito)
    {
        //Recomendable poner codigo de seguridad
        observadores.Remove(suscrito);
    }

    private void Notificar()
    {
       //Notificamos el muevo estado a todos los observadores que esten suscritos

       foreach(IObservador o in observadores)
       {
       o.Actualizar(mensaje);
       }

    }

    //Aqui simulamos el trabajo del observador y uncambio de estado que necesita ser notificado
    public void Trabajo()
    {
        n= rnd.Next(10);

        if(n%2==0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- Nuevo estado ---");
            mensaje = string.Format("El nuevo valor es {0}", n);
            Notificar();
        }
    }
    

}