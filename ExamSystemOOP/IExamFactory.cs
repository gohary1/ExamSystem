using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public interface IExamFactory
    {
        exam CreateExam(ExamType type, double time, int numOfQuestions);
        Question CreateQuestion(QuestionType type);
    }
}
