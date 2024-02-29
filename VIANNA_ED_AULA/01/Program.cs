internal class Program
{
    
    /* 1) Faça um procedimento recursivo que receba um vetor de inteiros e imprima todos os elementos deste vertor*/

    static void Imprime(int[] vetor, int indice = 0){
        if(indice >= vetor.Length){
            Console.WriteLine();
            return;
        }
        Console.WriteLine($"{vetor[indice]}");
        Imprime(vetor, indice + 1);
    }

    private static void Main(string[] args)
    {
        var vetor = new int[]{1,2,4,5};
        Imprime(vetor);
    }

    /* 2) Faça uma função recursiva que receba um vetor de inteiros por parâmetro e retorne a soma dos elementos pertencentes á este vetor*/

    /*static int Somar(int[] vetor, int indice = 0, int soma = 0){
        if(indice >= vetor.Length){
            return soma;
            soma+= vetor[indice];
            return Somar(vetor,indice + 1,soma);
        }
    */
        static int Somar(int[] vetor, int indice = 0, int soma = 0){
        if(indice >= vetor.Length){
            return soma;
            soma+= vetor[indice];
            return Somar(vetor,indice + 1,soma);
        }
    
    /*
    static int Somar(int[] vetor, int indice = 0)
    {
        if (indice >= vetor.Length)
            return 0;
        
        return vetor[indice] + Somar(vetor, indice + 1);
    }

    static void Imprime(int[] vetor, int indice = 0)
    {
        if (indice >= vetor.Length)
        {
            Console.WriteLine();
            return;
        }

        Console.Write($"{vetor[indice]}  ");
        Imprime(vetor, indice + 1);
    }
    */
    }
    
}