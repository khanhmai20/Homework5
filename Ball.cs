using System;
namespace OOP
{
    public class Ball
    {
        private int size;
        private Color c;
        private int throwTimes;

        public Ball(int size, Color c)
        {
            this.size = size;
            this.c = c; 
        }

        public void Pop()
        {
            size = 0; 
        }

        public void Throw()
        {
            if (size != 0)
            {
                throwTimes++; 
            }else
            {
                Console.WriteLine("The ball is popped"); 
            }
        }

        public int count()
        {
            return throwTimes; 
        }
    }
}

