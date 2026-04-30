using System;

namespace LocadoraVeiculos.Classes.ClassesBases;

public abstract class DePassageiro : VeiculoBase
{
    public int QuantidadePassageiros;

    public DePassageiro()
    {

    }
    public DePassageiro(string marca, string modelo, int ano, decimal valor, int quantidadePassageiros) : base(marca, modelo, ano, valor)
    {
        QuantidadePassageiros = quantidadePassageiros;
    }

    public override VeiculoBase? Cadastrar()
    {
        ObterDadosBase();

        System.Console.Write("Digite a QUANTIDADE DE PASSAGEIROS: ");
        QuantidadePassageiros = Convert.ToInt32(Console.ReadLine());

        return this; //aqui eu sei que esta sendo retornado um veiculo do tipo em especifico

    }

    public override string ListarDados()
    {
        return $"Marca: {Marca}, Modelo{Modelo}, Ano: {Ano}, Quantidade de Passageiros: {QuantidadePassageiros}, Valor: R${Valor}";

    }
}
