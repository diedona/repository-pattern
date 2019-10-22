using System;
using System.Collections.Generic;

namespace DDona.RepositoryPattern.Domain.Entities
{
    public partial class JobXperson
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int PersonId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }

        public virtual Job Job { get; set; }
        public virtual Person Person { get; set; }
    }
}