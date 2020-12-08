using System;
using POO_Encapsulamento.Classes.cs;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m =new MasterCard();
            m.NomeTitular = "Gustavo Henrique da Silva Santos";
            m.Numero = "3654 5698 5641 2358";
            m.Bandeira = "Cielo";
            m.Cvv = "134";

            Console.WriteLine($"Titular -> {m.NomeTitular} \nNumero do Cartao -> {m.Numero} \nBandeira -> {m.Bandeira} \nCodigo de verificação -> {m.Cvv}");
            
        }
    }
}
