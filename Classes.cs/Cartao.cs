namespace POO_Encapsulamento.Classes.cs
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{return numero;} // Capturar o valor
            set{numero = value;} // Definir o valor
            }
        // -------------------------------
        private string nomeTitular;
        public string NomeTitular{get;set;}
        // -------------------------------
        private string bandeira;
        public string Bandeira{get;set;}
        // -------------------------------
        protected string token = "256987";
        public string Token{get;}
        // -------------------------------
        private string cvv;
        public string Cvv{get;set;}
        // -------------------------------
        protected float limite = 5000;
        public float Limite{get;set;}
        // -------------------------------

        public string RegistrarCompra(bool validado){
            return "";
        }
    }
}