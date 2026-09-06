public class Bicicleta : Vehiculo
{
    public Bicicleta(int codigo, string marca, string modelo,
                     double capacidad, double costoOperativo)
        : base(codigo, "", marca, modelo, capacidad, costoOperativo)
    {
    }

    public override bool PuedeTransportar(double peso)
    {
        return peso <= Capacidad;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Bicicleta");
        base.MostrarInformacion();
    }
}