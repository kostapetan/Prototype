using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Models;
using RecordUnionPrototype;

namespace Domain.Common.Services
{
    public class CountryService
    {
        private readonly IRepository<Country> _repository;

        public CountryService(IRepository<Country> repository)
        {
            _repository = repository;
        }
    }
}
