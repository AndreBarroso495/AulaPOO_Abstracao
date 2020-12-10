using System;

namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public override string Desconto(int valor)
        {
            throw new NotImplementedException();
        }

        public void Registrar(){
           Console.WriteLine("Registrado");
        }
    }
}