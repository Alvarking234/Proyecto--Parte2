using System;

namespace GoXelaDelivery.app
{
    internal class Incidencia
    {
        private int codigo;
        private Entrega entrega;
        private string tipo;
        private string descripcion;
        private DateTime fecha;
        private string estado;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Entrega Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Incidencia()
        {
            fecha = DateTime.Now;
            estado = "Pendiente";
        }

        public Incidencia(int codigo, Entrega entrega,
                          string tipo, string descripcion)
        {
            this.codigo = codigo;
            this.entrega = entrega;
            this.tipo = tipo;
            this.descripcion = descripcion;

            fecha = DateTime.Now;
            estado = "Pendiente";
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Código de incidencia: " + Codigo);
            Console.WriteLine("Entrega: " + Entrega.Codigo);
            Console.WriteLine("Cliente: " + Entrega.Cliente.Nombre);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Descripción: " + Descripcion);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Estado: " + Estado);
        }
    }
}