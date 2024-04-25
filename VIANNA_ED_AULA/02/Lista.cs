class ListaEncadeada
{
    public void AdicionarNoInicio(int valor)
    {
        var novoNo = new No { Valor = valor };

        novoNo.Proximo = primeiro;
        primeiro = novoNo;
    }

    public void AdicionarNoFinal(int valor)
    {
        var novoNo = new No { Valor = valor };

        if (primeiro == null)
            primeiro = novoNo;
        else
        {
            No ultimo = primeiro;

            while (ultimo.Proximo != null)
            {
                ultimo = ultimo.Proximo;
            }

            ultimo.Proximo = novoNo;
        }
    }

    public No? Primeiro { get { return primeiro; } }

    private No? primeiro = null;
}