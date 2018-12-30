using System;
namespace ByteBank.Funcionarios
{
    // Diretor é uma herança da classe funcionário
    public class Diretor : Funcionario
    {
        // Parâmetros herdados da classe funcionário
        // public string Nome { get; set; }
        // public string CPF { get; set; }
        // public double Salario { get; set; }

        public override double GetBonificacao()
        {
             // return Salario * 1.00;

            // Diretor recebe 100% de bonificação + a bonificação de 
            // um funcionário normal
            return ((Salario * 1.00) + base.GetBonificacao());
        }
    }
}
