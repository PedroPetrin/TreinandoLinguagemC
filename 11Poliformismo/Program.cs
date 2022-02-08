using System;

namespace _11Poliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanciar Estagiario
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("-----------");

            // Instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoE.valeAlimentacao(5000);
            objetoE.valeTransporte(5000);
            Console.WriteLine("-----------");

            // Instanciar Atendente
            Imposto objetoA = new Atendente();
            objetoE.valeAlimentacao(2000);
            objetoE.valeTransporte(2000);

        }
    }
}
