namespace ProyectoCurso1.Modelo
{
    public class Hotel
    {
        public List<Habitacion> Habitaciones { get; set; }
        public List<Reservas> Reservas { get; set; }

        public Hotel()
        {
            Habitaciones = new List<Habitacion>();
            Reservas = new List<Reservas>();

            for (int i = 0; i < 6; i++)
            {
                Habitaciones.Add(new Habitacion("10" + i, Enumeraciones.TipoHabitacion.Classic, 1000));
            }

            for (int i = 1; i < 6; i++)
            {
                Habitaciones.Add(new Habitacion("20" + i, Enumeraciones.TipoHabitacion.Executive, 1500));
            }

            for (int i = 2; i < 6; i++)
            {
                Habitaciones.Add(new Habitacion("30" + i, Enumeraciones.TipoHabitacion.Grandsuite, 2000));
            }
        }

        public List<Habitacion> GetHabitaciones()
        {
            return Habitaciones;
        }

        public bool CrearReserva(Reservas reserva)
        {
            Reservas.Add(reserva);

            return true;
        }
    }
}