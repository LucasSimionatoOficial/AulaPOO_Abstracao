using System;

namespace AulaPOO_Abstracao.classes
{
    public class Credito: Cartao
    {
        private float limite = 3000;

        public void Pagar(float valor){
            this.valor = valor;
            this.limite = this.limite - this.valor;
            Console.WriteLine($"Valor pago. seu limite atual e de {this.limite}");
        }
    }
}