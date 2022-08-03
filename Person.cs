using System;

namespace OOP
{
    public abstract class Person
    {
        public int Id { get; set; } 
        private decimal salary; 
        public String Name { get; set; }

        public virtual decimal Salary
        {
            get => salary; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Only positive number"); 
                }
                salary = value; 
            }

        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get => (DateTime.Now.Year - DateOfBirth.Year);

        }

        public List<String> Address { get; set; }

        public void getAddress()
        {
            foreach (String addy in Address)
            {
                Console.WriteLine(addy); 
            }
        }
    }
}

