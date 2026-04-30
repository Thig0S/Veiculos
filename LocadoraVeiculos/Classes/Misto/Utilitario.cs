using LocadoraVeiculos.Classes.ClassesBases;

namespace LocadoraVeiculos.Classes.Misto;

public class Utilitario : DeMisto
{
    public Utilitario()
    {

    }
    public Utilitario(string marca, string modelo, int ano, decimal valor, string outro) : base(marca, modelo, ano, valor, outro)
    {
        Outro = outro;
    }

}
