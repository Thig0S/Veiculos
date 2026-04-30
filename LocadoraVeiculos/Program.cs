//1.0 Cadastrar os veiculos
//2.0 Listar todos os veiculos
//3.0 Listar 1 tipo de veiculo em especifico

//!!!4 pilares da POO | Construtores | List veiculos | 

using LocadoraVeiculos.Classes;
using LocadoraVeiculos.Classes.RepositorioVeiculos;
using LocadoraVeiculos.Classes.Telas;

TelaMenuPrincipal telaMenuPrincipal = new();
Repositorio listaDeVeiculos = new();

while (true)
{
    //Seleciona a tela que o usuario quer visualizar

    string? opcaoMenuPrincipal = telaMenuPrincipal.ApresentarDadosMenuPrincipal();

    while (true)
    {

        if (opcaoMenuPrincipal == "1")
        {
            //Cadastrar Veiculos
            VeiculoBase? veiculo = telaMenuPrincipal.SelecionarVeiculo();

            if (veiculo == null)
            {
                Console.Clear();
                break;
            }
            // Maior polimorfismo já existente, todos os objetos implementam o metodo Cadastrar da sua maneira 
            // e retornam ELES MESMOS na funcao para o cadastro

            listaDeVeiculos.Adicionar(veiculo.Cadastrar());

        }
        else if (opcaoMenuPrincipal == "2")
        {
            //Listar todos os veiculos usando polimorfismo dentro do metodo do repositorio
            listaDeVeiculos.ListarTodos();
            break;

        }
        else if (opcaoMenuPrincipal == "3")
        {
            //Listar veiculos especificos
            Type? tipoEscolhido = TelaMenuPrincipal.EscolherTipo("Escolha um tipo para LISTAR:");

            if (tipoEscolhido == null)
                break;

            var listaFiltrada = listaDeVeiculos.FiltrarPorTipo(tipoEscolhido);

            foreach (var v in listaFiltrada)
            {
                Console.WriteLine(v.ListarDados());
            }
            Console.ReadLine();
        }
    }
}

