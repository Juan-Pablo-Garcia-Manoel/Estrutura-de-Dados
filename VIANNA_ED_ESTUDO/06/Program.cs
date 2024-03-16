internal class Program {
    public static void Main(string[] args){
    
    var vet = new int[]{7,3,5,2,8,3};
    
    OrdenarPeloMetodoBolha(vet);
    OrdenarPorInsercao(vet);
    OrdenarPorSelecao(vet);
    
    Imprimir(vet);

    }

    public static void Troca(int[] vetor,int i, int j){
        int aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }

    static void OrdenarPeloMetodoBolha(int[] vetor){
        
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
    
    static void OrdenarPorInsercao(int[] vet){
        int atual;
        int i;

        for (int ultimoOrdenado = 0; ultimoOrdenado < vet.Length - 1; ultimoOrdenado++)
        {
            atual = vet[ultimoOrdenado + 1];
            for (i = ultimoOrdenado; i >= 0 && vet[i] > atual; i--)
            {
                vet[i + 1] = vet[i];
            }

            vet[i + 1] = atual;
        }
    }

    static void OrdenarPorSelecao(int[] vet){
        
        int indiceMenor, aux;        
        
        for(int i = 0; i < vet.Length - 1; i++)
        {
            
            indiceMenor = i;
            
            for(int j = i + 1; j < vet.Length; j++)
                if(vet[j] < vet[indiceMenor])
                    indiceMenor = j;
                

            if(indiceMenor != i){
                 aux = vet[i];
                vet[i] = vet[indiceMenor];
                vet[indiceMenor] = aux;
            }
        }
    }

    static void Imprimir(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("{0} ", vetor[i]);
        }
    }
}
