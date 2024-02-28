using System.Reflection.Metadata.Ecma335;

internal class Program
{
    /*Primeiro Exemplo*/
    public static int Multiplicar_1(int m, int n)
    {
        int resultado = 0;
        for (int i = 0; i < n; i++)
        {
            resultado += m;
        }
        return resultado;
    } 

    /*Segundo Exemplo*/
    public static int Multiplicar_2(int m, int n)
    {
        if(n == 0)
            return 0; /*Exemplo 2 x 0 = 0 */
        else
        {
            return m + (Multiplicar_2(m,n-1)); 
            /*Exemplo 
            2 + (multiplcar(2,3-1)) = 
            2 + (2 * 2) = 
            2 + 4 = 6*/
        }
    } 

    /*Terceiro Exemplo*/
    public static int fatorial(int n){
        if(n == 0) 
            return 1;
        else{
            return n * fatorial(n -1);
        }
    } 


    private static void Main(string[] args)
    {
        Console.WriteLine(Multiplicar_1(2,3));
        Console.WriteLine(Multiplicar_2(2,3));  
        Console.WriteLine(fatorial(9));
    }

    /*private static void Main(string[] args)
    {
        int n1,n2;
        Console.Write("Digite o valor de N1: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o valor de N2: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O resultado da multiplicação equivale: " +Multiplicar(n1,n2));       
    }*/

}