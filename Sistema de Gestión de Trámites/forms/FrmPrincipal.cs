using System;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Trámites
{
    public partial class FrmPrincipal : Form
    {
        // Estructuras compartidas
        ColaTramites cola = new ColaTramites();
        PilaUrgencias pila = new PilaUrgencias();
        ListaFinalizados historial = new ListaFinalizados();

        // FORMULARIOS COMPARTIDOS (solución)
        FrmTramitesGenerales frmTramites;
        FrmUrgencias frmUrgencias;
        FrmHistorial frmHistorial;
        FrmSimulacion frmSimulacion;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        

        private void CargarFormularioEnTab(Form formulario, TabPage pestaña)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pestaña.Controls.Clear();
            pestaña.Controls.Add(formulario);
            formulario.Show();
        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            // Crear formularios una sola vez
            frmTramites = new FrmTramitesGenerales();
            frmUrgencias = new FrmUrgencias();
            frmHistorial = new FrmHistorial();
            frmSimulacion = new FrmSimulacion();

            // Asignar estructuras compartidas
            frmTramites.AsignarCola(cola);
            FrmTramitesGenerales.historial = historial;

            frmUrgencias.AsignarPila(pila);
            FrmUrgencias.historial = historial;

            FrmHistorial.historial = historial;

            FrmSimulacion.cola = cola;
            FrmSimulacion.pila = pila;
            FrmSimulacion.historial = historial;

            // Cargar formularios en tabs
            CargarFormularioEnTab(frmTramites, tabTramites);
            CargarFormularioEnTab(frmUrgencias, tabUrgencias);
            CargarFormularioEnTab(frmHistorial, tabHistorial);
            CargarFormularioEnTab(frmSimulacion, tabSimulacion);
        }
    }
}
