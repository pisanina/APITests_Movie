using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDomain
{
   public class Credits
    {
        public List<Actor> Cast { get; set; }
        public List<Crew> Crew { get; set; }
        public List<Actor> Guest_Stars { get; set; }
        public int Id { get; set; }

    }
}
