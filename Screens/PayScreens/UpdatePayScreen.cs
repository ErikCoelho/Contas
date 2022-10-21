using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.PayScreens
{
    public static class UpdatePayScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma conta");
            Console.WriteLine("---------------------");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();

            Console.WriteLine("Descrição: ");
            var description = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            var category = Console.ReadLine();

            Console.WriteLine("Valor: ");
            var value = decimal.Parse(Console.ReadLine());

            Update(new BillPay
            {
                Id = int.Parse(id),
                Description = description,
                Category = category,
                Value = value
            });
            Console.ReadKey();
            MenuPayScreen.Load();
        }

        public static void Update(BillPay billpay)
        {
            try
            {
                var repository = new Repository<BillPay>(Database.Connection);
                repository.Update(billpay);
                Console.WriteLine("Conta atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a conta");
                Console.WriteLine(ex.Message);
            }
        }
    }
}