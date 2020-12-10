using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime Data;

        protected float valor;
        private string desconto;
        private DateTime vencimento;
    
        //Método
        public string cancelar(){
           return "";

        }
        public abstract string Desconto(int valor);
     

    }
}