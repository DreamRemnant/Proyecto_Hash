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
    }
}
