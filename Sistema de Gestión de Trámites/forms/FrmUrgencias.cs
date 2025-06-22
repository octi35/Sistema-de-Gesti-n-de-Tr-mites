using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Trámites
{
    public partial class FrmUrgencias : Form
    {
        public FrmUrgencias()
        {
            InitializeComponent();
        }
        PilaUrgencias pilaUrgencias = new PilaUrgencias();  // Pila local
        public static ListaFinalizados historial;
        private void FrmUrgencias_Load(object sender, EventArgs e)
        {
            cmbTipoTramite.Items.AddRange(new string[] { "DNI", "Pasaporte", "Licencia", "Certificado médico", "Otro" });
            cmbTipoTramite.SelectedIndex = 0;

            dataUrgencias.Columns.Add("DNI", "DNI");
            dataUrgencias.Columns.Add("Nombre", "Nombre");
            dataUrgencias.Columns.Add("Tipo", "Tipo");
            dataUrgencias.Columns.Add("Motivo", "Motivo");
            dataUrgencias.Columns.Add("FechaHora", "Fecha y Hora");

        }

        private void btnAgregarUrgencia_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtMotivo.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            TramiteUrgente urgencia = new TramiteUrgente
            {
                DNI = txtDNI.Text,
                Nombre = txtNombre.Text,
                Tipo = cmbTipoTramite.SelectedItem.ToString(),
                Motivo = txtMotivo.Text,
                FechaHora = DateTime.Now
            };

            pilaUrgencias.Apilar(urgencia);
            MessageBox.Show("Urgencia registrada correctamente.");
            LimpiarCampos();
        }

        private void btnAtenderUrgencia_Click(object sender, EventArgs e)
        {
            Tramite atendido = pilaUrgencias.Desapilar();

            if (atendido != null)
            {
                historial.AgregarOrdenado(atendido);
                MessageBox.Show("Urgencia atendida y enviada al historial.");
                MostrarPila();
            }
            else
            {
                MessageBox.Show("No hay urgencias pendientes.");
            }
        }

        private void btnVerPila_Click(object sender, EventArgs e)
        {
            MostrarPila();
        }

        private void MostrarPila()
        {
            dataUrgencias.Rows.Clear();
            foreach (var tramite in pilaUrgencias.ObtenerTodos())
            {
                dataUrgencias.Rows.Add(tramite.DNI, tramite.Nombre, tramite.Tipo, tramite.Motivo, tramite.FechaHora);
            }
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtMotivo.Clear();
            cmbTipoTramite.SelectedIndex = 0;
        }

        public void AsignarPila(PilaUrgencias p)
        {
            pilaUrgencias = p;
        }

    }
}
