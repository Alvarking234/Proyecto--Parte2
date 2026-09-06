public class PaqueteEstandar : Paquete
{
    public PaqueteEstandar(int codigo, string descripcion, double peso,
                           double valorDeclarado, string direccionOrigen,
                           string direccionDestino)
        : base(codigo, descripcion, peso, valorDeclarado,
               direccionOrigen, direccionDestino, "Paquete estándar")
    {
    }

    public override double CalcularTarifa(double distancia)
    {
        return 25 + (distancia * 4) + (Peso * 2);
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Paquete estándar");
        base.MostrarInformacion();
    }
}