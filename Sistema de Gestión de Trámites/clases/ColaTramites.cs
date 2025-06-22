using System.Collections.Generic;

namespace Sistema_de_Gestión_de_Trámites
{
    public class ColaTramites
    {
        private NodoCola primero;
        private NodoCola ultimo;

        public ColaTramites()
        {
            primero = null;
            ultimo = null;
        }

        public void Encolar(Tramite t)
        {
            NodoCola nuevo = new NodoCola(t);
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public Tramite Desencolar()
        {
            if (primero == null) return null;

            Tramite dato = primero.Dato;
            primero = primero.Siguiente;
            if (primero == null) ultimo = null;
            return dato;
        }

        public List<Tramite> ObtenerTramites()
        {
            List<Tramite> lista = new List<Tramite>();
            NodoCola actual = primero;

            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return lista;
        }

        public bool EstaVacia()
        {
            return primero == null;
        }

        public void Vaciar()
        {
            primero = null;
            ultimo = null;
        }
    }

}
