using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Pedro";
            obj.idade = 30;
            obj.mensagem();

        }
    }
}
