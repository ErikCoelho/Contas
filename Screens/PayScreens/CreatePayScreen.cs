using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.PayScreens
{
    public static class CreatePayScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova conta");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Descrição: ");
            var description = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            var category = Console.ReadLine();

            Console.WriteLine("Valor: ");
            var value = decimal.Parse(Console.ReadLine());

            Create(new BillPay
            {
                Description = description,
                Category = category,
                Value = value
            });
            Console.ReadKey();
            MenuPayScreen.Load();
        }

        public static void Create(BillPay billPay)
        {
            try
            {
                var repository = new Repository<BillPay>(Database.Connection);
                repository.Create(billPay);
                Console.WriteLine("Conta cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a conta");
                Console.WriteLine(ex.Message);
            }
        }
    }
}