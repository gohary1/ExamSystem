using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public class MCQ:Question
    {

        public List<Answer> Answer { get; set; } = new List<Answer>();
        public int rigthAnswer { get; set; }

        public MCQ(string _header, string _body, int _mark, int _rightAnswer,List<Answer> _answer) : base(_header, _body, _mark)
        {
            Answer = _answer;
            rigthAnswer = _rightAnswer;
        }
    }
}
