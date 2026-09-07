List<Cliente> clientes = new List<Cliente>();
List<Repartidor> repartidores = new List<Repartidor>();

int opcion;

do
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("       GOXELA DELIVERY");
    Console.WriteLine("======================================");
    Console.WriteLine("1. Registrar cliente \n2. Consultar clientes \n3. Registrar repartidor \n4. Consultar repartidores \n0. Salir");
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

    Console.WriteLine("\nPresione ENTER para continuar...");
    Console.ReadLine();
}