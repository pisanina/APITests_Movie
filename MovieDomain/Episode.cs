using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDomain
{
    public class Episode
    {
        public DateTime Air_Date      { get; set; }
        public int Episode_Number     { get; set; }
        public int Id                 { get; set; }
        public string Name            { get; set; }
        public string Overview        { get; set; }
        public string Production_Code { get; set; }
        public int Season_Number      { get; set; }
        public int Show_Id            { get; set; }
        public string Still_Path      { get; set; }
        public float Vote_Average     { get; set; }
        public int Vote_Count         { get; set; }
        public List<Actor> Cast       { get; set; }
        public List<Crew> Crew        { get; set; }

    }
}
