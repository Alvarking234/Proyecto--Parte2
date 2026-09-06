public class ProductoRefrigerado : Paquete
{
    public ProductoRefrigerado(int codigo, string descripcion, double peso,
                               double valorDeclarado, string direccionOrigen,
                               string direccionDestino)
        : base(codigo, descripcion, peso, valorDeclarado,
               direccionOrigen, direccionDestino, "Producto refrigerado")
    {
    }

    public override double CalcularTarifa(double distancia)
    {
        return 40 + (distancia * 6) + (Peso * 4);
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Producto refrigerado");
        base.MostrarInformacion();
    }
}