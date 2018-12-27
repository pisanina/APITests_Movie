using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDomain
{
    public class Season
    { 
        public string _Id             { get; set; }
        public DateTime Air_Date      { get; set; }
        public List<Episode> Episodes { get; set; }
        public string Overview        { get; set; }
        public int Id                 { get; set; }
        public string Poster_Path     { get; set; }
        public int Season_Number      { get; set; }
    }
}
