public class Arvore
{
    public No Root;

    public Arvore()
    {
        Root = null;
    }

    public void PreOrdem(No no)
    {
        if (no == null)
            return;

        Console.Write(no.Value + " ");
        PreOrdem(no.Esquerda);
        PreOrdem(no.Direita);
    }

    public void InOrdem(No no)
    {
        if (no == null)
            return;

        InOrdem(no.Esquerda);
        Console.Write(no.Value + " ");
        InOrdem(no.Direita);
    }

    public void PostOrdem(No no)
    {
        if (no == null)
            return;

        PostOrdem(no.Esquerda);
        PostOrdem(no.Direita);
        Console.Write(no.Value + " ");
    }
}
