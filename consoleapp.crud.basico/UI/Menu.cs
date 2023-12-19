using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp.crud.basico.UI
{
    public class Menu
    {
        enum OpcoesMenu 
        {
            ListarTodasPessoas = 1,
            ListarPessoasPorEstado = 2,
            AlterarDadosPessoa = 3,
            InserirNovaPessoa = 4,
            ApagarPessoa = 5
        }

        public static void ExibirMenu()
        {
            do
            {
                var textoMenu = MontaMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(textoMenu);
                Console.ForegroundColor= ConsoleColor.White;

                var escolhaMenuUsuario = (OpcoesMenu)Enum.Parse(typeof(OpcoesMenu), "1");
                Console.WriteLine($"O menu escolhido foi {escolhaMenuUsuario}");

                switch (escolhaMenuUsuario)
                {
                    case OpcoesMenu.ListarTodasPessoas:

                        break;

                    case OpcoesMenu.ListarPessoasPorEstado:

                        break;

                    case OpcoesMenu.AlterarDadosPessoa:

                        break;

                    case OpcoesMenu.InserirNovaPessoa:

                        break;

                    case OpcoesMenu.ApagarPessoa:

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida, escolha outra");
                        Console.ForegroundColor= ConsoleColor.White;
                        break;
                }



            } while (true);

            
        }

        private static string MontaMenu() 
        {
            var menu = new StringBuilder();
            menu.AppendLine("**************************");
            menu.AppendLine("        Menu de opções     ");
            menu.AppendLine("**************************");
            menu.AppendLine("1 - Listar todas as pessoas");
            menu.AppendLine("2 - Listar pessoas por estado");
            menu.AppendLine("3 - Alterar dados da pessoa");
            menu.AppendLine("4 - Inserir nova pessoa");
            menu.AppendLine("5 - Apagar pessoa");
            menu.AppendLine("\nInforme o número do menu de sua escolha");

            return menu.ToString();
        }

    }
}
