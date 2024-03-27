internal class Program{
    
    /*
    Faça uma função que receba um vetor de números inteiros por parâmetro e multiplique
    por -1 todos os elementos negativos desse vetor. A função deve retornar o número de
    elementos negativos encontrados. Restrição: não utilize comandos de repetição.
    */

    public static int funcaoVetor(int[] vetorInteiro){
        
        int posicao = vetorInteiro.Length;
        int aux = vetorInteiro[0];

        if(vetorInteiro[aux] == 0){
            return vetorInteiro[aux];
        }else{
            funcaoVetor(vetorInteiro[posicao] - 1);
        }

    }
 
    public static void Main(string[] args){
        
        int[] vetorInteiro = new int[]{0,2,-5,3,-7};
        int resultado;

        resultado = funcaoVetor(vetorInteiro);
        Console.WriteLine("{0}",resultado);

    }

}