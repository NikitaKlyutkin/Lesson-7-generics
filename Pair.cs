using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_generics
{
    internal class Pair<S, T>
    {
        public S Name;
        public T Age;
        public Pair(S name, T age)
        {
           Name = name;
           Age = age;  
        }
    }
}
