using System;
using System.Collections.Generic;

namespace lab3.Models.Toons
{
    public partial class Actors
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MovieId { get; set; }

        public virtual Movies Movie { get; set; }
    }
}
