using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public class QuestionFactory :IExamFactory
    {
        public exam CreateExam(ExamType type, double time, int numOfQuestions)
        {
            return type switch
            {
                ExamType.Final => new finalExam(time, numOfQuestions),
                ExamType.Practical => new practicalExam(time, numOfQuestions),
                _ => throw new ArgumentException("Invalid exam type"),
            };
        }
        public Question CreateQuestion(QuestionType type)
        {
            return type switch
            {
                QuestionType.TrueOrFalse => CreateTrueOrFalseQuestion(),
                QuestionType.MCQ => CreateMCQQuestion(),
                _ => throw new ArgumentException("Invalid question type"),
            };
        }
        private TrueOrFalse CreateTrueOrFalseQuestion()
        {
            Console.WriteLine("Enter True/False question:");
            string body = Console.ReadLine();
            Console.WriteLine("Enter mark:");
            int mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter correct answer (t for true/f for false):");
            char correctAnswer = char.Parse(Console.ReadLine());
            return new TrueOrFalse("True/False", body, mark, correctAnswer);
        }

        private MCQ CreateMCQQuestion()
        {
            Console.WriteLine("Enter MCQ question:");
            string body = Console.ReadLine();
            Console.WriteLine("Enter mark:");
            int mark = int.Parse(Console.ReadLine());
            List<Answer> answers = new List<Answer>();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Enter option {i}:");
                answers.Add(new Answer { AnswerId = i, AnswerText = Console.ReadLine() });
            }
            Console.WriteLine("Enter correct answer number (1-4):");
            int correctAnswer = int.Parse(Console.ReadLine());
            Console.Clear();
            return new MCQ("MCQ", body, mark, correctAnswer, answers);
        }

    }
}
