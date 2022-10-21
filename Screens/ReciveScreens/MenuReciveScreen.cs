using System;
using Contas.Screens.PayScreens;

namespace Contas.Screens.ReciveScreen
{
    public static class MenuReciveScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Contas a receber");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar contas recebidas");
            Console.WriteLine("2 - Cadastrar nova conta");
            Console.WriteLine("3 - Atualizar conta");
            Console.WriteLine("4 - Deletar conta");
            Console.WriteLine("5 - Voltar para o menu principal");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListReciveScreen.Load();
                    break;
                case 2:
                    CreateReciveScreen.Load();
                    break;
                case 3:
                    UpdateReciveScreen.Load();
                    break;
                case 4:
                    DeleteReciveScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}