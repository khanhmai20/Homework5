using System;
namespace OOP
{
    public class Instructor : Person
    {
        private decimal salary; 
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public DateTime WorkDate { get; set; }
        public override decimal Salary {
            get => salary;
            set
            {
                if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Only positive number");
                    }
                int experience = DateTime.Now.Year - WorkDate.Year;
                salary = value + experience * 1000; 
            }
        }
    }
}

