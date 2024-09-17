using System;

namespace SistemaGestaoPedidos
{
    public class PedidoInternacional : Pedido
    {
        private const double TAXA_IMPORTACAO = 0.20;

        public PedidoInternacional(int idPedido, DateTime dataPedido, double valor)
            : base(idPedido, dataPedido, valor) { }

        public override double CalcularTotal()
        {
            return Valor * (1 + TAXA_IMPORTACAO);
        }
    }
}
