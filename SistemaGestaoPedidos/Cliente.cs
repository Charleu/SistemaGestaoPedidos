using System;

namespace SistemaGestaoPedidos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public Pedido[] Pedidos { get; set; }
        public int ContadorElementos { get; private set; }

        public Cliente(int tamanhoMaximo)
        {
            Pedidos = new Pedido[tamanhoMaximo];
            ContadorElementos = 0;
        }

        public void AdicionarPedido(Pedido pedido)
        {
            if (ContadorElementos < Pedidos.Length)
            {
                Pedidos[ContadorElementos] = pedido;
                ContadorElementos++;
            }
            else
            {
                Console.WriteLine("Limite máximo de pedidos atingido.");
            }
        }

        public void RemoverPedido(Pedido pedido)
        {
            for (int i = 0; i < Pedidos.Length; i++)
            {
                if (Pedidos[i] == pedido)
                {
                    Pedidos[i] = Pedidos[ContadorElementos - 1];
                    ContadorElementos--;
                    return;
                }
            }
            Console.WriteLine("Pedido não encontrado.");
        }

        public void ListarPedidos()
        {
            for (int i = 0; i < ContadorElementos; i++)
            {
                Console.WriteLine($"ID: {Pedidos[i].IdPedido}\n" + $"Data: {Pedidos[i].DataPedido}\n" + $"Total: {Pedidos[i].CalcularTotal().ToString("C")}");
            }
        }

        public double CalcularTotalPedidos()
        {
            double total = 0;
            for (int i = 0; i < ContadorElementos; i++)
            {
                total += Pedidos[i].CalcularTotal();
            }
            return total;
        }
    }
}

