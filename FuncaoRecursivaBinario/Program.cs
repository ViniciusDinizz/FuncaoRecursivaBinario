using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int valor;

        int[] binario = new int[8];
        int[] binariocop = new int[8];

        Console.Write("Valor a ser convertido: ");
        valor = int.Parse(Console.ReadLine());

        //Controle para não aceitar números negativos
        while(valor < 0) 
        {
            Console.Write("Valor negativo, digite outro: ");
            valor = int.Parse(Console.ReadLine());
        }

        //segunda array
        binariocop = converter(valor, 0,0);

        //Função recursiva para converter valor decimal em binário
        int[] converter(int valor, int cont, int resto)
        {
            if((valor == 1) && (resto%2 == 0) || (valor == 0))
            {
                resto = valor % 2;
                binario[cont] = resto;
                return binario;
            }
            else
            {
                resto = valor % 2;
                binario[cont] = resto;
                return converter(valor/2, cont+1, resto);
            }
            
        }

        //Imprimindo valores da array bináriocop
        for (int i = binario.Length - 1; i >= 0; i--)
        {
            Console.Write($" {binariocop[i]}");
        }
    }
}