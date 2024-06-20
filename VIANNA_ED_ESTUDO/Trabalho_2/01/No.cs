public class No
{
    public char Value;
    public No Esquerda;
    public No Direita;

    public No(char value)
    {
        Value = value;
        Esquerda = null;
        Direita = null;
    }
}