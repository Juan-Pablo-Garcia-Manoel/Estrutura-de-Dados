internal class Program
{

    /*
        Faça um procedimento que receba um número n inteiro e positivo. O procedimento deve
        imprimir todos os números do intervalo entre 0 e n que são divisíveis por 2 e por 3
        (simultaneamente). Restrição: não utilize comandos de repetição.
    */

    private static void Main(string[] args){
        int num;
        Console.Write("Informe um número inteiro positivo: ");
        num = Convert.ToInt32(Console.ReadLine());
        numerosDivisiveis(num);
    }

    public static void numerosDivisiveis(int num){
        if(num == 0){
            Console.WriteLine("{0} é um número divisivel por qualquer número natural.",num);
        }else{
            if(num < 0){
                Console.WriteLine("Não é permitido números negativos. ");
            }else{
                numerosDivisiveis(num - 1);
                if(num % 2 == 0 && num % 3 == 0){
                    imprimir(num);
                }
            }
        }
    }

    public static void imprimir(int num){
        Console.Write("{0} ",num);
    }

}