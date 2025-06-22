namespace Sistema_de_Gestión_de_Trámites
{
    public class NodoCola
    {
        public Tramite Dato { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(Tramite dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
