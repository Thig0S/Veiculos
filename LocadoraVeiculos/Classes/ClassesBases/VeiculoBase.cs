using System;

namespace LocadoraVeiculos.Classes;

public abstract class VeiculoBase
{
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Ano { get; set; }
    public decimal Valor { get; set; }

    public abstract void Cadastrar(VeiculoBase v);

    public abstract string ListarDados();

}
