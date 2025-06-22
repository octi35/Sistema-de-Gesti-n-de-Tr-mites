using System.Collections.Generic;

namespace Sistema_de_Gestión_de_Trámites
{
    public class PilaUrgencias
    {
        private NodoPila tope;

        public PilaUrgencias()
        {
            tope = null;
        }

        public void Apilar(TramiteUrgente tramite)
        {
            NodoPila nuevo = new NodoPila(tramite);
            nuevo.Siguiente = tope;
            tope = nuevo;
        }

        public TramiteUrgente Desapilar()
        {
            if (tope == null) return null;

            TramiteUrgente dato = tope.Dato;
            tope = tope.Siguiente;
            return dato;
        }

        public List<TramiteUrgente> ObtenerTodos()
        {
            List<TramiteUrgente> lista = new List<TramiteUrgente>();
            NodoPila actual = tope;

            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return lista;
        }

        public bool EstaVacia()
        {
            return tope == null;
        }

        public void Vaciar()
        {
            tope = null;
        }
    }
}
