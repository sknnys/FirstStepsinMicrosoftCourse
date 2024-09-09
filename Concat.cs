using System;

public class Concat {
    public static void DisplayConcat() {
        string sobrenome = " Silva\" ";
        string nome = "\"hs" +sobrenome;
        string mensagem = "OLÁ " + nome.ToUpper() + "SEJA BEM VINDO!";
        Console.WriteLine(mensagem);
    }
}
