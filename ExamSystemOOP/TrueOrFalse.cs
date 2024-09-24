using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace oopTest
{
    public class TrueOrFalse:Question
    {
        public char rightAnswer { get; set; }

        public TrueOrFalse(string _header, string _body, int _mark, char _rightAnswer):base(_header, _body, _mark)
        {
            rightAnswer = _rightAnswer; 
        }

    }
}
