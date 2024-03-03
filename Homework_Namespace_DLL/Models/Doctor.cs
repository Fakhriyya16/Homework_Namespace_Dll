using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Namespace_DLL.Models
{
    internal class Doctor
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public int MyProperty { get; set; }

        static Doctor()
        {
            Console.WriteLine("static ctor");
        }

        public Doctor()
        {
            Console.WriteLine("non-static ctor");
        }
    }
}
