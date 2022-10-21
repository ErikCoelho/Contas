using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.PayScreens
{
    public static class DeletePayScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma conta");
            Console.WriteLine("---------------------");
            Console.WriteLine("Qual o id da conta que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuPayScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<BillPay>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Conta excluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a conta");
                Console.WriteLine(ex.Message);
            }
        }
    }
}