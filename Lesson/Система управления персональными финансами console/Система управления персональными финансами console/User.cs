using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySystem
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idwallets { get; set; } = 0;
        public List<Wallet> wallets { get; set; }

        public User(int _id, string _name)
        {
            wallets = new List<Wallet>();
            id = _id;
            name = _name;
        }

        // вывод даных user
        public void PrintInfo()
        {
            Console.WriteLine($"Id:{id} name:{name}");
            Console.WriteLine($"Количество кошельков:{wallets.Count()}");
        }
        
        // создание wallet
        public void CreateWallet()
        {
            Console.WriteLine("Name wallet:");

            idwallets += 1;
            string? namewallet = Console.ReadLine();

            Wallet wallet = new Wallet(idwallets, namewallet);
            wallets.Add(wallet);
        }

        // вывод всех wallets
        public void PrintAllWallet()
        {
            Console.WriteLine($"Wallets {name}");

            foreach(Wallet wallet in wallets)
            {
                wallet.PrintInfo();
            }
        }
    }
}
