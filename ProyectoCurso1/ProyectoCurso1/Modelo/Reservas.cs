namespace ProyectoCurso1.Modelo
{
    public class Reservas
    {
        public Habitacion Habitacion { get; set; }
        public List<DateTime> Fechas { get; set; }
        public string Estado { get; set; }
        public Huesped HuespedPrincipal { get; set; }
        public List<Huesped> Acompanantes { get; set; }
    }
}