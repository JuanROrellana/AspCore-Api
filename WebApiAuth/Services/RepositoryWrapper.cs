using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAuth.Data;
using WebApiAuth.Repositories;

namespace WebApiAuth.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApplicationDbContext _context;
        private IOwnerRepository _owner;
        private IAccountRepository _account;

        public IOwnerRepository Owner
        {
            get
            {
                if (_owner == null)
                    _owner = new OwnerRepository(_context);
                return _owner;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if(_account == null)
                    _account = new AccountRepository(_context);
                return _account;
            }
        }

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
