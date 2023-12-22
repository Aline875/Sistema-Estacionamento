using System;

public class Estacionamento 
{
    static void Main()
    {  
        Console.WriteLine("Estacionamento");
        Console.WriteLine("Quantas vagas deseja usar hoje?");
        int quantidadeDeVagas = int.Parse(Console.ReadLine());

        string[] veiculosEstacionados = new string[quantidadeDeVagas];
        double precoInicial = 4.0;
        double precoPorHora = 2.0;

        while (true)
        {
            Console.WriteLine("\n o que deseja fazer ?");
            Console.WriteLine("1. adicionar ");
            Console.WriteLine("2. Remover ");
            Console.WriteLine("3. Listar ");
            Console.WriteLine("4. Sair");

            int opcao = int .Parse(Console.ReadLine()); 

            switch (opcao)
            {
                case 1:
                    AdicionarVeiculos(veiculosEstacionados); break;

                case 2:
                    RemoverVeiculos(veiculosEstacionados, precoInicial, precoPorHora) ; break;
                    
                case 3:
                    ListarVeiculos(veiculosEstacionados); break;

                case 4:
                    Console.WriteLine("obrigada por utilizar os nossos serviços!");
                    return;

                default: Console.WriteLine("opção invalida");break;
            }
        }

    }

    static void AdicionarVeiculos(string[] veiculosEstacionados)
    {
        Console.WriteLine("Digite a placa do veiculo:");
        string placa = Console.ReadLine(); 

        for (int i = 0; i < veiculosEstacionados.Length; i++)
        {
            if (veiculosEstacionados[i] == null)
            {
                veiculosEstacionados[i] = placa;
                Console.WriteLine($"veiculo com a placa '{placa}' adicionado");
                return;
            }
        }

        Console.WriteLine("não ha vagas disponiveis");
    }

    static void RemoverVeiculos(string[] veiculosEstacionados, double precoInicial, double precoPorHora)
    {
        Console.WriteLine("Digite a placa do veiculo a ser removido:");
        string placaRemover = Console.ReadLine();
        bool veiculoEncontrado = false;

        for (int i = 0; i < veiculosEstacionados.Length; i++)
        {

            if (veiculosEstacionados[i] == placaRemover)

            {
                Console.WriteLine("digite a quantidade de horas estacionadas");
                int HorasEstacionadas = int.Parse(Console.ReadLine());
                double precoTotal = precoInicial + ( HorasEstacionadas * precoPorHora);
                Console.WriteLine($"Preço a ser pago pelo veiculo '{placaRemover}': R$'{precoTotal}'");
                veiculosEstacionados[i] = null;
                veiculoEncontrado = true;
                break;   
            }
        }

        if (!veiculoEncontrado)
        {
            Console.WriteLine($"Veiculo com a placa {placaRemover} não encontrado");
        }
    }
    static void ListarVeiculos(string[] veiculosEstacionados)
    {
        bool veiculosPresentes = false;

        Console.WriteLine("\nVeiculos estacionados:");

        for (int i = 0; i < veiculosEstacionados.Length; i++)
        {
            if (veiculosEstacionados[i] != null)
            {
                Console.WriteLine($"vaga '{i + 1}: {veiculosEstacionados[i]}'");
                veiculosPresentes = true;
            }
        }
        if (!veiculosPresentes)
        {
            Console.WriteLine("Não ha veiculos estacionados!");
        }
    }
}