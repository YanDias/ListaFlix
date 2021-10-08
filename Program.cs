using ListaFlix.Classe;
using ListaFlix.Enum;
using System;

namespace ListaFlix
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ListarSeries()
        {
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var ativo = serie.retornaAtivo();

                Console.WriteLine("*ID {0} -- {1} -- Ativo: {2} ", serie.retornaID(), serie.retornaTitulo(), (ativo ? "Sim" : "Não") );
                Console.WriteLine();
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir Nova serie");
            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, System.Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o valor do genero presente nas opções acima");
            int idGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição");
            string Descricao = Console.ReadLine();

            
            Console.WriteLine("Digite o ano de inicio da serie");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do titulo");
            string Titulo = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(), Genero: (Genero)idGenero, titulo: Titulo, descricao: Descricao, ano: ano);

            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID que deseja atualizar");
            int Id = int.Parse(Console.ReadLine());


            Console.WriteLine("Inserir Nova serie");
            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, System.Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o valor do genero presente nas opções acima");
            int idGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição");
            string Descricao = Console.ReadLine();


            Console.WriteLine("Digite o ano de inicio da serie");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do titulo");
            string Titulo = Console.ReadLine();

           

            Series atualizaSerie = new Series(id: Id, Genero: (Genero)idGenero, titulo: Titulo, descricao: Descricao, ano: ano);

            repositorio.Atualizar(Id, atualizaSerie);
        }
        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o ID que deseja excluir");
            int Id = int.Parse(Console.ReadLine());

            repositorio.Excluir(Id);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o ID que deseja visualizar");
            int Id = int.Parse(Console.ReadLine());

            Series serie = repositorio.RetornaPorid(Id);

            Console.WriteLine(serie);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("ListaFlix um mundo de series ao seu dispor");
            Console.WriteLine("Informme a opçao desejada");
            Console.WriteLine("1 - Lista de Series");
            Console.WriteLine("2 - Inserir nova de Serie");
            Console.WriteLine("3 - Atualizar Serie");
            Console.WriteLine("4 - Excluir Serie");
            Console.WriteLine("5 - Visualizar Serie");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }
    }
}
