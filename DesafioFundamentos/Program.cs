﻿using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("* ========== Seja bem-vindo ao sistema de estacionamento! ========== *\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora, digite o preço por hora:");
Console.WriteLine("Agora, digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("\n* ====== Sistema para estacionamento ====== *\n");
    Console.WriteLine("* ========== Digite a sua opçao ========== *\n");
    Console.WriteLine("* ========== 1 - Cadastrar veiculo ======== *");
    Console.WriteLine("* ========== 2 - Remover veiculo ========== *");
    Console.WriteLine("* ========== 3 - Listar veiculos ========== *");
    Console.WriteLine("* ========== 4 - Encerrar programa ======== *");
    Console.WriteLine("_____________________________________________");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção invalida. Tente novamente.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
