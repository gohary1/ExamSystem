using System.Diagnostics;

namespace oopTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExamFactory examFactory=new QuestionFactory();
            subject sub1 = new subject(10, "c#",examFactory);
            sub1.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start the exam now? (y | n)");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Console.Clear();
                sub1.exam.ShowExam();
            }
        }
    }
}
