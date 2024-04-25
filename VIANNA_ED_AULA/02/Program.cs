namespace _02;

class Program
{
    static void Main(string[] args)
    {
        var lista = new ListaEncadeada();

        lista.AdicionarNoInicio(10);
        lista.AdicionarNoInicio(7);
        lista.AdicionarNoInicio(2);
        lista.AdicionarNoFinal(50);
        lista.AdicionarNoFinal(100);

        var noAtual = lista.Primeiro;

        while (noAtual != null)
        {
            Console.Write($"{noAtual.Valor}  ");
            noAtual = noAtual.Proximo;
        }
    }
}
