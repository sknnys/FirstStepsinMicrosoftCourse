using System;

public class Mensagem
{
    public static void DisplayMessage()
    {
        string nome = "bob";
        int mensagem = 3;
        decimal temp = 34.4m;
        
        Console.WriteLine($"Hello, {nome}! You have {mensagem} messages in your inbox. The temperature is {temp} Celsius.");
    }
}
