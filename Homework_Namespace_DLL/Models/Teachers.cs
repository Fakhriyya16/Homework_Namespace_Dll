using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Namespace_DLL.Models
{
    internal class Teachers
    {
        public static int Count { get; set; }

        public Teachers()
        {
            Count++;
        }
    }
}
