using System;

namespace AulaPOO_Abstracao.classes
{
    public class Boleto: Pagamento
    {
        private string codigoDeBarras;

        public void Registrar(){
            this.codigoDeBarras = Console.ReadLine();
            Console.WriteLine("Boleto registrado");
        }
    }
}