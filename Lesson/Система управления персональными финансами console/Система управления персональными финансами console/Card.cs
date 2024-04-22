using System;

namespace MoneySystem
{
    public class Card
    {
        public int id { get; set; }
        public string numbers { get; set; }
        public DateTime datecard { get; set; }
        public string cvv { get; set; }
        public bool credit { get; set; }
        public long sum {  get; set; }

        public Card(int _id, string _numbers, DateTime _datecard, string _cvv, bool _credit)
        {
            id = _id;
            numbers = _numbers;
            datecard = _datecard;
            cvv = _cvv;
            sum = 0;
            credit = _credit;
        }
    }
}
