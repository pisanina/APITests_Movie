using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDomain
{
    public class Actor:Person
    {
        public int Order { get; set; }
        public string Character { get; set; }
    }
}
