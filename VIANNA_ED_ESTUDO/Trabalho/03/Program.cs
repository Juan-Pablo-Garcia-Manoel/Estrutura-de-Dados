internal class Program
{
    /*
    Faça um procedimento que receba o montante reservado para a aposentadoria de uma
    pessoa e a quantia que ela pretende retirar por mês. 
    
    O montante reservado é corrigido a cada mês com a taxa de 0,55%, aplicada logo após a retirada. 
    
    O procedimento deve imprimir o montante (após a retirada e a correção), mês a mês. 
    
    O procedimento também deve imprimir o número de meses em que a pessoa conseguirá fazer a sua retirada.
    
    Restrição: não utilize comandos de repetição.
    */
    
    public static void aposentadoria(double montante, double saqueDesejado, int atualizaMes = 0){
        double taxa = 0.0055, aux;
        string retirada;
        double[] mes = new double[12];

        if(mes[atualizaMes] <= mes.Length){

            Console.Write("Deseja sacar ? Digite (S) para Sim ou (N) para Não :");
            retirada = Convert.ToString(Console.ReadLine());

            if (retirada == "S" || retirada == "s" )
            {
                Console.Write("Informe o mês atual: ");
                atualizaMes = Convert.ToInt32(Console.ReadLine());

                aux = montante * taxa;
                montante = (montante - aux) - saqueDesejado;
                mes[atualizaMes] = montante;
            }else
            {
                Console.WriteLine("Montante: {0} e Saque Desejado: {1}",montante,saqueDesejado);
            }

        }

    }
    
    private static void Main(string[] args)
    {
        double montante, saqueDesejado;

        Console.Write("Informe o montante da aposentadoria: ");
        montante = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o montante da saque desejado: ");
        saqueDesejado = Convert.ToDouble(Console.ReadLine());

        aposentadoria(montante,saqueDesejado);
    }
}