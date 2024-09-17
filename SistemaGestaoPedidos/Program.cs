using System;

namespace SistemaGestaoPedidos
{
    class Program
    {
        private static int proximoIdPedido = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite seu nome:");
            string nomeCliente = Console.ReadLine();

            Cliente cliente = new Cliente(10);

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine($"Bem-vindo {nomeCliente} ao Sistema de Gestão de Pedidos");
                Console.WriteLine("Escolha o tipo de pedido:");
                Console.WriteLine("1. Pedido Nacional");
                Console.WriteLine("2. Pedido Internacional");
                Console.WriteLine("0. Sair");

                int escolhaTipoPedido = int.Parse(Console.ReadLine());

                if (escolhaTipoPedido == 0)
                {
                    continuar = false;
                    break;
                }

                int idPedido = proximoIdPedido++;
                DateTime dataPedido = DateTime.Now;
                double valor = 0.0;

                while (true)
                {
                    Console.Clear();
                    if (escolhaTipoPedido == 1) 
                    {
                        Console.WriteLine("Menu de Produtos Nacionais:");
                        Console.WriteLine("1. Smartphone - R$1000.00");
                        Console.WriteLine("2. Notebook - R$3000.00");
                        Console.WriteLine("3. Fone de Ouvido - R$200.00");
                        Console.WriteLine("4. Tablet - R$1500.00");
                        Console.WriteLine("5. Smartwatch - R$800.00");
                    }
                    else if (escolhaTipoPedido == 2) 
                    {
                        Console.WriteLine("Menu de Produtos Internacionais:");
                        Console.WriteLine("1. Roupas - R$80.00");
                        Console.WriteLine("2. Relógio - R$500.00");
                        Console.WriteLine("3. Bolsa - R$150.00");
                        Console.WriteLine("4. Óculos de Sol - R$120.00");
                        Console.WriteLine("5. Sapatos - R$200.00");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                    }
                    Console.WriteLine("0. Finalizar Pedido");

                    int escolhaMenu = int.Parse(Console.ReadLine());

                    if (escolhaMenu == 0)
                    {
                        break;
                    }

                    switch (escolhaMenu)
                    {
                        case 1:
                            if (escolhaTipoPedido == 1)
                            {
                                Console.WriteLine("Você escolheu Smartphone.");
                                valor += 1000.00;
                            }
                            else if (escolhaTipoPedido == 2)
                            {
                                Console.WriteLine("Você escolheu Roupas.");
                                valor += 80.00;
                            }
                            break;
                        case 2:
                            if (escolhaTipoPedido == 1)
                            {
                                Console.WriteLine("Você escolheu Notebook.");
                                valor += 3000.00;
                            }
                            else if (escolhaTipoPedido == 2)
                            {
                                Console.WriteLine("Você escolheu Relógio.");
                                valor += 500.00;
                            }
                            break;
                        case 3:
                            if (escolhaTipoPedido == 1)
                            {
                                Console.WriteLine("Você escolheu Fone de Ouvido.");
                                valor += 200.00;
                            }
                            else if (escolhaTipoPedido == 2)
                            {
                                Console.WriteLine("Você escolheu Bolsa.");
                                valor += 150.00;
                            }
                            break;
                        case 4:
                            if (escolhaTipoPedido == 1)
                            {
                                Console.WriteLine("Você escolheu Tablet.");
                                valor += 1500.00;
                            }
                            else if (escolhaTipoPedido == 2)
                            {
                                Console.WriteLine("Você escolheu Óculos de Sol.");
                                valor += 120.00;
                            }
                            break;
                        case 5:
                            if (escolhaTipoPedido == 1)
                            {
                                Console.WriteLine("Você escolheu Smartwatch.");
                                valor += 800.00;
                            }
                            else if (escolhaTipoPedido == 2)
                            {
                                Console.WriteLine("Você escolheu Sapatos.");
                                valor += 200.00;
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }

                    Console.WriteLine("Se deseja continuar aperte qualquer tecla.");
                    Console.ReadKey();
                }

                Pedido pedido;
                if (escolhaTipoPedido == 1)
                {
                    pedido = new PedidoNacional(idPedido, dataPedido, valor);
                }
                else if (escolhaTipoPedido == 2)
                {
                    pedido = new PedidoInternacional(idPedido, dataPedido, valor);
                }
                else
                {
                    Console.WriteLine("Opção inválida! Pedido não criado.");
                    continue;
                }

                cliente.AdicionarPedido(pedido);

                Console.WriteLine("\nDetalhes do Pedido:");
                Console.WriteLine($"Nome do Cliente: {nomeCliente}");
                Console.WriteLine($"ID do Pedido: {idPedido}");
                Console.WriteLine($"Data do Pedido: {dataPedido.ToShortDateString()}");
                Console.WriteLine($"Total do Pedido: {pedido.CalcularTotal().ToString("C")}");

                Console.WriteLine("Se deseja continuar aperte qualquer tecla.");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Pedidos do cliente:");
            cliente.ListarPedidos();

            Console.WriteLine("Obrigado!");
        }
    }
}
