using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.ReciveScreen
{
    public static class UpdateReciveScreen
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

            Update(new BillRecive
            {
                Id = int.Parse(id),
                Description = description,
                Category = category,
                Value = value
            });
            Console.ReadKey();
            MenuReciveScreen.Load();
        }

        public static void Update(BillRecive billRecive)
        {
            try
            {
                var repository = new Repository<BillRecive>(Database.Connection);
                repository.Update(billRecive);
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