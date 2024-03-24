using System;

namespace ApplicationForm
{
    class StudentClass
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public char Gender { get; set; }

        public StudentClass(int id, string name, string phone, char gender)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Gender = gender;
        }
    }
}
