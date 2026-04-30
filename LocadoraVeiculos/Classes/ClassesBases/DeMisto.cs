using System;

namespace LocadoraVeiculos.Classes.ClassesBases;

public abstract class DeMisto : VeiculoBase
{
    public string? Outro { get; set; }

    public DeMisto()
    {

    }
    public DeMisto(string marca, string modelo, int ano, decimal valor, string outro) : base(marca, modelo, ano, valor)
    {
        Outro = outro;
    }

    public override void Cadastrar()
    {
        ObterDadosBase();

        System.Console.Write("Digite INFORMAÇÕES ADICIONAIS: ");
        Outro = Console.ReadLine();

    }

    public override string ListarDados()
    {
        return $"Tipo: utilitario, Marca: {Marca}, Modelo{Modelo}, Ano: {Ano}, Valor: R${Valor}, Outros: {Outro}";
    }
}
