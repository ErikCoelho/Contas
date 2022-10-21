using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.ReciveScreen
{
    public static class ListReciveScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de contas a receber");
            Console.WriteLine("-------------------------");
            List();
            Console.ReadKey();
            MenuReciveScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<BillRecive>(Database.Connection);
            var bills = repository.Get();
            foreach (var item in bills)
            {
                Console.WriteLine($"Id: {item.Id} - Descrição: {item.Description} - Categoria: {item.Category} - Valor: {item.Value}");
            }
        }
    }
}