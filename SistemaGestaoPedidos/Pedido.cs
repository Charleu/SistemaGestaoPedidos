using System;

namespace SistemaGestaoPedidos
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public double Valor { get; set; }

        public Pedido(int idPedido, DateTime dataPedido, double valor)
        {
            IdPedido = idPedido;
            DataPedido = dataPedido;
            Valor = valor;
        }

        public virtual double CalcularTotal()
        {
            return Valor;
        }
    }
}
