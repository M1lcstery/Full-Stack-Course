namespace ProyectoCurso1.Modelo
{
    public class Habitacion
    {
        public string Nombre { get; set; }
        public Enumeraciones.TipoHabitacion Tipo { get; set; }
        public decimal Precio { get; set; }

        public Habitacion(string nombre, Enumeraciones.TipoHabitacion tipo, decimal precio)
        {
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
        }

        public Habitacion()
        {
        }
    }
}