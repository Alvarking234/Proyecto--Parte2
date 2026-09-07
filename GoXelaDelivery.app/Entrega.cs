namespace GoXelaDelivery.app
{
    internal class Entrega
    {
        private int codigo;
        private Cliente cliente;
        private Paquete paquete;
        private Repartidor repartidor;
        private Vehiculo vehiculo;
        private DateTime fechaSolicitud;
        private string origen;
        private string destino;
        private double distancia;
        private string tipoServicio;
        private string estado;
        private double tarifaBase;
        private double recargos;
        private double descuentos;
        private double total;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Paquete Paquete
        {
            get { return paquete; }
            set { paquete = value; }
        }

        public Repartidor Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }

        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }

        public DateTime FechaSolicitud
        {
            get { return fechaSolicitud; }
            set { fechaSolicitud = value; }
        }

        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }

        public string TipoServicio
        {
            get { return tipoServicio; }
            set { tipoServicio = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public double TarifaBase
        {
            get { return tarifaBase; }
            set { tarifaBase = value; }
        }

        public double Recargos
        {
            get { return recargos; }
            set { recargos = value; }
        }

        public double Descuentos
        {
            get { return descuentos; }
            set { descuentos = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Entrega()
        {
            fechaSolicitud = DateTime.Now;
            estado = "Pendiente";
            recargos = 0;
            descuentos = 0;
            total = 0;
        }

        public Entrega(int codigo, Cliente cliente, Paquete paquete,
                       Repartidor repartidor, Vehiculo vehiculo,
                       string origen, string destino,
                       double distancia, string tipoServicio)
        {
            this.codigo = codigo;
            this.cliente = cliente;
            this.paquete = paquete;
            this.repartidor = repartidor;
            this.vehiculo = vehiculo;
            this.origen = origen;
            this.destino = destino;
            this.distancia = distancia;
            this.tipoServicio = tipoServicio;

            fechaSolicitud = DateTime.Now;
            estado = "Pendiente";
            recargos = 0;
            descuentos = 0;

            tarifaBase = paquete.CalcularTarifa(distancia);
            total = tarifaBase;
        }

        public void CalcularTotal()
        {
            total = tarifaBase + recargos - descuentos;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Código de entrega: " + Codigo);
            Console.WriteLine("Cliente: " + Cliente.Nombre);
            Console.WriteLine("Paquete: " + Paquete.Descripcion);
            Console.WriteLine("Repartidor: " + Repartidor.Nombre);
            Console.WriteLine("Vehículo: " + Vehiculo.Marca + " " + Vehiculo.Modelo);
            Console.WriteLine("Fecha de solicitud: " + FechaSolicitud);
            Console.WriteLine("Origen: " + Origen);
            Console.WriteLine("Destino: " + Destino);
            Console.WriteLine("Distancia: " + Distancia + " km");
            Console.WriteLine("Servicio: " + TipoServicio);
            Console.WriteLine("Estado: " + Estado);
            Console.WriteLine("Tarifa base: Q" + TarifaBase);
            Console.WriteLine("Recargos: Q" + Recargos);
            Console.WriteLine("Descuentos: Q" + Descuentos);
            Console.WriteLine("Total: Q" + Total);
        }
    }
}