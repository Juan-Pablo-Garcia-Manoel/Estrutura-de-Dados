internal class Program
{
    public static int multiplicacao(int a, int b){
        if(b == 0)
            return 0;
        else
            return a + multiplicacao(a,b - 1);
    }

    public static int fatorial(int a){
        if(a == 0)
            return 1;
        else
            return a * fatorial(a - 1);
    }

    public static void imprimir(string mensagem, int numeroVezes){
        Console.WriteLine($"Empilhou. Valor parâmetro: {numeroVezes}");
        if(numeroVezes > 0){
            imprimir(mensagem, numeroVezes - 1);
            Console.WriteLine($"{numeroVezes}) {mensagem}");
        }
        Console.WriteLine($"Desempilhou. Valor parâmetro: {numeroVezes}");
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(multiplicacao(2,4));
        Console.WriteLine(fatorial(4));
        imprimir("Olá mundo", 5);
    }
}