using DDona.RepositoryPattern.Domain.Entities;
using DDona.RepositoryPattern.Domain.Interfaces;
using DDona.RepositoryPattern.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Service
{
    public class PersonService : IPersonService
    {
        private IUnitOfWork _uow;

        public PersonService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IList<Person> GetAllActivePeople()
        {
            return _uow.PersonRepository.Get();
        }

        public IList<Person> GetAllInactivePeople()
        {
            return _uow.PersonRepository.GetInactive();
        }
    }
}
