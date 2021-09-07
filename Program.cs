using System;

namespace Projeto_Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmeRepositorio repositorioF = new FilmeRepositorio();
        static void Main(String[] args)
        {
            string opcaoMenu = Menu();

            do
            {

                if(opcaoMenu =="1")
                {
                    string opcaoSerie = Serie();
                
                switch(opcaoSerie)
                {
                     case "1":
                        ListarSerie();
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

                    case "6":
                        opcaoMenu =Menu();
                            
                            if(opcaoMenu=="C")
                            {
                                 Console.Clear();
                            }
                            opcaoMenu = Menu();    
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                
                }

                } else if(opcaoMenu =="2")
                
                {
                    string  opcaoFilme = Filme();

                     switch(opcaoFilme)
                    {
                        case "1":
                            ListarFilme();
                            break;

                        case "2":
                            InserirFilme();
                            break;

                        case "3":
                            AtualizarFilme();
                            break;

                        case "4":
                            ExcluirFilme();
                            break;

                        case "5":
                            VisualizarFilme();
                            break;

                        case "6":
                            opcaoMenu= Menu();

                                if(opcaoMenu=="C")
                                {
                                    Console.Clear();
                                }
                                opcaoMenu = Menu();    
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    
                    }

                } 

              //  opcaoMenu = Menu();          
            
            }while(opcaoMenu.ToUpper() != "X");

            Console.WriteLine("Obrigado por utilizar nosos serviços");
            Console.ReadLine();
            
           
        }



        private static void ListarSerie()
        {
            Console.WriteLine("Listar Series");

            var lista = repositorio.Lista();

            if(lista.Count ==0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;

            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: -{1} {2}", serie.retornaId(), serie.retornaTitulo(), excluido ? "Excluido" : "");

            }


        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova serie");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} -{1}",i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genero entre as ações acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Inicio da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(), 
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Cadastrar(novaSerie);                            


        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

           foreach(int i in Enum.GetValues(typeof(Genero)))
           {
               Console.WriteLine("{0} -{1}", i, Enum.GetName(typeof(Genero),i));
           }

           Console.Write("Digite o genero entre as ações acima: ");
           int entradaGenero = int.Parse(Console.ReadLine());

           Console.Write("Digite o titulo da serie: ");
           string entradaTitulo = Console.ReadLine();

           Console.Write("Digite o Ano de Inicio da serie");
           int entradaAno = int.Parse(Console.ReadLine());

           Console.Write("Digite a Descrição da Serie");
           string entradaDescricao = Console.ReadLine();

           Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno, 
                                        descricao: entradaDescricao);

            repositorio.Alterar(indiceSerie, atualizaSerie);

        }

        private static void ExcluirSerie()
        {

            Console.Write("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            repositorio.Excluir(indiceSerie);

        }

        private static void VisualizarSerie()
        
        {
            Console.Write("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);

        }


         private static void ListarFilme()
        {
            Console.WriteLine("Listar Filmes");

            var lista = repositorioF.Lista();

            if(lista.Count ==0)
            {
                Console.WriteLine("Nenhum Filme cadastrado");
                return;

            }

            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine("#ID {0}: -{1} {2}", filme.retornaId(), filme.retornaNome(), excluido ? "Excluido" : "");

            }


        }

        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo Filme");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} -{1}",i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genero entre as ações acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do filme: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento: ");
            int entradaAno_Lancamento = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Classificacao)))
            {

                Console.WriteLine("{0} -{1}", i, Enum.GetName(typeof(Classificacao),i));

            }
            Console.Write("Digite a classificação indicativa entre as ações acima: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

             foreach(int i in Enum.GetValues(typeof(Idioma)))
            {

                Console.WriteLine("{0} -{1}", i, Enum.GetName(typeof(Idioma),i));

            }
            Console.Write("Digite o idioma entre as ações acima: ");
            int entradaIdioma = int.Parse(Console.ReadLine());




            Filme novoFilme = new Filme(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        nome: entradaNome,
                                        ano_Lancamento: entradaAno_Lancamento,
                                        classificacao: (Classificacao)entradaClassificacao,
                                        idioma: (Idioma)entradaIdioma);

            repositorioF.Cadastrar(novoFilme);              

        }

        private static void AtualizarFilme()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

           foreach(int i in Enum.GetValues(typeof(Genero)))
           {
               Console.WriteLine("{0} -{1}", i, Enum.GetName(typeof(Genero),i));
           }

           Console.Write("Digite o genero entre as ações acima: ");
           int entradaGenero = int.Parse(Console.ReadLine());


          Console.Write("Digite o nome do filme: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento: ");
            int entradaAno_Lancamento = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Classificacao)))
            {

                Console.WriteLine("{0} -{1}", i, Enum.GetName(typeof(Classificacao),i));

            }
            Console.Write("Digite a classificação indicativa entre as ações acima: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

             foreach(int i in Enum.GetValues(typeof(Idioma)))
            {

                Console.WriteLine("{0} -{1}", i, Enum.GetName(typeof(Idioma),i));

            }
            Console.Write("Digite o idioma entre as ações acima: ");
            int entradaIdioma = int.Parse(Console.ReadLine());

           Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        nome: entradaNome,
                                        ano_Lancamento: entradaAno_Lancamento, 
                                        classificacao: (Classificacao)entradaClassificacao,
                                        idioma: (Idioma)entradaIdioma);

            repositorioF.Alterar(indiceFilme, atualizaFilme);

        }


        private static void ExcluirFilme()
        {

            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioF.RetornaPorId(indiceFilme);

            repositorioF.Excluir(indiceFilme);

        }

        private static void VisualizarFilme()
        
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioF.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);

        }


        private static string Menu()
        {
            Console.WriteLine();
            Console.WriteLine("=============(!Bem Vindo ao App DIG-TV!)=================");
            Console.WriteLine("__________(Informe a Opção Desejada)__________");

            Console.WriteLine("1-Adicionar Series++");
            Console.WriteLine("2-Adicionar Filmes++");
            Console.WriteLine("C-Limpar Tela");
            Console.WriteLine("X-Sair");
            Console.WriteLine();

            string opcaoMenu = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoMenu;

        }

        private static string Serie()
        {
            Console.WriteLine();
            Console.WriteLine("_________(Informe a Opção Desejada)________");
            Console.WriteLine("1-Listar Series");
            Console.WriteLine("2-Inserir uma Serie");
            Console.WriteLine("3-Atualizar Series");
            Console.WriteLine("4-Excluir Serie");
            Console.WriteLine("5-Visualizar Serie");
            Console.WriteLine("6-Voltar ao Menu");
            Console.WriteLine();

            string opcaoSerie = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoSerie;

        }

        private static string Filme()
        {
            Console.WriteLine();
            Console.WriteLine("_______(Informe a Opção Desejada)_______");
            Console.WriteLine("1-Listar Filmes");
            Console.WriteLine("2-Inserir um Filme");
            Console.WriteLine("3-Atualizar Filmes");
            Console.WriteLine("4-Excluir Filme");
            Console.WriteLine("5-Visualizar Filme");
            Console.WriteLine("6-Voltar ao Menu");
            Console.WriteLine();

            string  opcaoFilme = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoFilme;
           

        }

    }
}
