namespace _03;

class Program
{
    static void Main(string[] args)
    {
        int a = 25;
        int b = 5;

        Func<int,int,int> minhaSoma = minhaSoma;

        Console.WriteLine("Minha soma: {0}", minhaSoma(a,b));
    }

    static int Soma(int a, int b){
        int soma = a + b;
        return soma;
    }
}
