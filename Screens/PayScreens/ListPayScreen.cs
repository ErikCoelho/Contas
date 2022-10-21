using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.PayScreens
{
    public static class ListPayScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de contas a pagar");
            Console.WriteLine("-----------------------");
            List();
            Console.ReadKey();
            MenuPayScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<BillPay>(Database.Connection);
            var bills = repository.Get();
            foreach (var item in bills)
            {
                Console.WriteLine($"Id: {item.Id} - Descrição: {item.Description} - Categoria: {item.Category} - Valor: {item.Value}");
            }
        }
    }
}