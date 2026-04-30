using System;
using LocadoraVeiculos.Classes.ClassesBases;

namespace LocadoraVeiculos.Classes.Passageiro;

public class Bicicleta : DePassageiro
{
    public Bicicleta()
    {

    }
    public Bicicleta(string marca, string modelo, int ano, decimal valor, int quantidadePassageiros) : base(marca, modelo, ano, valor, quantidadePassageiros)
    {
        QuantidadePassageiros = quantidadePassageiros;
    }

    public override string ListarDados()
    {
        return "Tipo: Bicicleta, " + base.ListarDados();
    }
}