using System;
using System.Collections.Generic;

namespace ProyectoCurso1.Modelo
{
    public class Reservas
    {
        public Habitacion Habitacion { get; set; } = new Habitacion();
        public List<DateTime> Fechas { get; set; } = new List<DateTime>();
        public string Estado { get; set; }
        public Huesped HuespedPrincipal { get; set; } = new Huesped();
        public List<Huesped> Acompanantes { get; set; } = new List<Huesped>();
    }
}