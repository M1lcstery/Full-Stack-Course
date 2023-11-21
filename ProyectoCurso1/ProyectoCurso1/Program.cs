// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ProyectoCurso1.Modelo;

internal class Program
{
    public static void Main(string[] args)
    {
        var hotel = new Hotel();

        MenuPrincipal(hotel);
    }

    public static void MenuPrincipal(Hotel hotel)
    {
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------MENU PRINCIPAL----------");
            Console.WriteLine("1 - Mostrar Habitaciones");
            Console.WriteLine("2 - Mostrar Reservas");
            Console.WriteLine("3 - Crear una Reserva");
            Console.WriteLine("4 - Buscar una reserva por nombre");
            Console.WriteLine("5 - Buscar una reserva por habitación");
            Console.WriteLine("6 - Cancelar una reserva");
            Console.WriteLine("10- Salir de la ejecución");
            Console.WriteLine("");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opcion Invalida");
            }

            switch (opcion)
            {
                case 1:
                    ListarHabitaciones(hotel.GetHabitaciones());
                    break;

                case 2:
                    ListarHabitacionesReservadas(hotel.Reservas);
                    break;

                case 3:
                    SubMenuCrearReserva(hotel);
                    break;

                case 4:
                    SubMenuBusquedaDeReservas(hotel.Reservas);
                    break;

                case 5:
                    SubMenuBusquedaDeReservasPorHabitacion(hotel.Reservas);
                    break;

                case 6:
                    CancelarReserva(hotel.Reservas);
                    break;

                case 10:
                    Console.WriteLine("Opcion 10");
                    break;
            }

        } while (opcion != 10);
    }

    private static void ListarHabitaciones(List<Habitacion> habitaciones)
    {
        foreach (var habitacion in habitaciones)
        {
            Console.WriteLine($"Habitacion: {habitacion.Nombre} tipo: {habitacion.Tipo.ToString()}");
        }

        Console.WriteLine("Oprima cualquier tecla para continuar");
        Console.ReadLine();
    }

    private static void SubMenuCrearReserva(Hotel hotel)
    {
        Console.WriteLine("Que habitacion desea reservar?");
        var habPorReservar = Console.ReadLine();

        if (!hotel.Habitaciones.Any(x => x.Nombre == habPorReservar))
        {
            Helper.Escribir("La habitación seleccionada no existe", true);
            MenuPrincipal(hotel);
        }

        Helper.Escribir("Ingrese la fecha de llegada");
        var inputFechaLlegada = Console.ReadLine();

        if (!DateTime.TryParseExact(inputFechaLlegada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fechaIngreso))
        {
            Helper.Escribir("La fecha no es válida.", true);
            MenuPrincipal(hotel);
        }

        Helper.Escribir("Ingrese la fecha de salida");
        var inputFechaSalida = Console.ReadLine();

        if (!DateTime.TryParseExact(inputFechaLlegada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fechaSalida))
        {
            Helper.Escribir("La fecha no es válida.", true);
            MenuPrincipal(hotel);
        }

        var fechas = Helper.ObtenerFechasComprendidas(fechaIngreso, fechaSalida);

        #region Chequeo de Reservas existentes

        var reservasEnHab = hotel.Reservas.Where(x => x.Habitacion.Nombre == habPorReservar).ToList();
        List<DateTime> fechasReservadas = new List<DateTime>();

        foreach (var res in reservasEnHab)
        {
            fechasReservadas.AddRange(res.Fechas);
        }

        if (Helper.HayFechasRepetidas(fechasReservadas, fechas))
        {
            Helper.Escribir("La habitación no está disponible en el rango de fechas seleccionado.", true);
            MenuPrincipal(hotel);
        }

        #endregion

        var estado = "Tentativa";

        Helper.Escribir("Nombre y apellido del huesped");
        var fullName = Console.ReadLine();

        var nombre = fullName.Split(" ")[0];
        var apellido = fullName.Split(" ")[1];


        var reserva = new Reservas
        {
            Habitacion = new Habitacion
            {
                Nombre = habPorReservar!,
                Precio = hotel.Habitaciones.Find(x => x.Nombre == habPorReservar)!.Precio,
            },

            Fechas = fechas,
            Estado = estado,

            HuespedPrincipal = new Huesped
            {
                Nombre = nombre!,
                Apellido = apellido!,
            }
        };

        var creacionEsCorrecta = hotel.CrearReserva(reserva);

        if (creacionEsCorrecta)
        {
            Console.WriteLine("La reserva se ha creado correctamente");
            Console.WriteLine("Oprima cualquier tecla para continuar...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Ocurrio algo inesperado, la reserva no se ha creado");
            Console.WriteLine("Oprima cualquier tecla para continuar...");
            Console.ReadLine();
        }
    }

    public static void ListarHabitacionesReservadas(List<Reservas> reservas)
    {
        foreach (var reserva in reservas)
        {
            Console.WriteLine($"Habitacion: {reserva.Habitacion.Nombre} ha sido reservada por el/la huesped: {reserva.HuespedPrincipal.Nombre} {reserva.HuespedPrincipal.Apellido}");

            foreach (var fecha in reserva.Fechas)
            {
                Helper.Escribir($"{fecha}");
            }

            Helper.Escribir(string.Empty, true);
        }

        Console.WriteLine("Oprima cualquier tecla para continuar...");
        Console.ReadLine();
    }

    public static void SubMenuBusquedaDeReservas(List<Reservas> reservas)
    {
        Console.WriteLine("Escriba el nombre de la persona a buscar");
        var nombreBuscado = Console.ReadLine();

        Console.WriteLine("Escriba el apellido de la persona a buscar");
        var apellidoBuscado = Console.ReadLine();

        // OPCION 1
        // foreach (var reserva in reservas)
        // {
        //     if (reserva.HuespedPrincipal.Nombre == nombreBuscado)
        //     {
        //         Console.WriteLine($"La persona que busca tiene una reserva en la fecha {reserva.Fechas.FirstOrDefault()} en la habitación {reserva.Habitacion.Nombre}");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"No se encontró ninguna reserva para {nombreBuscado}");
        //     }
        // }

        var ListaDeReserva = reservas
        .Where(
           x => x.HuespedPrincipal.Nombre == nombreBuscado &&
           x.HuespedPrincipal.Apellido == apellidoBuscado)
        .OrderBy(x => x.HuespedPrincipal.Nombre)
        .ToList();

        var reserva = ListaDeReserva.FirstOrDefault();

        var precio = reserva!.Habitacion.Precio * reserva.Fechas.Count;

        if (reserva != null)
        {
            Console.WriteLine($"La persona que busca tiene una reserva en la fecha {reserva.Fechas.FirstOrDefault()} en la habitación {reserva.Habitacion.Nombre}");
            Helper.Escribir($"El precio final de la reserva por {reserva.Fechas.Count} días es de {precio}.");
        }
        else
        {
            Console.WriteLine($"No se encontró ninguna reserva para {nombreBuscado}");
        }

        Console.WriteLine("Oprima cualquier tecla para continuar...");
        Console.ReadLine();
    }

    public static void SubMenuBusquedaDeReservasPorHabitacion(List<Reservas> reservas)
    {
        Helper.Escribir("Número de habitacion?");
        var nombreBuscado = Console.ReadLine();

        var listadoDeResevas = reservas.Where(x => x.Habitacion.Nombre == nombreBuscado)
            .ToList();

        foreach (var reserva in listadoDeResevas)
        {
            Helper.Escribir(reserva.HuespedPrincipal.Nombre);
            foreach (var fecha in reserva.Fechas)
            {
                Helper.Escribir(fecha.ToString(format: "dddd MMMM del yyyy"));
            }

            var precio = reserva!.Habitacion.Precio * reserva.Fechas.Count;

            Helper.Escribir($"El precio final de la reserva por {reserva.Fechas.Count} días es de {precio}.");

            Helper.Escribir("");
        }


        Helper.Escribir(string.Empty, true);
    }

    public static void CancelarReserva(List<Reservas> reservas)
    {
        Helper.Escribir("Ingrese el número de habitación");
        var habitacion = Console.ReadLine();

        Helper.Escribir("Ingrese el nombre y apellido del huesped");
        var fullName = Console.ReadLine();

        var nombre = fullName.Split(" ")[0];
        var apellido = fullName.Split(" ")[1];

        var reservaEncontrada = reservas.Find(x =>
        x.Habitacion.Nombre == habitacion
        && x.HuespedPrincipal.Nombre == nombre
        && x.HuespedPrincipal.Apellido == apellido
        );

        reservas.Remove(reservaEncontrada);

        Helper.Escribir($"La reserva del huesped {nombre} {apellido} ha sido eliminada correctamente", true);
    }
}