internal class Program
{
    /*
        Faça uma função que ordene um vetor de inteiros passado por parâmetro utilizando o
        método bolha e retorne o número de trocas realizadas.
    */

    public static void Troca(int[] vetor, int i, int j)
    {
        int aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }

    static void Imprimir(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("{0} ", vetor[i]);
        }
    }

    static int OrdenarPeloMetodoBolha(int[] vetor)
    {
        int trocas = 0;
        int fim = vetor.Length - 1;
        int pos;
        do
        {
            pos = -1;

            for (int i = 0; i < fim; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    Troca(vetor, i, i + 1);
                    pos = i;
                    trocas++;
                }
            }
            fim = pos;
        } while (fim > 0);

        return trocas;
    }

    private static void Main(string[] args)
    {
        var vet = new int[] { 7, 3, 5, 2, 8, 3 };
        int trocas = OrdenarPeloMetodoBolha(vet);

        Console.WriteLine("Vetor ordenado:");
        Imprimir(vet);
        Console.WriteLine("\nNúmero de trocas: " + trocas);
        Console.ReadKey();
    }
}
