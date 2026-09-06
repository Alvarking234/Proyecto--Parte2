public class Paquete
{
    private int codigo;
    private string descripcion;
    private double peso;
    private double valorDeclarado;
    private string direccionOrigen;
    private string direccionDestino;
    private string estado;
    private string tipo;

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    public double ValorDeclarado
    {
        get { return valorDeclarado; }
        set { valorDeclarado = value; }
    }

    public string DireccionOrigen
    {
        get { return direccionOrigen; }
        set { direccionOrigen = value; }
    }

    public string DireccionDestino
    {
        get { return direccionDestino; }
        set { direccionDestino = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public Paquete()
    {
        estado = "Disponible";
    }

    public Paquete(int codigo, string descripcion, double peso,
                   double valorDeclarado, string direccionOrigen,
                   string direccionDestino, string tipo)
    {
        this.codigo = codigo;
        this.descripcion = descripcion;
        this.peso = peso;
        this.valorDeclarado = valorDeclarado;
        this.direccionOrigen = direccionOrigen;
        this.direccionDestino = direccionDestino;
        this.tipo = tipo;
        estado = "Disponible";
    }

    public virtual double CalcularTarifa(double distancia)
    {
        return distancia * 5;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Peso: " + Peso + " kg");
        Console.WriteLine("Valor declarado: Q" + ValorDeclarado);
        Console.WriteLine("Origen: " + DireccionOrigen);
        Console.WriteLine("Destino: " + DireccionDestino);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Tipo: " + Tipo);
    }
}