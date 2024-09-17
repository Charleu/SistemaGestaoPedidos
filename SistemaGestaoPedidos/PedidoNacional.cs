using System;

namespace SistemaGestaoPedidos
{
    public class PedidoNacional : Pedido
    {
        private const double IMPOSTO_NACIONAL = 0.10;

        public PedidoNacional(int idPedido, DateTime dataPedido, double valor)
            : base(idPedido, dataPedido, valor) { }

        public override double CalcularTotal()
        {
            return Valor * (1 + IMPOSTO_NACIONAL);
        }
    }
}
