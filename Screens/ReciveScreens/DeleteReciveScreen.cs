using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.ReciveScreen
{
    public static class DeleteReciveScreen
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
            MenuReciveScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<BillRecive>(Database.Connection);
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