namespace Numero_De_Caracteres;

internal class Program
{
    static void Main()
    {
        /*
         criando um programa que pede ao usuário digitar quaisquer palavras 
        e depois exibir quantos caracteres tem nessa palavra.
        */

        //pedindo ao usuário para digitar algo.
        Console.WriteLine("Digite uma palavra: ");
        var palavra = Console.ReadLine(); // armazenando oque o usuário digitou
        if (string.IsNullOrEmpty(palavra)) // verificando caso o usuário digitou algo sem ser string
        {
            Console.WriteLine("Não é uma palavra");
            return; // sai do programa caso não seja uma string
        }
        else
        {   // aqui o Replace irá substituir o espaço em branco para sem espaço, antes de contar quantos caracteres tem na variavel.
            var numeroDePalavras = palavra.Replace(" ", "").Length; 
            // o Length irá contar o numero de caracteres atuais na variavel "palavra".
            Console.WriteLine(numeroDePalavras);
            //aqui irá monstrar o numero de caracteres, sem contar o espaço entre as palavras.
        }
    }
}