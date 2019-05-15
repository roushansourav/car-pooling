using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req5
{
    class InvalidEmailException:Exception
    {
        public InvalidEmailException(string msg):base(msg)
        {
            //Console.WriteLine(msg);
        }
    }
}
