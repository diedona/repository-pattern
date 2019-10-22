using DDona.RepositoryPattern.Domain.Interfaces;
using DDona.RepositoryPattern.Domain.Interfaces.Repositories;
using DDona.RepositoryPattern.Infra.Contexts;
using DDona.RepositoryPattern.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Infra.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private RepositoryPatternDbContext _context;
        private IPersonRepository _personRepository;

        public UnitOfWork(RepositoryPatternDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public IPersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(_context);
                }

                return _personRepository;
            }
        }
    }
}
