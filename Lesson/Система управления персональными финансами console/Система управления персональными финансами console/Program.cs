using System;
using System.Text;

namespace MoneySystem
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Manager manager = new Manager();
            manager.CreateUser();
            manager.CreateUser();
            manager.CreateUser();
            manager.CreateWallet();  
            manager.PrintWallets();
        }
    }
}