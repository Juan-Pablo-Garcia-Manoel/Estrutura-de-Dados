internal class Program{
    
    /*
    Faça uma função que receba um vetor de números inteiros por parâmetro e multiplique
    por -1 todos os elementos negativos desse vetor. A função deve retornar o número de
    elementos negativos encontrados. Restrição: não utilize comandos de repetição.
    */

    public static int funcaoVetor(int[] vetorInteiro){
        int pos = vetorInteiro.Length;
        
        if(pos > 0){
            funcaoVetor(vetorInteiro.Length - 1);
            Console.WriteLine("{0}", vetorInteiro[pos]);
        }

        return vetorInteiro[pos];
    }
 
    public static void Main(string[] args){
        
        int[] vetorInteiro = new int[]{0,2,-5,3,-7};
        int resultado;

        resultado = funcaoVetor(vetorInteiro);
        Console.WriteLine("{0}",resultado);

    }

}