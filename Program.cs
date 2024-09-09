// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Soma soma = new Soma();

        // Chama o método DisplayMessage da classe AulaCourse
        Console.WriteLine("Mensagem de \"Mensagem:\"");
        Mensagem.DisplayMessage();
        Console.WriteLine("\nMensagem de \"FormatMensagem:\"");
        FormatMensagem.DisplayMessage();
        Unicode.DisplayMessage();
        Concat.DisplayConcat();
        Interpolation.DisplayInterpolation();
        Teste.DisplayTeste();
        double resultado = soma.SomaDoisValores(7,3);
        
        double final = (resultado / 100);
        Console.WriteLine("resultado divido: "+final);
    }
}
