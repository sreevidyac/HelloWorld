using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Repo
{
    public class MessageRepo :IMessageRepo
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}
