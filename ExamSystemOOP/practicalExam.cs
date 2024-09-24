using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public class practicalExam: exam
    {
        public List<MCQ> MCQ { get; set; } = new List<MCQ>();
        public practicalExam(double _time, int _numq) :base(_time,_numq)
        {
            
        }

        public override void AddQuestion(Question question)
        {
            if (question is MCQ mcq)
            {
                MCQ.Add(mcq);
            }
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number of Questions: {numOfQuestions}");
            for (int i = 0; i < MCQ.Count; i++)
            {
                Console.WriteLine($"The {i+1} Question is : {MCQ[i].Body}");
                int userAnswer;
                for (int j = 0; j < MCQ[i].Answer.Count; j++)
                {
                    Console.WriteLine($"{j+1} - {MCQ[i].Answer[j].AnswerText}");
                }
                Console.WriteLine("Choose Your best Answer (1 || 2 || 3 || 4)");
                MCQ[i].UserAnswer=int.Parse(Console.ReadLine());
                Console.Clear();
            }
            ShowResult();
        }

        public override void ShowResult()
        {
            int totalMarks=0;
            for (int i = 0;i < MCQ.Count;i++)
            {
                Console.WriteLine($"The Answer of {i+1} Question is {MCQ[i].rigthAnswer}");
                if (MCQ[i].UserAnswer == MCQ[i].rigthAnswer)
                {
                    totalMarks = totalMarks + MCQ[i].Mark;
                }
            }
            Console.WriteLine($"Total Marks is {totalMarks}");
        }
    }
}
