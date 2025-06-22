using System;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Trámites
{
    public partial class FrmTramitesGenerales : Form
    {
        public FrmTramitesGenerales()
        {
            InitializeComponent();
        }

        // Cola local para trámites generales
        ColaTramites colaTramites = new ColaTramites();

        // Historial compartido con otros formularios
        public static ListaFinalizados historial;

        private void FrmTramitesGenerales_Load(object sender, EventArgs e)
        {
            if (dataColaTramites.Columns.Count == 0)
            {
                dataColaTramites.Columns.Add("DNI", "DNI");
                dataColaTramites.Columns.Add("Nombre", "Nombre");
                dataColaTramites.Columns.Add("Tipo", "Tipo de Trámite");
                dataColaTramites.Columns.Add("FechaHora", "Fecha y Hora");
            }

            cmbTipoTramite.Items.AddRange(new string[] { "DNI", "Pasaporte", "Licencia", "Certificado" });
            if (cmbTipoTramite.Items.Count > 0)
                cmbTipoTramite.SelectedIndex = 0;
        }

        private void btnRegistrarTramite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Tramite nuevo = new Tramite
            {
                DNI = txtDNI.Text,
                Nombre = txtNombre.Text,
                Tipo = cmbTipoTramite.SelectedItem.ToString(),
                FechaHora = DateTime.Now
            };

            colaTramites.Encolar(nuevo);
            MessageBox.Show("Trámite registrado correctamente.");
            LimpiarCampos();
        }

      

        private void btnAtenderTramite_Click(object sender, EventArgs e)
        {
            Tramite atendido = colaTramites.Desencolar();

            if (atendido != null)
            {
                historial.AgregarOrdenado(atendido);
                MessageBox.Show("Trámite atendido y enviado al historial.");
                MostrarCola();
            }
            else
            {
                MessageBox.Show("No hay trámites pendientes.");
            }
        }

        private void MostrarCola()
        {
            var lista = colaTramites.ObtenerTramites();

            dataColaTramites.Rows.Clear();

            foreach (var tramite in lista)
            {
                dataColaTramites.Rows.Add(tramite.DNI, tramite.Nombre, tramite.Tipo, tramite.FechaHora);
            }

            // Mostrar la cantidad de trámites en el título del form
            this.Text = $"Trámites Generales - {lista.Count} en espera";
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            if (cmbTipoTramite.Items.Count > 0)
                cmbTipoTramite.SelectedIndex = 0;
        }

        public void AsignarCola(ColaTramites c)
        {
            colaTramites = c;
        }

        private void btnVerCola_Click_1(object sender, EventArgs e)
        {
            MostrarCola();
        }
    }
}
