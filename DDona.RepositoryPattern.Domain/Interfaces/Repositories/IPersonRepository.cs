using DDona.RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Domain.Interfaces.Repositories
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        IList<Person> GetInactive();
    }
}
