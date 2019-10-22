using DDona.RepositoryPattern.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IPersonRepository PersonRepository { get; }
        void Commit();
    }
}
