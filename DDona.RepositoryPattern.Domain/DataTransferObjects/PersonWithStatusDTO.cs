﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Domain.DataTransferObjects
{
    public class PersonWithStatusDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
