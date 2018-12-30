using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;


        // Sobrecarga de funções que soma as bonificações de acordo
        // com o salário
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        // Função que retorna o total de bonificações
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
