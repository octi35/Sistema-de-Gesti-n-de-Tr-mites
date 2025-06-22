using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private readonly string carpetaRespaldo = "Respaldo";

        private void FrmSimulacion_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(carpetaRespaldo); // Asegura que exista la carpeta
        }

        private void btnAbrirJornada_Click(object sender, EventArgs e)
        {
            try
            {
                cola.Vaciar();
                pila.Vaciar();
                historial.Vaciar();

                CargarColaDesdeArchivo(Path.Combine(carpetaRespaldo, "cola.txt"));
                CargarPilaDesdeArchivo(Path.Combine(carpetaRespaldo, "pila.txt"));
                CargarHistorialDesdeArchivo(Path.Combine(carpetaRespaldo, "lista.txt"));

                lblEstado.Text = "Jornada abierta correctamente.";
                lblEstado.ForeColor = Color.Green;
                MessageBox.Show("Jornada abierta correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error al abrir jornada: " + ex.Message;
                lblEstado.ForeColor = Color.Red;
                File.AppendAllText("errores.log", DateTime.Now + " - " + ex.Message + Environment.NewLine);
            }
        }

        private void btnCerrarJornada_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarCola(Path.Combine(carpetaRespaldo, "cola.txt"));
                GuardarPila(Path.Combine(carpetaRespaldo, "pila.txt"));
                GuardarHistorial(Path.Combine(carpetaRespaldo, "lista.txt"));

                lblEstado.Text = "Jornada cerrada y guardada correctamente.";
                lblEstado.ForeColor = Color.Green;
                MessageBox.Show("Jornada cerrada y guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error al cerrar jornada: " + ex.Message;
                lblEstado.ForeColor = Color.Red;
                File.AppendAllText("errores.log", DateTime.Now + " - " + ex.Message + Environment.NewLine);
            }
        }

        private void CargarColaDesdeArchivo(string ruta)
        {
            if (!File.Exists(ruta)) return;

            foreach (var linea in File.ReadAllLines(ruta))
            {
                var datos = linea.Split(';');
                if (datos.Length >= 5)
                {
                    var tramite = new Tramite(datos[0], datos[1], datos[2])
                    {
                        FechaHora = DateTime.ParseExact(datos[4], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    cola.Encolar(tramite);
                }
            }
        }

        private void CargarPilaDesdeArchivo(string ruta)
        {
            if (!File.Exists(ruta)) return;

            foreach (var linea in File.ReadAllLines(ruta))
            {
                var datos = linea.Split(';');
                if (datos.Length >= 5)
                {
                    var urgente = new TramiteUrgente(datos[0], datos[1], datos[2], datos[3])
                    {
                        FechaHora = DateTime.ParseExact(datos[4], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    pila.Apilar(urgente);
                }
            }
        }

        private void CargarHistorialDesdeArchivo(string ruta)
        {
            if (!File.Exists(ruta)) return;

            foreach (var linea in File.ReadAllLines(ruta))
            {
                var datos = linea.Split(';');
                if (datos.Length >= 5)
                {
                    var tramite = new Tramite(datos[0], datos[1], datos[2])
                    {
                        FechaHora = DateTime.ParseExact(datos[4], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    historial.AgregarOrdenado(tramite);
                }
            }
        }

        private void GuardarCola(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                foreach (var t in cola.ObtenerTramites())
                {
                    sw.WriteLine($"{t.DNI};{t.Nombre};{t.Tipo};;{t.FechaHora:yyyy-MM-dd HH:mm:ss}");
                }
            }
        }

        private void GuardarPila(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                foreach (var t in pila.ObtenerTodos())
                {
                    sw.WriteLine($"{t.DNI};{t.Nombre};{t.Tipo};{t.Motivo};{t.FechaHora:yyyy-MM-dd HH:mm:ss}");
                }
            }
        }

        private void GuardarHistorial(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                foreach (var t in historial.ObtenerTodos())
                {
                    sw.WriteLine($"{t.DNI};{t.Nombre};{t.Tipo};;{t.FechaHora:yyyy-MM-dd HH:mm:ss}");
                }
            }
        }
    }
}
