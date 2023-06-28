namespace Proyecto_Hash
{
    internal class ListaLigada
    {
        Nodo nodoInicial;
        public ListaLigada()
        {
            nodoInicial = new Nodo();
        }
        public void Agregar(string valor)
        {
            Nodo nodoActual = nodoInicial;
            if (nodoInicial.Valor == "")
            {
                nodoInicial.Valor = valor;
                return;
            }

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
            string valores = nodoInicial.Valor;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                valores += "--"+nodoActual.Valor;
            }
            return valores;
        }
    }
}
