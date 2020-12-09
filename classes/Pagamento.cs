using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return "Compra cancelada";
        }
    }
}