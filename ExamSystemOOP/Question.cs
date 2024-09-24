using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public abstract class Question
    {

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public int UserAnswer { get; set; }
        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

    }
}
