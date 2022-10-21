using Microsoft.Data.SqlClient;
using System;
using Contas.Screens.PayScreens;
using Contas.Screens.ReciveScreen;

namespace Contas
{
    class Program
    {
        private const string CONNECTION_STRING = @"";


        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Contas a pagar e a receber");
            Console.WriteLine("--------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de contas a pagar");
            Console.WriteLine("2 - Gestão de contas a receber");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    MenuPayScreen.Load();
                    break;
                case 2:
                    MenuReciveScreen.Load();
                    break;
                default: Load(); break;
            }

        }
    }
}
