using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API.DataAccess.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RedbexDBContext _repoContext;
        private IUserRepository _user; 

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }

                return _user;
            }
        } 

        public RepositoryWrapper(RedbexDBContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
