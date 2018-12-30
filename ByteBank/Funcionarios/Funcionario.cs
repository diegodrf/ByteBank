using System;
namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // Parâmetros da classe
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        // Função que calcula a bonificação
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }

}
