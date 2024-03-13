internal class Program
{
    /*FUNÇÃO AUXILIAR*/
    public static void Troca(double[] vetor,int i, int j){
        double aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }

    static void BubbleSort(double[] vetor){
        
        int fim, pos;
        fim = vetor.Length - 1; /*Ultimo elemento do vetor*/

        do
        {
            pos = - 1; /*Posicionado antes do indice do primeiro elemento, variavel onde é guardado o indece da ultima troca. Ou seja se não houver troca o indice vale -1 caso houver troca o indice equivale ao indice da ultima troca .*/

            for (int i = 0; i < fim; i++)
            {
                if(vetor[i] > vetor[i + 1]){
                    Troca(vetor, i, i + 1);
                    pos = i;
                }
                fim = pos;
            }

        } while (fim > 0);

    }

    static void BubbleSortBool(double[] vetor){
        
        int fim, pos;
        fim = vetor.Length - 1; /*Ultimo elemento do vetor*/
        pos = 0;

        bool troca = true;

        while(troca)
        {
            troca = false;
            for (int i = 0; i < fim; i++)
            {
                if(vetor[i] > vetor[i + 1]){
                    Troca(vetor, i, i + 1);
                    pos = i;
                    troca = true;
                }
                fim = pos;
            }
        }
    }

    private static void Main(string[] args)
    {
          
    }
}