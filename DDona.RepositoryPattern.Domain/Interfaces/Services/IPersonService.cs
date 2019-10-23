using DDona.RepositoryPattern.Domain.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Domain.Interfaces.Services
{
    public interface IPersonService : IBaseService
    {
        IList<PersonWithStatusDTO> GetAllActivePeople();
        IList<PersonWithStatusDTO> GetAllInactivePeople();
    }
}
