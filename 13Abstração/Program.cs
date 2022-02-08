using System;

namespace _13Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            PessoaJurica pj = new PessoaJurica();
            pj.taxaEmprestimo(1000);

        }
    }
}
