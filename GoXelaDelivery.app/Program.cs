List<Cliente> clientes = new List<Cliente>();
List<Repartidor> repartidores = new List<Repartidor>();
List<Vehiculo> vehiculos = new List<Vehiculo>();
List<Paquete> paquetes = new List<Paquete>();
int opcion;

do
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("       GOXELA DELIVERY");
    Console.WriteLine("======================================");
    Console.WriteLine("1. Registrar cliente \n2. Consultar clientes \n3. Registrar repartidor \n4. Consultar repartidores \n5.Registrar Vehículos \n6. Consultar Vehículos \n7. Registrar Paquetes \n8. Consultar Paquetes \n0. Salir");
    Console.WriteLine("");
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

    Console.Write("Código: ");
    int codigo = int.Parse(Console.ReadLine());

    Console.Write("Nombre: ");
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

    Console.Write("Código: ");
    int codigo = int.Parse(Console.ReadLine());

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
        licencia
    );

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
    Console.Write("Código: ");
    int codigo = int.Parse(Console.ReadLine());
    Console.Write("Placa: ");
    string placa = Console.ReadLine();
    Console.Write("Marca: ");
    string marca = Console.ReadLine();
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();
    Console.Write("Capacidad de carga (kg): ");
    double capacidad = double.Parse(Console.ReadLine());

    Console.Write("Costo operativo: Q");
    double costoOperativo = double.Parse(Console.ReadLine());

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

    Console.WriteLine("1. Paquete estándar \n2. Paquete frágil \n3. Producto refrigerado \nSeleccione el tipo de paquete: ");

    int tipo = int.Parse(Console.ReadLine());

    Console.Write("\nCódigo: ");
    int codigo = int.Parse(Console.ReadLine());

    Console.Write("Descripción: ");
    string descripcion = Console.ReadLine();

    Console.Write("Peso (kg): ");
    double peso = double.Parse(Console.ReadLine());

    Console.Write("Valor declarado: Q");
    double valorDeclarado = double.Parse(Console.ReadLine());

    Console.Write("Dirección de origen: ");
    string origen = Console.ReadLine();

    Console.Write("Dirección de destino: ");
    string destino = Console.ReadLine();

    Paquete paquete;

    switch (tipo)
    {
        case 1:
            paquete = new PaqueteEstandar(
                codigo,
                descripcion,
                peso,
                valorDeclarado,
                origen,
                destino
            );
            break;

        case 2:
            paquete = new PaqueteFragil(
                codigo,
                descripcion,
                peso,
                valorDeclarado,
                origen,
                destino
            );
            break;

        case 3:
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
            Console.WriteLine("\nTipo de paquete inválido.");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            return;
    }

    paquetes.Add(paquete);

    Console.WriteLine("\nPaquete registrado correctamente.");
    Console.WriteLine("Presione ENTER para continuar...");
    Console.ReadLine();
}


void ConsultarPaquetes()
{
    Console.Clear();
    Console.WriteLine("=== PAQUETES REGISTRADOS ===\n");

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

    Console.WriteLine("\nPresione ENTER para continuar...");
    Console.ReadLine();
}