using AutoMapper;
using DDona.RepositoryPattern.Domain.DataTransferObjects;
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
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public PersonService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IList<PersonWithStatusDTO> GetAllActivePeople()
        {
            var domain = _uow.PersonRepository.Get();
            var dto = _mapper.Map<IList<PersonWithStatusDTO>>(domain);
            return dto;
        }

        public IList<PersonWithStatusDTO> GetAllInactivePeople()
        {
            var domain =  _uow.PersonRepository.GetInactive();
            var dto = _mapper.Map<IList<PersonWithStatusDTO>>(domain);
            return dto;
        }
    }
}
