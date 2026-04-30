using System;

namespace LocadoraVeiculos.Classes.ClassesBases;

public class DeCarga : VeiculoBase
{
    public string? TipoCarga { get; set; }

    public override void Cadastrar(VeiculoBase v)
    {
        throw new NotImplementedException();
    }

    public override string ListarDados()
    {
        throw new NotImplementedException();
    }
}
