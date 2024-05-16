class ListaEncadeada
{
    public void AdicionarNoInicio(int valor)
    {
        var novoNo = new No { Valor = valor };

        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }
    }

    public void AdicionarNoFinal(int valor)
    {
        var novoNo = new No { Valor = valor };

        if (ultimo == null)
            ultimo = primeiro = novoNo;
        else
        {
            ultimo.Proximo = novoNo;
            ultimo = novoNo;
        }
    }

    public void RemoverNoInicio()
    {
        if (primeiro == null)
            throw new Exception("Não é possível remover um elemeno de uma lista vazia.");

        primeiro = primeiro.Proximo;

        if (primeiro == null)
            ultimo = null;
    }

    public void RemoverNoFinal()
    {
        if (primeiro == null)
            throw new Exception("Não é possível remover um elemeno de uma lista vazia.");

        if (primeiro.Proximo == null)
        {
            primeiro = null;
        }
        else
        {
            No penultimo = primeiro;

            while (penultimo?.Proximo?.Proximo != null)
            {
                penultimo = penultimo.Proximo;
            }

            if (penultimo != null)
            {
                penultimo.Proximo = null;
                ultimo = penultimo;
            }
        }
    }

    public void ParaCada(Action<int> visitar)
    {
        var atual = primeiro;

        while (atual != null)
        {
            visitar(atual.Valor);
            atual = atual.Proximo;
        }
    }

    private No? primeiro = null;
    private No? ultimo = null;
}