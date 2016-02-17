using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Discovery.Models;
using RecordUnionPrototype;

namespace Domain.Discovery.Services
{
    public class PartnerService
    {
        private readonly IRepository<Partner> _repository;

        public PartnerService(IRepository<Partner> repository)
        {
            _repository = repository;
        }
    }
}
