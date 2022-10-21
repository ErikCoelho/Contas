using System;
using Contas.Models;
using Contas.Repositories;

namespace Contas.Screens.ReciveScreen
{
    public static class CreateReciveScreen
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

            Create(new BillRecive
            {
                Description = description,
                Category = category,
                Value = value
            });
            Console.ReadKey();
            MenuReciveScreen.Load();
        }

        public static void Create(BillRecive billRecive)
        {
            try
            {
                var repository = new Repository<BillRecive>(Database.Connection);
                repository.Create(billRecive);
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