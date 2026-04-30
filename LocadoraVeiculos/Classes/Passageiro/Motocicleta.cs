using System;
using LocadoraVeiculos.Classes.ClassesBases;

namespace LocadoraVeiculos.Classes.Passageiro;

public class Motocicleta : DePassageiro
{
    public Motocicleta()
    {

    }
    public Motocicleta(string marca, string modelo, int ano, decimal valor, int quantidadePassageiros) : base(marca, modelo, ano, valor, quantidadePassageiros)
    {
        QuantidadePassageiros = quantidadePassageiros;
    }


    public override string ListarDados()
    {
        return "Tipo: Motocicleta," + base.ListarDados();
    }
}