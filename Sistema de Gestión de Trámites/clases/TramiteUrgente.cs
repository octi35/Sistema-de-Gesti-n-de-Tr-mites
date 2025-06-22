namespace Sistema_de_Gestión_de_Trámites
{
    public class TramiteUrgente : Tramite
    {
        public string Motivo { get; set; }

        public TramiteUrgente() { }

        public TramiteUrgente(string dni, string nombre, string tipo, string motivo)
            : base(dni, nombre, tipo)
        {
            Motivo = motivo;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Motivo: {Motivo}";
        }
    }
}
