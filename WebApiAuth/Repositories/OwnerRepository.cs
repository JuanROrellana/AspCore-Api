using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAuth.Data;
using WebApiAuth.Models;

namespace WebApiAuth.Repositories
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
