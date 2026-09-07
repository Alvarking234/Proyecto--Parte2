using GoXelaDelivery.app;

List<Cliente> clientes = new List<Cliente>();
List<Repartidor> repartidores = new List<Repartidor>();
List<Vehiculo> vehiculos = new List<Vehiculo>();
List<Paquete> paquetes = new List<Paquete>();
List<Entrega> entregas = new List<Entrega>();
List<Incidencia> incidencias = new List<Incidencia>();

int opcion;


do
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("       GOXELA DELIVERY");
    Console.WriteLine("======================================");
    Console.WriteLine("1. Registrar cliente \n2. Consultar clientes \n3. Registrar repartidor \n4. Consultar repartidores \n5.Registrar Vehículos \n6. Consultar Vehículos \n7. Registrar Paquetes \n8. Consultar Paquetes");
    Console.WriteLine("9.Registrar entregas \n10. Consultar entregas\n12. Registrar incidencia \n13. Consultar incidencias \n14. Reportes \n0. Salir");
    Console.WriteLine("======================================");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opción inválida.");
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
        continue;
    }

    switch (opcion)
    {
        case 1:
            RegistrarCliente();
            break;

        case 2:
            ConsultarClientes();
            break;

        case 3:
            RegistrarRepartidor();
            break;

        case 4:
            ConsultarRepartidores();
            break;
        case 5:
            RegistrarVehiculo();
            break;

        case 6:
            ConsultarVehiculos();
            break;
        case 7:
            RegistrarPaquete();
            break;

        case 8:
            ConsultarPaquetes();
            break;
        case 9:
            RegistrarEntrega();
            break;

        case 10:
            ConsultarEntregas();
            break;
        case 11:
            ActualizarEstadoEntrega();
            break;
        case 12:
            RegistrarIncidencia();
            break;

        case 13:
            ConsultarIncidencias();
            break;
        case 14:
            MostrarReportes();
            break;
        case 0:
            Console.WriteLine("Saliendo de GoXela Delivery...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            break;
    }

} while (opcion != 0);
void RegistrarCliente()
{
    Console.Clear();
    Console.WriteLine("==== REGISTRAR CLIENTE ====");
    int codigo = LeerEntero("Código: ");
    Console.Write("Nombre: ");
    if (clientes.Exists(c => c.Codigo == codigo))
    {
        Console.WriteLine("Ya existe un cliente con ese código.");
        Console.ReadLine();
        return;
    }
    string nombre = Console.ReadLine();
    Console.Write("Teléfono: ");
    string telefono = Console.ReadLine();
    Console.Write("Correo: ");
    string correo = Console.ReadLine();
    Console.Write("Dirección: ");
    string direccion = Console.ReadLine();
    Cliente cliente = new Cliente(
        codigo,
        nombre,
        telefono,
        correo,
        direccion
    );
    clientes.Add(cliente);
    Console.WriteLine("Cliente registrado correctamente.");
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}


void ConsultarClientes()
{
    Console.Clear();
    Console.WriteLine("=== CLIENTES REGISTRADOS ===");

    if (clientes.Count == 0)
    {
        Console.WriteLine("No hay clientes registrados.");
    }
    else
    {
        foreach (Cliente cliente in clientes)
        {
            cliente.MostrarInformacion();
            Console.WriteLine("----------------------------------");
        }
    }

    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}


void RegistrarRepartidor()
{
    Console.Clear();
    Console.WriteLine("=== REGISTRAR REPARTIDOR ===");
    int codigo = LeerEntero("Código: ");
    if (repartidores.Exists(r => r.Codigo == codigo))
    {
        Console.WriteLine("Ya existe un repartidor con ese código.");
        Console.ReadLine();
        return;
    }
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Teléfono: ");
    string telefono = Console.ReadLine();
    Console.Write("Licencia: ");
    string licencia = Console.ReadLine();
    Repartidor repartidor = new Repartidor(
        codigo,
        nombre,
        telefono,
        licencia);
    repartidores.Add(repartidor);
    Console.WriteLine("Repartidor registrado correctamente.");
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}


void ConsultarRepartidores()
{
    Console.Clear();
    Console.WriteLine("=== REPARTIDORES REGISTRADOS ===");

    if (repartidores.Count == 0)
    {
        Console.WriteLine("No hay repartidores registrados.");
    }
    else
    {
        foreach (Repartidor repartidor in repartidores)
        {
            repartidor.MostrarInformacion();
            Console.WriteLine("----------------------------------");
        }
    }

    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}
