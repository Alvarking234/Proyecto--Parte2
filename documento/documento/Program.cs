public class Documento : Paquete
{
    public Documento(int codigo, string descripcion, double peso,
                     double valorDeclarado, string direccionOrigen,
                     string direccionDestino)
        : base(codigo, descripcion, peso, valorDeclarado,
               direccionOrigen, direccionDestino, "Documento")
    {
    }

    public override double CalcularTarifa(double distancia)
    {
        return 20 + (distancia * 3);
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Documento");
        base.MostrarInformacion();
    }
}