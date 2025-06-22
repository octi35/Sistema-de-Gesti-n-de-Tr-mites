using System.Collections.Generic;

namespace Sistema_de_Gestión_de_Trámites
{
    public class ListaFinalizados
    {
        private NodoLista primero;

        public ListaFinalizados()
        {
            primero = null;
        }

        public void AgregarOrdenado(Tramite tramite)
        {
            NodoLista nuevo = new NodoLista(tramite);

            // Si está vacía o el nuevo trámite va primero
            if (primero == null || tramite.FechaHora < primero.Dato.FechaHora)
            {
                nuevo.Siguiente = primero;
                primero = nuevo;
            }
            else
            {
                NodoLista actual = primero;
                while (actual.Siguiente != null && actual.Siguiente.Dato.FechaHora <= tramite.FechaHora)
                {
                    actual = actual.Siguiente;
                }

                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public List<Tramite> ObtenerTodos()
        {
            List<Tramite> lista = new List<Tramite>();
            NodoLista actual = primero;

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
        }


    }
}
