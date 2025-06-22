namespace Sistema_de_Gestión_de_Trámites
{
    public class NodoPila
    {
        public TramiteUrgente Dato { get; set; }
        public NodoPila Siguiente { get; set; }

        public NodoPila(TramiteUrgente dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
