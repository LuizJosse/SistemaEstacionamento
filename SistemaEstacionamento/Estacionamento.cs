using System;
using System.Collections.Generic;

class Estacionamento
{
    public decimal precoInicial;
    public decimal precoPorHora;
   public List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        veiculos = new List<string>();
    }

    public void AdicionarVeiculo(string placa)
    {
        veiculos.Add(placa);
        Console.WriteLine($"Veículo com a placa {placa} foi estacionado.");
    }

    public void RemoverVeiculo(string placa)
    {
        if (veiculos.Contains(placa))
        {
            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal horas))
            {
                decimal valorCobrado = precoInicial + (precoPorHora * horas);
                Console.WriteLine($"Valor cobrado para o veículo com a placa {placa}: R$ {valorCobrado:F2}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
        else
        {
            Console.WriteLine("O veículo não está estacionado.");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (string placa in veiculos)
            {
                Console.WriteLine($"Placa: {placa}");
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
