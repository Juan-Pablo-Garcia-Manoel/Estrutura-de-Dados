using System.ComponentModel;

internal class Program
{
    /*void SORT(int[] A)
    {
        int I,J,K,T;
        for(I = 0; I < (A.Length - 1); I++){
            J = I;
            for(K = (I + 1); K < A.Length; K++)
                if(A[K] < A[J])
                    J = K;
                T = A[I];
                A[I] = A[J];
                A[J] = T; 
        }
    }*/
 
    void MIN(int K, int[] A, ref int J){ 
    if (K < A.Length){
        if(A[K] < A[J])
             J = K;
            MIN(K + 1, A, ref J);
        }
    }

    void SORT1(int I, int[] A){
        int J,T;
        if(I < (A.Length - 1)){
            J = I;
            MIN (I + 1, A, ref J);
            T = A[I];
            A[I] = A[J];
            A[J] = T;
            SORT1 (I + 1, A);
        }
    }
    
    void SORT(int[] A){
        SORT1(0,A);
    }

    /*Iterativo*/
    int Fibonacci(int n){
        int ant = 1, atual = 1;
        for (int k = 3; k <= n; k++)
        {
            int aux = atual;
            atual = atual + ant;
            ant = aux;
        }
        return atual;
    }

    /*Recursivo*/
    int Fibonacci2(int n){
        if(n <= 2)
            return 1;
        else
            return Fibonacci2(n - 1) + Fibonacci(n - 2);
    }

    static int BuscaB(int[] v, int ini, int fim, int x){
        int meio = (ini + fim)/2; /*Ponto médio*/
        if(v[meio] ==x) return meio;
        if(ini == fim) return - 1;
        if (v[meio] > x) /*Busca na primeira metade*/
            return BuscaB(v, ini, meio-1, x);
        else /*Busca na segunda metade*/
            return BuscaB(v, meio + 1, fim, x);
    }

    static int BuscaBinaria(int[] v, int chave){
        return BuscaB(v,0,v.Length-1,chave);
    }

    private static void Main(string[] args)
    {
         int[] vetor = new int[]{0,1,1,2,5,8,9};
         int pos = BuscaBinaria(vetor,5);
    }

}