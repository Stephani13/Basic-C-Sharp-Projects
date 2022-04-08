using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters_assingments
{
    class Employee<T> :Person
    {
        public List<T> Things { get; set; }
    }

}
