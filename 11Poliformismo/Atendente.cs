using System;

class Atendente : Imposto
{
    
        // Métodos
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$"+(salario * 0.12));
    }
}