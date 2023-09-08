﻿using Catelog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catelog.Core.Repositories
{
    public interface ITypesRepository
    {
        Task<IEnumerable<ProductType>> GetAllTypes();

    }
}
