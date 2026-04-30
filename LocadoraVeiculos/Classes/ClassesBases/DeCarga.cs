using System;
using System.Data;

namespace LocadoraVeiculos.Classes.ClassesBases;

public abstract class DeCarga : VeiculoBase
{

    public string? TipoCarga { get; set; }

    public DeCarga()
    {

    }
    public DeCarga(string marca, string modelo, int ano, decimal valor, string tipoCarga) : base(marca, modelo, ano, valor)
    {
        TipoCarga = tipoCarga;
    }

    public override void Cadastrar()
    {
        ObterDadosBase();

        System.Console.Write("Digite o TIPO DE CARGA: ");
        TipoCarga = Console.ReadLine();
    }

    public override string ListarDados()
    {
        return $"Marca: {Marca}, Modelo{Modelo}, Ano: {Ano}, Tipo de Carga: {TipoCarga} Valor: R${Valor}";
    }
}
