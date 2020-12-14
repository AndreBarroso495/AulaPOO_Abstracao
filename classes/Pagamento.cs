using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime data;
        public DateTime Data{
            get{return DateTime.Now;}
        }


        protected float valor;
        public float Valor{
            get{return valor;}
            set{valor = value;}
        }
        private string desconto;
        private DateTime vencimento;
    
        //Método
        public string cancelar(){
           return "";

        }
        public abstract string Desconto(int valor);
     

    }
}