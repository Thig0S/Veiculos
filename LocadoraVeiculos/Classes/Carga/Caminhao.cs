using System;
using LocadoraVeiculos.Classes.ClassesBases;

namespace LocadoraVeiculos.Classes.Carga;

public class Caminhao : DeCarga
{
    public Caminhao() : base()
    {

    }
    public Caminhao(string marca, string modelo, int ano, decimal valor, string tipoCarga) : base(marca, modelo, ano, valor, tipoCarga)
    {

    }
    public override string ListarDados()
    {
        return "Tipo: Caminhão, " + base.ListarDados();
    }
}