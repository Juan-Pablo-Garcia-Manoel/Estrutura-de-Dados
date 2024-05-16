internal class Program
{
    /*
    Faça um procedimento que receba o montante reservado para a aposentadoria de uma pessoa e a quantia que ela pretende retirar por mês. 
    
    O montante reservado é corrigido a cada mês com a taxa de 0,55%, aplicada logo após a retirada. 
    
    O procedimento deve imprimir o montante (após a retirada e a correção), mês a mês. 
    
    O procedimento também deve imprimir o número de meses em que a pessoa conseguirá fazer a sua retirada.
    
    Restrição: não utilize comandos de repetição.
    */
    
    public static void aposentadoria(double montante, double saqueDesejado, int atualizaMes = 0, int qtdMeses = 0){
        
        double taxa = 0.0055;
        double[] mes = new double[12];

        if(atualizaMes < mes.Length){

            double aux = montante * taxa;
            montante = (montante - aux) - saqueDesejado;
            mes[atualizaMes] = montante;

            Console.WriteLine($"Montante no mês {atualizaMes + 1}: {mes[atualizaMes]:F2}");
                
            if(mes[atualizaMes] > 0){
                qtdMeses = qtdMeses + 1;
                aposentadoria(montante,saqueDesejado,atualizaMes + 1, qtdMeses);
            }else{
                Console.WriteLine($"Quantidade de meses permitido saque: {qtdMeses}");
            }
        }else{
            Console.WriteLine($"Quantidade de meses permitido saque: {qtdMeses}");
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