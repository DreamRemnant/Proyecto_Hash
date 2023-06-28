namespace Proyecto_Hash
{
    internal class ListaLigada
    {
        Nodo nodoInicial;
        public ListaLigada(string valor)
        {
            nodoInicial = new Nodo(valor);
        }
        public void Agregar(string valor)
        {
            Nodo nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            nodoActual.Siguiente = new Nodo(valor);
        }

        public void Relacionar(ListaLigada vertice)
        {
            Agregar(vertice.nodoInicial.Valor);
        }

        public string ObtenerLista()
        {
            Nodo nodoActual = nodoInicial;
            string valores = "\""+nodoInicial.Valor+ "\"";
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                valores += " -- \"" + nodoActual.Valor+ "\"";
            }
            return valores;
        }
    }
}
