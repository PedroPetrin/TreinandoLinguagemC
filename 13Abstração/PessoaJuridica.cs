using System;

class PessoaJurica : Padrao
{

    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Jurídica R$"+(valor * 0.2));
    }

}