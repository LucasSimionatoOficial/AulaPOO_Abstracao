using System;
using AulaPOO_Abstracao.classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = true;
            float valor = 300;
            Console.WriteLine("O valor e de 300 reais");
            do{
                Console.WriteLine("Como deseja pagar");
                Console.WriteLine("Digite 1 para boleto");
                Console.WriteLine("Digite 2 para cartão de crédito");
                Console.WriteLine("Digite 3 para cartão de débito");
                switch (Console.ReadLine())
                {
                    case "1":
                        sair = false;
                        Boleto boleto = new Boleto();
                        Console.WriteLine("Digite o código de barras");
                        Console.WriteLine(boleto.Desconto(valor));
                        boleto.Registrar();
                        break;
                    case "2":
                        sair = false;
                        Credito credito = new Credito();
                        Console.WriteLine("Insira os dados do cartão");
                        Console.WriteLine(credito.SalvarCartao());
                        credito.Pagar(valor);
                        break;
                    case "3":
                        sair = false;
                        Debito debito = new Debito();
                        Console.WriteLine("Insira os dados do cartão");
                        Console.WriteLine(debito.SalvarCartao());
                        debito.Pagar(valor);
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            } while(sair);
            
        }
    }
}
