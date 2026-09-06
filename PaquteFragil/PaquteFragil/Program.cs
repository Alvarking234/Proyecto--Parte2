public class PaqueteFragil : Paquete
{
    public PaqueteFragil(int codigo, string descripcion, double peso,
                         double valorDeclarado, string direccionOrigen,
                         string direccionDestino)
        : base(codigo, descripcion, peso, valorDeclarado,
               direccionOrigen, direccionDestino, "Paquete frágil")
    {
    }

    public override double CalcularTarifa(double distancia)
    {
        return 35 + (distancia * 5) + (Peso * 3);
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Paquete frágil");
        base.MostrarInformacion();
    }
}