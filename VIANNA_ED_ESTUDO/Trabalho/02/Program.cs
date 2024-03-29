internal class Program{
    
    /*
    Faça uma função que receba um vetor de números inteiros por parâmetro e multiplique
    por -1 todos os elementos negativos desse vetor. A função deve retornar o número de
    elementos negativos encontrados. Restrição: não utilize comandos de repetição.
    */

    public static int funcaoVetor(int[] vetorInteiro){
        return funcaoVetor(vetorInteiro,0);
    }

    public static int funcaoVetor(int[] vetorInteiro, int posicao){
        
        int qtdNegativos = 0;

        if(posicao < vetorInteiro.Length){
            
            if(vetorInteiro[posicao] < 0){
                vetorInteiro[posicao] *= -1;
                qtdNegativos++;
            }

            qtdNegativos += funcaoVetor(vetorInteiro, posicao + 1);
        }

        return qtdNegativos;

    }

    static void Imprimir(int[] vetorInteiro, int posicao = 0)
    {
        if (posicao < vetorInteiro.Length)
        {
            Console.Write("{0} ", vetorInteiro[posicao]);
            Imprimir(vetorInteiro, posicao + 1);
        }
    }
 
    public static void Main(string[] args){
        
        int resultado;

        int[] vetorInteiro = new int[]{0,2,-5,3,-7,-8};
        
        resultado = funcaoVetor(vetorInteiro);
        Console.WriteLine("Quantidade valores negativos encontrados: {0}",resultado);

        Imprimir(vetorInteiro);

    }

}