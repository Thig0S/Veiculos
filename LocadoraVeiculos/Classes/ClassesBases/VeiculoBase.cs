using System;

namespace LocadoraVeiculos.Classes;

public abstract class VeiculoBase
{

    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Ano { get; set; }
    public decimal Valor { get; set; }

    public VeiculoBase()
    {

    }
    protected VeiculoBase(string? marca, string? modelo, int ano, decimal valor)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Valor = valor;
    }

    public void ObterDadosBase()
    {
        System.Console.Write("Digite a MARCA: ");
        Marca = Console.ReadLine();

        System.Console.Write("Digite o MODELO: ");
        Marca = Console.ReadLine();

        System.Console.Write("Digite o ANO: ");
        Ano = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Digite o VALOR: ");
        Valor = Convert.ToInt32(Console.ReadLine());
    }

    public abstract void Cadastrar();

    public abstract string ListarDados();

}
