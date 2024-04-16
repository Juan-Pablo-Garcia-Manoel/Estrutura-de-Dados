namespace _09;

class Program
{
    static void troca(double[] vet, int i, int j){
        double aux = vet[i];
        vet[i] = vet[j];
        vet[j] = aux;
    }

    static void BubbleSort(double[] vet){
        
    }

    static void imprimir(double[] vet, int i = 0){
        if(i < vet.Length){
            Console.WriteLine("{0}",vet[i]);
            imprimir(vet, i + 1);
        }
    }

    static void Main(string[] args)
    {
        double[] vet = new double[]{5,3,4,1};
        BubbleSort(vet);
        imprimir(vet);
    }
}
