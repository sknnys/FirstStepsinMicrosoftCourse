using System;

public class Program {
    public static void Main() {
        Console.WriteLine("Iniciando o programa...");
        Mensagem.DisplayMessage();
        Console.WriteLine("Mensagem exibida.");
        Soma soma = new Soma();
        Console.WriteLine(soma.SomaDoisValores(2, 3));
        Unicode.DisplayMessage();
        FormatMensagem.DisplayMessage();
        Concat.DisplayConcat();
        Console.WriteLine("Programa concluído.");
        DecimalQuotient.DisplayMessage();
        RestoDivisao.DisplayMessage();
    }
}
