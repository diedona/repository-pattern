using DDona.RepositoryPattern.Domain.Entities;
using DDona.RepositoryPattern.Domain.Interfaces.Repositories;
using DDona.RepositoryPattern.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.RepositoryPattern.Infra.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryPatternDbContext db) : base(db)
        {
        }

        public override IList<Person> Get()
        {
            return _db.Person
                .Where(x => x.Status)
                .OrderBy(x => x.Name)
                .ToList();
        }

        public IList<Person> GetInactive()
        {
            return _db.Person
                .Where(x => !x.Status)
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}
