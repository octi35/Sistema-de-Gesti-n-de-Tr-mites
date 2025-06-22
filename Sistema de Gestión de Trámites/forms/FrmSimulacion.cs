using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Trámites
{
    public partial class FrmSimulacion : Form
    {
        public FrmSimulacion()
        {
            InitializeComponent();
        }

        public static ColaTramites cola;
        public static PilaUrgencias pila;
        public static ListaFinalizados historial;

        private void FrmSimulacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirJornada_Click(object sender, EventArgs e)
        {
            try
            {
                cola.Vaciar();
                pila.Vaciar();
                historial.Vaciar();

                // Leer Cola
                if (File.Exists("cola.txt"))
                {
                    foreach (var linea in File.ReadAllLines("cola.txt"))
                    {
                        var datos = linea.Split(';');
                        var tramite = new Tramite(datos[0], datos[1], datos[2])
                        {
                            FechaHora = DateTime.Parse(datos[4])
                        };
                        cola.Encolar(tramite);
                    }
                }

                // Leer Pila
                if (File.Exists("pila.txt"))
                {
                    foreach (var linea in File.ReadAllLines("pila.txt"))
                    {
                        var datos = linea.Split(';');
                        var urgente = new TramiteUrgente(datos[0], datos[1], datos[2], datos[3])
                        {
                            FechaHora = DateTime.Parse(datos[4])
                        };
                        pila.Apilar(urgente);
                    }
                }

                // Leer Historial
                if (File.Exists("lista.txt"))
                {
                    foreach (var linea in File.ReadAllLines("lista.txt"))
                    {
                        var datos = linea.Split(';');
                        var tramite = new Tramite(datos[0], datos[1], datos[2])
                        {
                            FechaHora = DateTime.Parse(datos[4])
                        };
                        historial.AgregarOrdenado(tramite);
                    }
                }

                lblEstado.Text = "Jornada abierta correctamente.";
                lblEstado.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error al abrir jornada: " + ex.Message;
                lblEstado.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnCerrarJornada_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar Cola
                using (StreamWriter sw = new StreamWriter("cola.txt"))
                {
                    foreach (var t in cola.ObtenerTramites())
                        sw.WriteLine($"{t.DNI};{t.Nombre};{t.Tipo};;{t.FechaHora}");
                }

                // Guardar Pila
                using (StreamWriter sw = new StreamWriter("pila.txt"))
                {
                    foreach (var t in pila.ObtenerTodos())
                        sw.WriteLine($"{t.DNI};{t.Nombre};{t.Tipo};{t.Motivo};{t.FechaHora}");
                }

                // Guardar Historial
                using (StreamWriter sw = new StreamWriter("lista.txt"))
                {
                    foreach (var t in historial.ObtenerTodos())
                        sw.WriteLine($"{t.DNI};{t.Nombre};{t.Tipo};;{t.FechaHora}");
                }

                lblEstado.Text = "Jornada cerrada y guardada correctamente.";
                lblEstado.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error al cerrar jornada: " + ex.Message;
                lblEstado.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
