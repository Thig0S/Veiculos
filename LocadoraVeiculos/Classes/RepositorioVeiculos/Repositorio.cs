using System;
using LocadoraVeiculos.Classes.Carga;
using LocadoraVeiculos.Classes.Misto;
using LocadoraVeiculos.Classes.Passageiro;

namespace LocadoraVeiculos.Classes.RepositorioVeiculos;

public class Repositorio
{
    //Encapsulamento
    private List<VeiculoBase> listaVeiculos = new();

    public Repositorio()
    {

        //DADOS BASE PARA TESTE
        Caminhao caminhao = new Caminhao("Ferrari", "Grande", 2000, 10000, "Muito Pesado");
        listaVeiculos.Add(caminhao);

        Caminhonete caminhonete = new Caminhonete("Mustang", "Fusca", 1990, 14000, "Carga Leve");
        listaVeiculos.Add(caminhonete);

        Utilitario skate = new Utilitario("Santa Cruz", "Tradicional", 2026, 1200, "Skate sla");
        listaVeiculos.Add(skate);

        Automovel carro = new Automovel("Fiat", "Tung Tung", 2015, 4000, 4);
        listaVeiculos.Add(carro);
    }

    public List<VeiculoBase> SelecionarLista()
    {
        return listaVeiculos;
    }
    public void Adicionar(VeiculoBase v)
    {
        listaVeiculos.Add(v);

        System.Console.WriteLine("Veiculo adicionado com sucesso! ");
        ENTER();
    }
    public void ListarTodos()
    {
        foreach (VeiculoBase v in listaVeiculos)
        {
            System.Console.WriteLine(v.ListarDados());
        }
        ENTER();
    }
    public List<VeiculoBase> FiltrarPorTipo(Type tipo)
    {
        return listaVeiculos
            .Where(v => tipo.IsAssignableFrom(v.GetType()))
            .ToList();
    }
    private void ENTER()
    {
        System.Console.WriteLine("-------------------------------");
        System.Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}
