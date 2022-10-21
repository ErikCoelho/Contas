using System;

namespace Contas.Screens.PayScreens
{
    public static class MenuPayScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Contas a pagar");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar contas pagas");
            Console.WriteLine("2 - Cadastrar nova conta");
            Console.WriteLine("3 - Atualizar conta");
            Console.WriteLine("4 - Deletar conta");
            Console.WriteLine("5 - Voltar para o menu principal");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListPayScreen.Load();
                    break;
                case 2:
                    CreatePayScreen.Load();
                    break;
                case 3:
                    UpdatePayScreen.Load();
                    break;
                case 4:
                    DeletePayScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}