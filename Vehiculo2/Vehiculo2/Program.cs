public class Automovil : Vehiculo
{
    public Automovil(int codigo, string placa, string marca,
                     string modelo, double capacidad,
                     double costoOperativo)
        : base(codigo, placa, marca, modelo, capacidad, costoOperativo)
    {
    }

    public override bool PuedeTransportar(double peso)
    {
        return peso <= Capacidad;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Automóvil");
        base.MostrarInformacion();
    }
}