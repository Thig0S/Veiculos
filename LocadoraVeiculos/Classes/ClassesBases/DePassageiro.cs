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

    public override void Cadastrar(VeiculoBase v)
    {
        throw new NotImplementedException();
    }

    public override string ListarDados()
    {
        return $"Marca: {Marca}, Modelo{Modelo}, Ano: {Ano}, Quantidade de Passageiros: {QuantidadePassageiros}, Valor: R${Valor}";

    }
}
