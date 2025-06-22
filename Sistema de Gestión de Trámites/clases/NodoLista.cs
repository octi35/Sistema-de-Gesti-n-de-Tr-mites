namespace Sistema_de_Gestión_de_Trámites
{
    public class NodoLista
    {
        public Tramite Dato { get; set; }
        public NodoLista Siguiente { get; set; }

        public NodoLista(Tramite dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
