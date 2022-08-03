// See https://aka.ms/new-console-template for more information

namespace OOP
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("-------------1. Function-----------");
            int[] numbers = generateNumbers(10, 10);
            printArray(numbers);
            reverse(numbers);
            printArray(numbers);

            //Fibonacci
            Console.WriteLine("-------------2. Fibonacci-----------");
            fibonacci(10);

            //Test Instructor
            Console.WriteLine("-------------Instructor-----------");
            Instructor faculty = new Instructor();
            faculty.Name = "Khanh Mai";
            faculty.Id = 1001; 
            faculty.DateOfBirth = new DateTime(1997,09,02);
            List<String> addy = new List<string>();
            addy.Add("Avenue SouthWest");
            addy.Add("Dallas Texas");
            faculty.Address = addy;
            Console.WriteLine($"Faculty\t: {faculty.Name}");
            Console.WriteLine($"Age\t: {faculty.Age}");
            faculty.getAddress();
            faculty.WorkDate = new DateTime(2014,12,24);
            Console.WriteLine($"Start\t: {faculty.WorkDate}");
            faculty.Salary = 10000;
            Console.WriteLine(faculty.Salary);

            //Test Students and Courses
            Course algebra1 = new Course();
            algebra1.Name = "Intro to algebra";
            algebra1.Id = 101;

            Course algebra2 = new Course();
            algebra2.Name = "Intro to algebra";
            algebra2.Id = 102;

            Course calculus1 = new Course();
            calculus1.Name = "Calculus Derivative";
            calculus1.Id = 201;

            Course calculus2 = new Course();
            calculus2.Name = "Calculus Derivative";
            calculus2.Id = 202;
            List<Course> courses = new List<Course>() {algebra2,
            calculus1};
          
            Student student1 = new Student();
            student1.Name = "Bill Mai";
            student1.Id = 2001; 
            student1.Address = new List<String>() { "Seattle Central", "University District", "North Seattle" } ;
            student1.DateOfBirth = new DateTime(1995, 12, 31);
            student1.SelectedCourses = courses;

            Student student2 = new Student();
            student2.Name = "Bellamy";
            student2.Id = 2002; 
            student2.Address = new List<String>() { "Dallas Carrolton", "Plano Galaria", "Bellevue Eastgate" } ;
            student2.DateOfBirth = new DateTime(2000, 07, 10);
            student2.SelectedCourses = new List<Course>() { algebra1, calculus2 }; 
            Console.WriteLine($"Student info: {student1.Name}, {student1.Age}");
            student1.getAddress(); 
            Console.WriteLine($"Courses taken: ");
            foreach(Course c in student1.SelectedCourses)
            {
                Console.WriteLine($"Name: {c.Name}, Id: {c.Id}");
            }
            Console.WriteLine(); 
            Console.WriteLine($"Student info: {student2.Name}, {student2.Age}");
            student2.getAddress(); 
            Console.WriteLine($"Courses taken: ");
            foreach (Course c in student2.SelectedCourses)
            {
                Console.WriteLine($"Name: {c.Name}, Id: {c.Id}");
            }

            //Testing Color
            Color color = new Color(100,100,20,10);
            Ball ball = new Ball(10, color);
            ball.Throw();
            ball.Throw();
            Console.WriteLine($"The ball is throw {ball.count()} times");
            ball.Pop();
            ball.Throw(); 
        }

        public static int[] generateNumbers(int length, int max)
        {
             
            int[] numbers = new int[length];
            Random r = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(max) + 1; 
            }
            return numbers; 
        }

        public static void reverse(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp; 
            } 
        }

        public static void printArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " "); 
            }
            Console.WriteLine(); 
        }

        public static int fibonacci(int n)
        {
            if (n == 0)
            {
                return 0; 
            }

            if (n == 1  || n == 2) { return 1; }
            int first = 1;
            int second = 1;
            int result = 0;
            Console.Write($"{first} {second} "); 
            for (int i = 3; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
                Console.Write(result + " "); 
            }
            return result; 
        }
    }
}
