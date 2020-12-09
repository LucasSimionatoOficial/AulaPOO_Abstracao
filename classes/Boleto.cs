using System;

namespace AulaPOO_Abstracao.classes
{
    public class Boleto: Pagamento
    {
        private string codigoDeBarras;


        public string Desconto(float valor){
            this.valor = valor*0.88f;
            return $"Desconto de 12%, voce pagara {this.valor} reais";
        }
        public void Registrar(){
            this.codigoDeBarras = Console.ReadLine();
            Console.WriteLine("Boleto registrado");
        }
    }
}