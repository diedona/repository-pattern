using System;
using System.Collections.Generic;

namespace DDona.RepositoryPattern.Domain.Entities
{
    public partial class Person
    {
        public Person()
        {
            JobXperson = new HashSet<JobXperson>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<JobXperson> JobXperson { get; set; }
    }
}