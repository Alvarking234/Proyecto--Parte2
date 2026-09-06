public class Vehiculo
{
    private int codigo;
    private string placa;
    private string marca;
    private string modelo;
    private double capacidad;
    private string estado;
    private double costoOperativo;

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Placa
    {
        get { return placa; }
        set { placa = value; }
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public double Capacidad
    {
        get { return capacidad; }
        set { capacidad = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public double CostoOperativo
    {
        get { return costoOperativo; }
        set { costoOperativo = value; }
    }

    public Vehiculo()
    {
        estado = "Disponible";
    }

    public Vehiculo(int codigo, string placa, string marca,
                    string modelo, double capacidad,
                    double costoOperativo)
    {
        this.codigo = codigo;
        this.placa = placa;
        this.marca = marca;
        this.modelo = modelo;
        this.capacidad = capacidad;
        this.costoOperativo = costoOperativo;
        estado = "Disponible";
    }

    public virtual bool PuedeTransportar(double peso)
    {
        return peso <= capacidad;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Capacidad: " + Capacidad + " kg");
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Costo operativo + CostoOperativo);
    }
}