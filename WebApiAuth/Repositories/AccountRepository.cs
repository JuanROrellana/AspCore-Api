using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAuth.Data;
using WebApiAuth.Models;

namespace WebApiAuth.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
