using System;

namespace ClienteFidelidadeApp
{
    public class ClienteFidelidade
    {
        private decimal _saldo;

        public decimal Saldo => _saldo;

        public void AdicionarCompra(decimal valorCompra)
        {
            if (valorCompra < 0)
                throw new ArgumentException("O valor da compra não pode ser negativo.");
            _saldo += valorCompra; // 1 ponto por R$1
        }

        public void ResgatarPontos(decimal quantidade)
        {
            if (quantidade < 0)
                throw new ArgumentException("A quantidade de pontos para resgate não pode ser negativa.");
            if (quantidade > _saldo)
                throw new InvalidOperationException("Saldo insuficiente para resgate.");
            _saldo -= quantidade;
        }
    }
}
