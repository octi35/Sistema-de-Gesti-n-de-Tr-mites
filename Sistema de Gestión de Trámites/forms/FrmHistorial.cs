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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        public static ListaFinalizados historial;

        private void FrmHistorial_Load(object sender, EventArgs e)
        {

            if (dataHistorial.Columns.Count == 0)
            {
                dataHistorial.Columns.Add("DNI", "DNI");
                dataHistorial.Columns.Add("Nombre", "Nombre");
                dataHistorial.Columns.Add("Tipo", "Tipo");
                dataHistorial.Columns.Add("FechaHora", "Fecha y Hora");
                dataHistorial.Columns.Add("Motivo", "Motivo");
            }

            cmbFiltroTipo.Items.AddRange(new string[] { "Todos", "DNI", "Pasaporte", "Licencia", "Certificado médico", "Otro" });
            cmbFiltroTipo.SelectedIndex = 0;
            dtpFiltroFecha.Value = DateTime.Today;
            MostrarTramites(historial.ObtenerTodos());

        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            string tipoSeleccionado = cmbFiltroTipo.SelectedItem.ToString();
            DateTime fechaSeleccionada = dtpFiltroFecha.Value.Date;

            var filtrados = historial.ObtenerTodos()
                .Where(t =>
                    (tipoSeleccionado == "Todos" || t.Tipo == tipoSeleccionado) &&
                    t.FechaHora.Date == fechaSeleccionada
                ).ToList();

            MostrarTramites(filtrados);
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            MostrarTramites(historial.ObtenerTodos());
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarDialogo = new SaveFileDialog
            {
                Title = "Guardar historial de trámites",
                FileName = $"tramites_finalizados_{DateTime.Today:yyyyMMdd}.txt",
                Filter = "Archivos de texto (*.txt)|*.txt"
            };

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(guardarDialogo.FileName))
                    {
                        // Encabezado
                        sw.WriteLine("HISTORIAL DE TRÁMITES FINALIZADOS");
                        sw.WriteLine($"Fecha de exportación: {DateTime.Now}");
                        sw.WriteLine(new string('-', 100));
                        sw.WriteLine($"{"DNI",-10} {"Nombre",-20} {"Tipo",-15} {"Fecha/Hora",-25} {"Motivo",-20}");
                        sw.WriteLine(new string('-', 100));

                        // Datos
                        foreach (var t in historial.ObtenerTodos())
                        {
                            string motivo = t is TramiteUrgente urgente ? urgente.Motivo : "-";

                            sw.WriteLine($"{t.DNI,-10} {t.Nombre,-20} {t.Tipo,-15} {t.FechaHora,-25} {motivo,-20}");
                        }

                        sw.WriteLine(new string('-', 100));
                        sw.WriteLine($"Total de trámites exportados: {historial.ObtenerTodos().Count}");
                    }

                    MessageBox.Show("Historial exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarTramites(System.Collections.Generic.List<Tramite> lista)
        {
            dataHistorial.Rows.Clear();

            foreach (var t in lista)
            {
                string motivo = "";

                if (t is TramiteUrgente urgente)
                {
                    motivo = urgente.Motivo;
                }

                dataHistorial.Rows.Add(t.DNI, t.Nombre, t.Tipo, t.FechaHora, motivo);
            }
        }
    }
}
