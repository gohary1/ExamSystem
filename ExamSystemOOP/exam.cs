using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public abstract class exam
    {
        public double Time { get; set; }
        public int numOfQuestions { get; set; }

        public exam(double _time,int _numq)
        {
            Time = _time;
            numOfQuestions = _numq;
        }
        public abstract void AddQuestion(Question question);
        public abstract void ShowExam();
        public abstract void ShowResult();
    }
}
