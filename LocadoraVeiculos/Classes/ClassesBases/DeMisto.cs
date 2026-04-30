using System;

namespace LocadoraVeiculos.Classes.ClassesBases;

public class DeMisto : VeiculoBase
{
    public string? Outro { get; set; }

    public override void Cadastrar(VeiculoBase v)
    {
        throw new NotImplementedException();
    }

    public override string ListarDados()
    {
        throw new NotImplementedException();
    }
}
