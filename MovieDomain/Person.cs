using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDomain
{
    public abstract class Person
    {
        public int Id              { get; set; }
        public int Gender          { get; set; }
        public string Credit_Id    { get; set; }
        public string Name         { get; set; }
        public string Profile_Path { get; set; }

    }
}
