namespace AulaPOO_Abstracao.classes {
    public class Cartao : Pagamento
    {
        public string bandeira;
       public string numero;
       public string titular;
       public string cvv;

        public override string Desconto(int valor)
        {
            throw new System.NotImplementedException();
        }

        public string salvarCartao(){
           return "";
       }
    }
}