void RegistrarVehiculo()
{
    Console.Clear();
    Console.WriteLine("=== REGISTRAR VEHÍCULO ===");

    Console.WriteLine("1. Bicicleta \n2. Motocicleta \n3. Automóvil \nSeleccione el tipo de vehículo: ");
    int tipo = int.Parse(Console.ReadLine());
    int codigo = LeerEntero("Código: ");
    if (vehiculos.Exists(v => v.Codigo == codigo))
    {
        Console.WriteLine("Ya existe un vehículo con ese código.");
        Console.ReadLine();
        return;
    }
    Console.Write("Placa: ");
    string placa = Console.ReadLine();
    Console.Write("Marca: ");
    string marca = Console.ReadLine();
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();
    double capacidad = LeerDouble("Capacidad (kg): ");
    if (capacidad <= 0)
    {
        Console.WriteLine("La capacidad debe ser mayor que cero.");
        Console.ReadLine();
        return;
    }
    double costoOperativo = LeerDouble("Costo operativo: ");
    if (costoOperativo < 0)
    {
        Console.WriteLine("El costo operativo no puede ser negativo.");
        Console.ReadLine();
        return;
    }
    Vehiculo vehiculo;
    switch (tipo)
    {
        case 1:
            vehiculo = new Bicicleta(
                codigo,
                marca,
                modelo,
                capacidad,
                costoOperativo
            );
            break;

        case 2:
            vehiculo = new Motocicleta(
                codigo,
                placa,
                marca,
                modelo,
                capacidad,
                costoOperativo
            );
            break;

        case 3:
            vehiculo = new Automovil(
                codigo,
                placa,
                marca,
                modelo,
                capacidad,
                costoOperativo
            );
            break;

        default:
            Console.WriteLine("Tipo de vehículo inválido. \nPresione ENTER para continuar...");
            Console.ReadLine();
            return;
    }

    vehiculos.Add(vehiculo);

    Console.WriteLine("Vehículo registrado correctamente.");
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}
void ConsultarVehiculos()
{
    Console.Clear();
    Console.WriteLine("=== VEHÍCULOS REGISTRADOS ===");

    if (vehiculos.Count == 0)
    {
        Console.WriteLine("No hay vehículos registrados.");
    }
    else
    {
        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.MostrarInformacion();
            Console.WriteLine("----------------------------------");
        }
    }

    Console.WriteLine("\nPresione ENTER para continuar...");
    Console.ReadLine();
}
void RegistrarPaquete()
{
    Console.Clear();
    Console.WriteLine("=== REGISTRAR PAQUETE ===");
    Console.WriteLine("1. Documento \n2. Paquete estándar \n3. Paquete frágil \n4. Producto refrigerado ");
    int tipo = LeerEntero("Seleccione el tipo de paquete: ");

    int codigo = LeerEntero("Codigo: ");
    if (paquetes.Exists(p => p.Codigo == codigo))
    {
        Console.WriteLine("Ya existe un paquete con ese código.");
        Console.ReadLine();
        return;
    
    }
    Console.Write("Descripción: ");
    string descripcion = Console.ReadLine();

    double peso = LeerDouble("Peso (kg): ");
    if (peso <= 0)
    {
        Console.WriteLine("El peso debe ser mayor que cero.");
        Console.ReadLine();
        return;
    }

    double valorDeclarado = LeerDouble("Valor declarado: Q");
    if (valorDeclarado < 0)
    {
        Console.WriteLine("El valor declarado no puede ser negativo.");
        Console.ReadLine();
        return;
    }
    Console.Write("Dirección de origen: ");
    string origen = Console.ReadLine();

    Console.Write("Dirección de destino: ");
    string destino = Console.ReadLine();

    Paquete paquete;

    switch (tipo)
    {
        case 1:
            paquete = new Documento(
                codigo,
                descripcion,
                peso,
                valorDeclarado,
                origen,
                destino
            );
            break;

        case 2:
            paquete = new PaqueteEstandar(
                codigo,
                descripcion,
                peso,
                valorDeclarado,
                origen,
                destino
            );
            break;

        case 3:
            paquete = new PaqueteFragil(
                codigo,
                descripcion,
                peso,
                valorDeclarado,
                origen,
                destino
            );
            break;
        case 4:
            paquete = new ProductoRefrigerado(
                codigo,
                descripcion,
                peso,
                valorDeclarado,
                origen,
                destino
            );
            break;

        default:
            Console.WriteLine("Tipo de paquete inválido.");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            return;
    }

    paquetes.Add(paquete);

    Console.WriteLine("Paquete registrado correctamente.");
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}
int LeerEntero(string mensaje)
{
    int numero;

    while (true)
    {
        try
        {
            Console.Write(mensaje);
            numero = int.Parse(Console.ReadLine());

            return numero;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debe ingresar un número válido.");
        }
    }
}
double LeerDouble(string mensaje)
{
    double numero;

    while (true)
    {
        try
        {
            Console.Write(mensaje);
            numero = double.Parse(Console.ReadLine());

            return numero;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debe ingresar un número válido.");
        }
    }
}

    void ConsultarPaquetes()
{
    Console.Clear();
    Console.WriteLine("=== PAQUETES REGISTRADOS ===");

    if (paquetes.Count == 0)
    {
        Console.WriteLine("No hay paquetes registrados.");
    }
    else
    {
        foreach (Paquete paquete in paquetes)
        {
            paquete.MostrarInformacion();

            Console.WriteLine("----------------------------------");

            Console.WriteLine(
                "Tarifa estimada para 5 km: Q" +
                paquete.CalcularTarifa(5)
            );

            Console.WriteLine("----------------------------------");
        }
    }

    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}
