internal class Program
{
    /*FUNÇÃO AUXILIAR*/
    public static void Troca(double[] vetor,int i, int j){
        double aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }

    static void BubbleSort(double[] vetor){
        
        int fim = vetor.Length - 1; /*Ultimo elemento do vetor*/
        int pos; 

        do
        {
            pos = -1; /*Posicionado antes do indice do primeiro elemento, variavel onde é guardado o indece da ultima troca. Ou seja se não houver troca o indice vale -1 caso houver troca o indice equivale ao indice da ultima troca .*/

            for (int i = 0; i < fim; i++)
            {
                if(vetor[i] > vetor[i + 1]){
                    Troca(vetor, i, i + 1);
                    pos = i;
                }
            }
            fim = pos;
        } while (fim > 0);

    }

    static void BubbleSort(double[] vetor){
        int fim = vetor.Length - 1; /*Ultimo elemento do vetor*/
        int pos = 0;
        bool troca = true;

        while (troca)
        {
            troca = false;
            for (int i = 0; i < fim; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    Troca(vetor,i, i + 1);
                    pos = i;
                    troca = true;
                }
            }
            fim = pos - 1;
        }
    }

    private static void Main(string[] args)
    {
        double[] vetor = new double[]{23,12,27,20,25};
        BubbleSort(vetor);
        Imprime(vetor);
    }

    static void Imprime(double[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}