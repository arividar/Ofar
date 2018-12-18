using System;

namespace OfarEntities
{
    public class Photographer
    {
        public long      Id         { get; set; }
        public string    FirstName  { get; set; }
        public string    LastName   { get; set; }
        public DateTime? BirthDate  { get; set; }
        public string    Country    { get; set; }
    }
}
