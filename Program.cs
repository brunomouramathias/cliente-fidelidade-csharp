using System;

namespace ClienteFidelidadeApp
{
    class Program
    {
        static void Main()
        {
            var cliente = new ClienteFidelidade();
            while (true)
            {
                Console.WriteLine("=== Sistema de Pontos de Fidelidade ===");
                Console.WriteLine("1. Registrar compra (1 ponto por R$1)");
                Console.WriteLine("2. Resgatar pontos");
                Console.WriteLine("3. Ver saldo de pontos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                string? input = Console.ReadLine();

                Console.Clear();
                try
                {
                    switch (input)
                    {
                        case "1":
                            Console.Write("Informe o valor da compra (R$): ");
                            if (decimal.TryParse(Console.ReadLine(), out var valorCompra))
                            {
                                cliente.AdicionarCompra(valorCompra);
                                Console.WriteLine($"Compra registrada! Saldo atual de pontos: {cliente.Saldo}");
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido.");
                            }
                            break;
                        case "2":
                            Console.Write("Informe a quantidade de pontos para resgate: ");
                            if (decimal.TryParse(Console.ReadLine(), out var qtde))
                            {
                                cliente.ResgatarPontos(qtde);
                                Console.WriteLine($"Resgate realizado! Saldo atual de pontos: {cliente.Saldo}");
                            }
                            else
                            {
                                Console.WriteLine("Quantidade inválida.");
                            }
                            break;
                        case "3":
                            Console.WriteLine($"Saldo de pontos: {cliente.Saldo}");
                            break;
                        case "0":
                            Console.WriteLine("Encerrando o programa...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
