using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Cartao: Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira");
            this.bandeira = Console.ReadLine();
            Console.WriteLine("Digite o nome do titular");
            this.titular = Console.ReadLine();
            Console.WriteLine("Digite o número");
            this.numero = Console.ReadLine();
            Console.WriteLine("Digite o CVV");
            this.cvv = Console.ReadLine();
            return "Cartão salvo";
        }
    }
}