using ProyectoCurso1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vista
{
    public partial class HabitacionDetalle : Form
    {
        public string Habitacion { get; set; }
        public List<Habitacion> Habitaciones { get; set; }
        public HabitacionDetalle(string hab, List<Habitacion> habitaciones)
        {
            InitializeComponent();
            Habitacion = hab;

            var seleccionado = habitaciones.First(x => x.Nombre == hab);

            lblTipoVariable.Text = seleccionado.Tipo.ToString();
            lblPrecioVariable.Text = seleccionado.Precio.ToString();
        }
    }
}