void RegistrarEntrega()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("        REGISTRAR ENTREGA");
    Console.WriteLine("======================================");

    if (clientes.Count == 0 || paquetes.Count == 0 ||
        repartidores.Count == 0 || vehiculos.Count == 0)
    {
        Console.WriteLine("No se puede registrar la entrega. \nDebe existir al menos un cliente, paquete, repartidor y vehículo registrados.");
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
        return;
    }

    int codigo = LeerEntero("Código de la entrega: ");
    if (entregas.Exists(e => e.Codigo == codigo))
    {
        Console.WriteLine("Ya existe una entrega con ese código.");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("--- CLIENTES ---");

    foreach (Cliente cliente in clientes)
    {
        Console.WriteLine(cliente.Codigo + " - " + cliente.Nombre);
    }

    int codigoCliente = LeerEntero("Seleccione el código del cliente: ");

    Cliente clienteSeleccionado = clientes.Find(c => c.Codigo == codigoCliente);

    if (clienteSeleccionado == null)
    {
        Console.WriteLine("Cliente no encontrado.");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("--- PAQUETES ---");

    foreach (Paquete paquete in paquetes)
    {
        Console.WriteLine(
            paquete.Codigo + " - " +
            paquete.Descripcion + " - " +
            paquete.Peso + " kg");
    }

    int codigoPaquete = LeerEntero("Seleccione el código del paquete: ");

    Paquete paqueteSeleccionado = paquetes.Find(p => p.Codigo == codigoPaquete);

    if (paqueteSeleccionado == null)
    {
        Console.WriteLine("Paquete no encontrado.");
        Console.ReadLine();
        return;
    }
    if (paqueteSeleccionado.Estado != "Disponible")
    {
        Console.WriteLine("El paquete no está disponible para una nueva entrega.");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("--- REPARTIDORES ---");

    foreach (Repartidor repartidor in repartidores)
    {
        Console.WriteLine(
            repartidor.Codigo + " - " +
            repartidor.Nombre + " - " +
            repartidor.Estado);
    }

    int codigoRepartidor = LeerEntero("Seleccione el código del repartidor: ");

    Repartidor repartidorSeleccionado =
        repartidores.Find(r => r.Codigo == codigoRepartidor);

    if (repartidorSeleccionado == null)
    {
        Console.WriteLine("Repartidor no encontrado.");
        Console.ReadLine();
        return;
    }

    if (repartidorSeleccionado.Estado != "Disponible")
    {
        Console.WriteLine("El repartidor no está disponible.");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("--- VEHÍCULOS ---");

    foreach (Vehiculo vehiculo in vehiculos)
    {
        Console.WriteLine(
            vehiculo.Codigo + " - " +
            vehiculo.Marca + " " +
            vehiculo.Modelo + " - " +
            vehiculo.Estado);
    }

    int codigoVehiculo = LeerEntero("Seleccione el código del vehículo: ");

    Vehiculo vehiculoSeleccionado =
        vehiculos.Find(v => v.Codigo == codigoVehiculo);

    if (vehiculoSeleccionado == null)
    {
        Console.WriteLine("Vehículo no encontrado.");
        Console.ReadLine();
        return;
    }

    if (vehiculoSeleccionado.Estado != "Disponible")
    {
        Console.WriteLine("El vehículo no está disponible.");
        Console.ReadLine();
        return;
    }

    if (!vehiculoSeleccionado.PuedeTransportar(paqueteSeleccionado.Peso))
    {
        Console.WriteLine("El vehículo no tiene capacidad suficiente.");
        Console.ReadLine();
        return;
    }

    double distancia = LeerDouble("Distancia del recorrido en km: ");
    if (distancia <= 0)
    {
        Console.WriteLine("La distancia debe ser mayor que cero.");
        Console.ReadLine();
        return;
    }
    Console.WriteLine("--- TIPO DE SERVICIO ---");
    Console.WriteLine("1. Normal \n2. Prioritario \n3. Urgente");
    int opcionServicio = LeerEntero("Seleccione: "); ;

    string tipoServicio;

    double tarifaBase = paqueteSeleccionado.CalcularTarifa(distancia);
    double recargos = 0;
    double descuentos = 0;
    switch (opcionServicio)
    {
        case 2:
            recargos = tarifaBase * 0.20;
            break;

        case 3:
            recargos = tarifaBase * 0.40;
            break;
    }
    if (vehiculoSeleccionado is Bicicleta)
    {
        recargos += 5;
    }
    else if (vehiculoSeleccionado is Motocicleta)
    {
        recargos += 10;
    }
    else if (vehiculoSeleccionado is Automovil)
    {
        recargos += 20;
    }
    switch (opcionServicio)
    {
        case 1:
            tipoServicio = "Normal";
            break;

        case 2:
            tipoServicio = "Prioritario";
            break;

        case 3:
            tipoServicio = "Urgente";
            break;

        default:
            Console.WriteLine("Tipo de servicio inválido.");
            Console.ReadLine();
            return;
    }

    Entrega nuevaEntrega = new Entrega(
        codigo,
        clienteSeleccionado,
        paqueteSeleccionado,
        repartidorSeleccionado,
        vehiculoSeleccionado,
        paqueteSeleccionado.DireccionOrigen,
        paqueteSeleccionado.DireccionDestino,
        distancia,
        tipoServicio
    );

    entregas.Add(nuevaEntrega);

    repartidorSeleccionado.Estado = "Ocupado";
    vehiculoSeleccionado.Estado = "Ocupado";
    paqueteSeleccionado.Estado = "En tránsito";

    Console.WriteLine("\n======================================");
    Console.WriteLine("      ENTREGA REGISTRADA");
    Console.WriteLine("======================================");

    nuevaEntrega.MostrarInformacion();

    Console.WriteLine("\nPresione ENTER para continuar...");
    Console.ReadLine();
}
void ConsultarEntregas()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("        CONSULTAR ENTREGAS");
    Console.WriteLine("======================================");

    if (entregas.Count == 0)
    {
        Console.WriteLine("No hay entregas registradas.");
    }
    else
    {
        foreach (Entrega entrega in entregas)
        {
            Console.WriteLine("--------------------------------------");
            entrega.MostrarInformacion();
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Total de entregas: " + entregas.Count);
    }

    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}
void ActualizarEstadoEntrega()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("     ACTUALIZAR ESTADO DE ENTREGA");
    Console.WriteLine("======================================");

    if (entregas.Count == 0)
    {
        Console.WriteLine("No hay entregas registradas.");
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("--- ENTREGAS ---");

    foreach (Entrega entrega in entregas)
    {
        Console.WriteLine(
            entrega.Codigo + " - " +
            entrega.Cliente.Nombre + " - " +
            entrega.Estado);
    }

    Console.Write("\nSeleccione el código de la entrega: ");
    int codigoEntrega = int.Parse(Console.ReadLine());

    Entrega entregaSeleccionada =
        entregas.Find(e => e.Codigo == codigoEntrega);

    if (entregaSeleccionada == null)
    {
        Console.WriteLine("Entrega no encontrada.");
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("\n--- NUEVO ESTADO ---");
    Console.Write("1. Entregada \n2. Cancelada \n3. Reprogramada \nSeleccione: ");

    int opcionEstado = int.Parse(Console.ReadLine());

    switch (opcionEstado)
    {
        case 1:
            entregaSeleccionada.Estado = "Entregada";
            entregaSeleccionada.Paquete.Estado = "Entregado";
            entregaSeleccionada.Repartidor.Estado = "Disponible";
            entregaSeleccionada.Vehiculo.Estado = "Disponible";
            entregaSeleccionada.Repartidor.EntregasRealizadas++;

            Console.WriteLine("Entrega marcada como entregada.");
            break;

        case 2:
            entregaSeleccionada.Estado = "Cancelada";
            entregaSeleccionada.Paquete.Estado = "Disponible";
            entregaSeleccionada.Repartidor.Estado = "Disponible";
            entregaSeleccionada.Vehiculo.Estado = "Disponible";

            Console.WriteLine("Entrega cancelada correctamente.");
            break;

        case 3:
            entregaSeleccionada.Estado = "Reprogramada";
            entregaSeleccionada.Repartidor.Estado = "Disponible";
            entregaSeleccionada.Vehiculo.Estado = "Disponible";

            Console.WriteLine("Entrega reprogramada.");
            break;

        default:
            Console.WriteLine("Estado inválido.");
            break;
    }

    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}
void RegistrarIncidencia()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("        REGISTRAR INCIDENCIA");
    Console.WriteLine("======================================");

    if (entregas.Count == 0)
    {
        Console.WriteLine("No hay entregas registradas.");
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
        return;
    }

    int codigo = LeerEntero("Código de la incidencia: ");
    if (incidencias.Exists(i => i.Codigo == codigo))
    {
        Console.WriteLine("Ya existe una incidencia con ese código.");
        Console.ReadLine();
        return;
    }
    Console.WriteLine("\n--- ENTREGAS ---");

    foreach (Entrega entrega in entregas)
    {
        Console.WriteLine(
            entrega.Codigo + " - " +
            entrega.Cliente.Nombre + " - " +
            entrega.Estado);
    }

    int codigoEntrega = LeerEntero("Seleccione el código de la entrega: ");

    Entrega entregaSeleccionada =
        entregas.Find(e => e.Codigo == codigoEntrega);

    if (entregaSeleccionada == null)
    {
        Console.WriteLine("Entrega no encontrada.");
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("\n--- TIPO DE INCIDENCIA ---");
    Console.Write("1. Cliente ausente \n2. Dirección incorrecta \n3. Paquete dañado \n4. Vehículo averiado \n5. Retraso \n6. Clima \n7. Rechazo del client");
    int opcionTipo = LeerEntero("Seleccione: ");

    string tipo;

    switch (opcionTipo)
    {
        case 1:
            tipo = "Cliente ausente";
            break;

        case 2:
            tipo = "Dirección incorrecta";
            break;

        case 3:
            tipo = "Paquete dañado";
            break;

        case 4:
            tipo = "Vehículo averiado";
            break;

        case 5:
            tipo = "Retraso";
            break;

        case 6:
            tipo = "Clima";
            break;

        case 7:
            tipo = "Rechazo del cliente";
            break;

        default:
            Console.WriteLine("Tipo de incidencia inválido.");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            return;
    }

    Console.Write("Descripción de la incidencia: ");
    string descripcion = Console.ReadLine();

    Incidencia nuevaIncidencia =
        new Incidencia(
            codigo,
            entregaSeleccionada,
            tipo,
            descripcion
        );

    incidencias.Add(nuevaIncidencia);

    Console.WriteLine("\n======================================");
    Console.WriteLine("      INCIDENCIA REGISTRADA");
    Console.WriteLine("======================================");

    nuevaIncidencia.MostrarInformacion();

    Console.WriteLine("\nPresione ENTER para continuar...");
    Console.ReadLine();
}
void ConsultarIncidencias()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("        CONSULTAR INCIDENCIAS");
    Console.WriteLine("======================================");

    if (incidencias.Count == 0)
    {
        Console.WriteLine("No hay incidencias registradas.");
    }
    else
    {
        foreach (Incidencia incidencia in incidencias)
        {
            Console.WriteLine("--------------------------------------");
            incidencia.MostrarInformacion();
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Total de incidencias: " + incidencias.Count);
    }

    Console.WriteLine("\nPresione ENTER para continuar...");
    Console.ReadLine();
}

void MostrarReportes()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("             REPORTES");
    Console.WriteLine("======================================");

    Console.WriteLine("1. Entregas activas \n2. Entregas finalizadas \n3. Entregas canceladas \n4. Incidencias \n5. Repartidor con más entregas \n6. Vehículo más utilizado \n7. Paquetes por tipo \n8. Ingresos totales \n9. Entrega de mayor costo");

    int opcion = LeerEntero("Seleccione un reporte: ");
    Console.Clear();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("=== ENTREGAS ACTIVAS ===");
            foreach (Entrega entrega in entregas)
            {
                if (entrega.Estado == "Pendiente" ||
                    entrega.Estado == "En tránsito" ||
                    entrega.Estado == "Reprogramada")
                {
                    entrega.MostrarInformacion();
                    Console.WriteLine("--------------------------------------");
                }
                int ContarEntregasPorEstado(List<Entrega> lista, string estado, int indice)
                {
                    if (indice == lista.Count)
                    {
                        return 0;
                    }
                    int actual = lista[indice].Estado == estado ? 1 : 0;
                    return actual + ContarEntregasPorEstado(lista, estado, indice + 1);
                }
            }
            break;
        case 2:
            Console.WriteLine("=== ENTREGAS FINALIZADAS ===");
            foreach (Entrega entrega in entregas)
            {
                if (entrega.Estado == "Entregada")
                {
                    entrega.MostrarInformacion();
                    Console.WriteLine("--------------------------------------");
                }
            }
            break;
        case 3:
            Console.WriteLine("=== ENTREGAS CANCELADAS ===");
            foreach (Entrega entrega in entregas)
            {
                if (entrega.Estado == "Cancelada")
                {
                    entrega.MostrarInformacion();
                    Console.WriteLine("--------------------------------------");
                }
            }
            break;
        case 4:
            Console.WriteLine("=== INCIDENCIAS ===");
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No hay incidencias registradas.");
            }
            else
            {
                foreach (Incidencia incidencia in incidencias)
                {
                    incidencia.MostrarInformacion();
                    Console.WriteLine("--------------------------------------");
                }
            }
            break;
        case 5:
            Console.WriteLine("=== REPARTIDOR CON MÁS ENTREGAS ===");

            if (repartidores.Count == 0)
            {
                Console.WriteLine("No hay repartidores registrados.");
            }
            else
            {
                Repartidor mayor = repartidores[0];

                foreach (Repartidor repartidor in repartidores)
                {
                    if (repartidor.EntregasRealizadas >
                        mayor.EntregasRealizadas)
                    {
                        mayor = repartidor;
                    }
                }
                mayor.MostrarInformacion();
            }
            break;
        case 6:
            Console.WriteLine("=== VEHÍCULO MÁS UTILIZADO ===");
            if (vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehículos registrados.");
            }
            else
            {
                foreach (Vehiculo vehiculo in vehiculos)
                {
                    int cantidad = 0;
                    foreach (Entrega entrega in entregas)
                    {
                        if (entrega.Vehiculo.Codigo == vehiculo.Codigo)
                        {
                            cantidad++;
                        }
                    }
                    Console.WriteLine(
                        vehiculo.Marca + " " +
                        vehiculo.Modelo +
                        " - Uso: " + cantidad);
                }
            }
            break;
        case 7:
            Console.WriteLine("=== PAQUETES POR TIPO ===");
            int documentos = 0;
            int estandar = 0;
            int fragiles = 0;
            int refrigerados = 0;
            foreach (Paquete paquete in paquetes)
            {
                if (paquete is Documento)
                {
                    documentos++;
                }
                else if (paquete is PaqueteEstandar)
                {
                    estandar++;
                }
                else if (paquete is PaqueteFragil)
                {
                    fragiles++;
                }
                else if (paquete is ProductoRefrigerado)
                {
                    refrigerados++;
                }
            }
            Console.WriteLine("Documentos: " + documentos);
            Console.WriteLine("Paquetes estándar: " + estandar);
            Console.WriteLine("Paquetes frágiles: " + fragiles);
            Console.WriteLine("Productos refrigerados: " + refrigerados);
            break;
        case 8:
            Console.WriteLine("=== INGRESOS TOTALES ===");
            double ingresos = 0;
            foreach (Entrega entrega in entregas)
            {
                if (entrega.Estado == "Entregada")
                {
                    ingresos += entrega.Total;
                }
            }
            Console.WriteLine("Ingresos totales: Q" + ingresos);
            break;

        case 9:
            Console.WriteLine("=== ENTREGA DE MAYOR COSTO ===");

            if (entregas.Count == 0)
            {
                Console.WriteLine("No hay entregas registradas.");
            }
            else
            {
                Entrega mayorCosto = entregas[0];

                foreach (Entrega entrega in entregas)
                {
                    if (entrega.Total > mayorCosto.Total)
                    {
                        mayorCosto = entrega;
                    }
                }
                mayorCosto.MostrarInformacion();
            }
            break;
        default:
            Console.WriteLine("Reporte inválido.");
            break;
    }
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}
struct ResumenEntrega
{
    public int Codigo;
    public double Total;
    public string Estado;
}

