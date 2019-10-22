using DDona.RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Domain.Interfaces.Services
{
    public interface IPersonService : IBaseService
    {
        IList<Person> GetAllActivePeople();
        IList<Person> GetAllInactivePeople();
    }
}
