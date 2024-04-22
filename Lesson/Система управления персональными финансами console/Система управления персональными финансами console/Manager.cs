using System;

namespace MoneySystem
{
    public class Manager
    {
        public int idusers = 0;
        public List<User> users;

        public Manager()
        {
            users = new List<User>();
        }

        // шаблон нахождения user
        public User AplicationFindUser()
        {
            PrintUsers();

            Console.WriteLine("Id user:");
            int iduser = Convert.ToInt32(Console.ReadLine());

            User user;
            if (idusers >= iduser)
            {
                return user = users.Find(s => s.id == iduser);
            }
            else
            {
                Console.WriteLine("Error!");
                return null;
            }
        }

        // вывод всех users
        public void PrintUsers()
        {
            Console.WriteLine("Users:");
            foreach (User user in users)
            {
                user.PrintInfo();
            }
        }

        // создание user
        public void CreateUser()
        {
            Console.WriteLine("Create user");
            Console.WriteLine("Name:");

            idusers++;
            string? NameUser = Console.ReadLine();
            User user;

            if(NameUser != "")
            {
                user = new User(idusers, NameUser);
            }
            else
            {
                user = new User(idusers, "default");
            }

            users.Add(user);
        }
    
        // создание wallet
        public void CreateWallet()
        {
            Console.WriteLine("Create wallet");
            User user = AplicationFindUser();

            if (user != null)
            {
                user.CreateWallet();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    
        // вывод всех wallet
        public void PrintWallets()
        {
            User user = AplicationFindUser();

            if (user != null)
            {
                user.PrintAllWallet();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
