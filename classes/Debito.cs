using System;

namespace AulaPOO_Abstracao.classes
{
    public class Debito: Cartao
    {
        private float saldo = 600;

        public void Pagar(float valor){
            this.valor = valor;
            this.saldo = saldo - this.valor;
            Console.WriteLine($"Valor pago. seu saldo atual é de {this.valor}");
        }
    }
}