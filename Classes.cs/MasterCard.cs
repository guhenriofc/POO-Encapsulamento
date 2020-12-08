namespace POO_Encapsulamento.Classes.cs
{
    public class MasterCard : Cartao
    {
        private int parcelas;
        public void ExibirLimite(){
            System.Console.WriteLine(this.limite);
        }
    }
}