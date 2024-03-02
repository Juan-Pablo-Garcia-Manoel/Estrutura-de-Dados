internal class Program
{
    public static int MDC_RECURSIVIDADE(int a, int b){ /*A>B*/
        if(b == 0)
            return a;
        else{
            Console.WriteLine($"Chamando MDC_RECURSIVIDADE({b}, {a % b})");
            return MDC_RECURSIVIDADE(b,a % b);
        }
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine(MDC_RECURSIVIDADE(48,18));
        Console.WriteLine(7%3);
        Console.WriteLine(20%15);
    }
}