using System;

namespace MoneySystem
{
    public class Wallet
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Card> cards { get; set; }

        public Wallet(int _id, string _name) 
        {
            cards = new List<Card>();
            name = _name;
            id = _id;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{id}:{name}");
            Console.WriteLine($"Количество карт:{cards.Count()}");
        }
    }
}
