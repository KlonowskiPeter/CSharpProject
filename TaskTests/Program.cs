using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTests
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        private Task<Boolean> DoLongTask()
        {

            return Task.FromResult<Boolean>(true);
        }
    }
}
