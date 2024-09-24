using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public class finalExam:exam
    {
        public List<TrueOrFalse> trueOrFalse { get; set; } = new List<TrueOrFalse>();
        public List<MCQ> MCQ { get; set; } = new List<MCQ>();
        public finalExam(double _time, int _numq) :base(_time,_numq)
        {
            
        }

        public override void AddQuestion(Question question)
        {
            if (question is TrueOrFalse tof)
                trueOrFalse.Add(tof);
            else if (question is MCQ mcq)
                MCQ.Add(mcq);
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number of Questions: {numOfQuestions}");
            Console.WriteLine("True Or False Question:t for true || f for false ");
            for (int i=0; i<trueOrFalse.Count; i++)
            {
                Console.WriteLine($"the {i+1} Question of True Or False is :{trueOrFalse[i].Body}");
                trueOrFalse[i].UserAnswer=char.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("MCQ Questions Choose from 1 to 4 the Right Answer:");
            for (int i = 0; i < MCQ.Count; i++)
            {
                Console.WriteLine($"The {i + 1} Question of MCQ is : {MCQ[i].Body}");
                int userAnswer;
                int userMark = 0;
                for (int j = 0; j < MCQ[i].Answer.Count; j++)
                {
                    Console.WriteLine($"{j + 1} - {MCQ[i].Answer[j].AnswerText}");
                }
                Console.WriteLine("Choose Your best Answer (1 || 2 || 3 || 4)");
                MCQ[i].UserAnswer = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            ShowResult();
        }

        public override void ShowResult()
        {
            int userMark = 0;
            Console.WriteLine("the Exam has been finished");
            Console.WriteLine("True or False Questions:");
            for (int i = 0;i<trueOrFalse.Count;i++) 
            {
                Console.Write($"The {i+1} True Or False Question is {trueOrFalse[i].Body}:");
                Console.WriteLine($"The Answer is : {trueOrFalse[i].rightAnswer}");
                if (trueOrFalse[i].UserAnswer == trueOrFalse[i].rightAnswer) { userMark = userMark + trueOrFalse[i].Mark; }
                
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("MCQ Questions:");
            for (int i = 0;i<MCQ.Count;i++) 
            {
                Console.Write($"The {i + 1} MCQ Question is {MCQ[i].Body}:");
                Console.WriteLine($"The Answer is : {MCQ[i].rigthAnswer}");
                if (MCQ[i].UserAnswer == MCQ[i].rigthAnswer) { userMark = userMark + MCQ[i].Mark; }
            }
            Console.WriteLine($"The Total Marks is {userMark}");
        }
    }
}
