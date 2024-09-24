using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public class subject
    {
        public int subId { get; set; }
        public string SubName { get; set; }
        public exam exam { get; set; }
        public IExamFactory ExamFactory { get; set; }

        public subject(int _subId,string _subName,IExamFactory examFactory)
        {
            subId = _subId;
            SubName = _subName;
            ExamFactory = examFactory;
        }

        public void CreateExam()
        {
            Console.WriteLine("Enter exam type (1 for Practical, 2 for Final):");
            ExamType examType = (ExamType)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exam duration (in minutes):");
            double time = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of questions:");
            int numOfQuestions = int.Parse(Console.ReadLine());

            exam = ExamFactory.CreateExam(examType, time, numOfQuestions);
            Console.Clear();
            for (int i = 0; i < numOfQuestions; i++)
            {
                if (examType == ExamType.Final)
                {
                    Console.WriteLine("please enter the type of question you want (1 for true Or False || 2 for MCQ)");
                }
                QuestionType questionType = examType == ExamType.Practical ? QuestionType.MCQ :
                    (QuestionType)int.Parse(Console.ReadLine());
                Question question = ExamFactory.CreateQuestion(questionType);
                exam.AddQuestion(question);
            }
        }

    }
}
