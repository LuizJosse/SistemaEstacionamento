using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o preço inicial: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal precoInicial))
        {
            Console.Write("Digite o preço por hora: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal precoPorHora))
            {
                Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

                while (true)
                {
                    Console.WriteLine("\nOpções:");
                    Console.WriteLine("1 - Cadastrar veículo");
                    Console.WriteLine("2 - Remover veículo");
                    Console.WriteLine("3 - Listar veículos");
                    Console.WriteLine("4 - Encerrar");

                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Digite a placa do veículo: ");
                            string placa = Console.ReadLine();
                            estacionamento.AdicionarVeiculo(placa);
                            break;
                        case "2":
                            Console.Write("Digite a placa do veículo a ser removido: ");
                            placa = Console.ReadLine();
                            estacionamento.RemoverVeiculo(placa);
                            break;
                        case "3":
                            estacionamento.ListarVeiculos();
                            break;
                        case "4":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Preço por hora inválido.");
            }
        }
        else
        {
            Console.WriteLine("Preço inicial inválido.");
        }
    }
}
