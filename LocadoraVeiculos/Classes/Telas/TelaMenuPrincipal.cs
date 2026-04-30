using System;
using LocadoraVeiculos.Classes.Carga;
using LocadoraVeiculos.Classes.Misto;
using LocadoraVeiculos.Classes.Passageiro;

namespace LocadoraVeiculos.Classes.Telas;

public class TelaMenuPrincipal
{


    public string? ApresentarDadosMenuPrincipal()
    {
        do
        {
            Console.Clear();
            System.Console.WriteLine("Bem-vindo ao ABC Bolas Locadora de Veiculos!");
            System.Console.WriteLine("Digite uma das opções: ");
            System.Console.WriteLine("1 - Cadastrar um Veiculo");
            System.Console.WriteLine("2 - Listar todos os Veiculos");
            System.Console.WriteLine("3 - Listar um tipo os Veiculo");
            System.Console.WriteLine("0 - Sair");
            System.Console.Write("> ");
            string? opcao = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(opcao) && opcao == "1" || opcao == "2" || opcao == "3" || opcao == "0")
                return opcao;

            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Digite uma opção VALIDA!");
            Console.ReadLine();
        } while (true);
    }
    public VeiculoBase? SelecionarVeiculo()
    {
        do
        {
            Console.Clear();

            string? opcao = Dados("Digie uma das opções para CADASTRAR: ");

            switch (opcao)
            {
                case "1":
                    return new Caminhao();
                case "2":
                    return new Caminhonete();
                case "3":
                    return new Automovel();
                case "4":
                    return new Motocicleta();
                case "5":
                    return new Bicicleta();
                case "6":
                    return new Utilitario();
                case "0":
                    return null;
                default:
                    System.Console.WriteLine("Digite uma das opções acima!");
                    break;
            }
        } while (true);
    }
    public static Type? EscolherTipo(string msg)
    {
        Console.Clear();
        string? opcao = Dados(msg);

        switch (opcao)
        {
            case "1": return typeof(Caminhao);
            case "2": return typeof(Caminhonete);
            case "3": return typeof(Automovel);
            case "4": return typeof(Motocicleta);
            case "5": return typeof(Bicicleta);
            case "6": return typeof(Utilitario);
            case "0": return null;
            default:
                Console.WriteLine("Digite uma das opções acima!");
                return null;
        }
    }
    private static string? Dados(string msg)
    {
        System.Console.WriteLine($"{msg}: ");
        System.Console.WriteLine("1 - Caminhão ");
        System.Console.WriteLine("2 - Caminhonete ");
        System.Console.WriteLine("3 - Automovel ");
        System.Console.WriteLine("4 - Motocicleta ");
        System.Console.WriteLine("5 - Bicicleta ");
        System.Console.WriteLine("6 - Utilitario ");
        System.Console.WriteLine("0 - Sair");
        System.Console.Write("> ");
        string? opcao = Console.ReadLine();
        return opcao;
    }
}
