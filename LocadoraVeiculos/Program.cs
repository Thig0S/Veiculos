//1.0 Cadastrar os veiculos
//2.0 Listar todos os veiculos
//3.0 Listar 1 tipo de veiculo em especifico

//!!!4 pilares da POO | Construtores | List veiculos | 

using LocadoraVeiculos.Classes;
using LocadoraVeiculos.Classes.Carga;
using LocadoraVeiculos.Classes.Misto;
using LocadoraVeiculos.Classes.Passageiro;

List<VeiculoBase> listaVeiculos = new();

Caminhao caminhao = new Caminhao("Ferrari", "Grande", 2000, 10000, "Muito Pesado");
listaVeiculos.Add(caminhao);

Caminhonete caminhonete = new Caminhonete("Mustang", "Fusca", 1990, 14000, "Carga Leve");
listaVeiculos.Add(caminhonete);

Utilitario skate = new Utilitario("Santa Cruz", "Tradicional", 2026, 1200, "Skate sla");
listaVeiculos.Add(skate);

Automovel carro = new Automovel("Fiat", "Tung Tung", 2015, 4000, 4);
listaVeiculos.Add(carro);

foreach (VeiculoBase v in listaVeiculos)
{
    System.Console.WriteLine(v.ListarDados());
}
Console.ReadLine();