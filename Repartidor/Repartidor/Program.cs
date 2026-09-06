public class Repartidor
{
    private int codigo;
    private string nombre;
    private string telefono;
    private string licencia;
    private string estado;
    private int entregasRealizadas;
    private double calificacion;

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    public string Licencia
    {
        get { return licencia; }
        set { licencia = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public int EntregasRealizadas
    {
        get { return entregasRealizadas; }
        set { entregasRealizadas = value; }
    }

    public double Calificacion
    {
        get { return calificacion; }
        set { calificacion = value; }
    }

    public Repartidor()
    {
        estado = "Disponible";
        entregasRealizadas = 0;
        calificacion = 0;
    }

    public Repartidor(int codigo, string nombre, string telefono,
                      string licencia)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.telefono = telefono;
        this.licencia = licencia;
        estado = "Disponible";
        entregasRealizadas = 0;
        calificacion = 0;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Teléfono: " + Telefono);
        Console.WriteLine("Licencia: " + Licencia);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Entregas realizadas: " + EntregasRealizadas);
        Console.WriteLine("Calificación: " + Calificacion);
    }
}