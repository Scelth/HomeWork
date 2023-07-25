using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICQ.Model
{
    class UserModel
    {
        public string Username { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
