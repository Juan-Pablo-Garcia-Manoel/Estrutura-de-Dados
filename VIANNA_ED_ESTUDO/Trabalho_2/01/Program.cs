namespace _01;

class Program
{
    /*
    
     Crie um programa que represente, em uma estrutura dinâmica, a árvore abaixo.
    No método principal (Main), crie três funções recursivas, sendo a primeira para
    imprimir os elementos da árvore em pré-ordem, a segunda em in-ordem e a terceira
    em pós-ordem.
    
       A
     /   \
    B     C
         / \
        D   E
       / \  /
      G  H I  
    
    */

    static void Main(string[] args)
    {
        Arvore arvore = new Arvore();

        /*Construção da árvore manualmente*/
        
        arvore.Root = new No('A');
        arvore.Root.Esquerda = new No('B');
        arvore.Root.Direita = new No('C');
        arvore.Root.Direita.Esquerda = new No('D');
        arvore.Root.Direita.Direita = new No('E');
        arvore.Root.Direita.Esquerda.Esquerda = new No('G');
        arvore.Root.Direita.Esquerda.Direita = new No('H');
        arvore.Root.Direita.Direita.Esquerda = new No('I');

        Console.WriteLine("Pré-ordem:");
        arvore.PreOrdem(arvore.Root);
        Console.WriteLine();

        Console.WriteLine("In-ordem:");
        arvore.InOrdem(arvore.Root);
        Console.WriteLine();

        Console.WriteLine("Pós-ordem:");
        arvore.PostOrdem(arvore.Root);
        Console.WriteLine();
    }
}
