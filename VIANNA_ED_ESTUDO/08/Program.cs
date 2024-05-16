namespace _08;

class Program
{
    static void ImprimirDivisores(int numero, int divisor = 1){
        
        if (divisor <= numero)
        {
            if(numero % divisor == 0){
                Console.WriteLine($"{divisor}");
            }
            ImprimirDivisores(numero, divisor + 1);
        }
    }

    /*static void ImprimirDivisores(int numero){
        ImprimirDivisores(numero,1);
    }*/

    static void Main(string[] args)
    {
        int num;

        Console.Write("Informe um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        ImprimirDivisores(num);
    }
}
