using DDona.RepositoryPattern.Domain.DataTransferObjects;
using DDona.RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Domain.Mapping
{
    public class EntityToDTOMapper : AutoMapper.Profile
    {
        public EntityToDTOMapper()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<Person, PersonWithStatusDTO>().ReverseMap();
        }
    }
}
