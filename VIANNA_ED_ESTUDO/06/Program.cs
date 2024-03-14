class program {
    public static void Main(string[] args){
    
    var vet = new int[]{7,3,5,2,8,3};
    OrdenarPeloMetodoBolha(vet);
    Imprimir(vet);

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
        for(int i = 0; i < vet.Length, i++){
            indiceMenor = i;
            
            for(int j = 1 + 1; j < vet.Length, j++){
                if(vet[j] < vet[indiceMenor])
                    indiceMenor = j;
            }    

            if(indiceMenor != i){
                aux = vet[i];
                vet[i] = vet[indiceMenor];
                vet[indiceMenor] = aux;
            }
        }
    }

    static void Troca(double[] vet, int i, int j){
        double aux;
        aux = vet[i];
        vet[i] = vet[j];
        vet[j] = aux;
    }

    static void Imprimir(int[] vet){

    }
}
