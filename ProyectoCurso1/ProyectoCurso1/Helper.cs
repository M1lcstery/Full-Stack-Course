namespace ProyectoCurso1.Modelo
{
    public static class Helper
    {
        public static void Escribir(string texto, bool continuar = false)
        {
            Console.WriteLine(texto);
            if (continuar)
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadLine();
            }
        }

        public static List<DateTime> ObtenerFechasComprendidas(DateTime fechaIngreso, DateTime fechaEgreso)
        {
            int totalDias = (int)(fechaEgreso - fechaIngreso).Days + 1;
            List<DateTime> fechasComprendidas = new List<DateTime>();

            for (int i = 0; i <= totalDias; i++)
            {
                fechasComprendidas.Add(fechaIngreso.AddDays(i));
            }

            return fechasComprendidas;
        }

        public static bool HayFechasRepetidas(List<DateTime> fechasReservadas, List<DateTime> fechasTentativas)
        {
            var fechas = new List<DateTime>();
            fechas.AddRange(fechasReservadas);
            fechas.AddRange(fechasTentativas);
            
            var fechasVistas = new List<DateTime>();

            foreach (var fecha in fechas)
            {
                if (fechasVistas.Contains(fecha))
                {
                    return true;
                }

                fechasVistas.Add(fecha);
            }

            return false;
        }
    }
}