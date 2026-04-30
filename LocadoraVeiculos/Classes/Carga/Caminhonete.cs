using System;
using LocadoraVeiculos.Classes.ClassesBases;

namespace LocadoraVeiculos.Classes.Carga;

public class Caminhonete : DeCarga
{
    public Caminhonete() : base()
    {

    }
    public Caminhonete(string marca, string modelo, int ano, decimal valor, string tipoCarga) : base(marca, modelo, ano, valor, tipoCarga)
    {

    }

    public override string ListarDados()
    {
        return "Tipo: Caminhonete, " + base.ListarDados();
    }
}
