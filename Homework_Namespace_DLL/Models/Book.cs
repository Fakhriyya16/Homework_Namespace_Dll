using Homework_Namespace_DLL.Helpers.Extensions;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Namespace_DLL.Models
{
    internal class Book : Person   
    {
        public const int num = 5;
        public int result = 0;

        static Book()
        {
            int a = 5;
            
            Console.WriteLine(a.PowerOfNums(2));
        }
    }
}
