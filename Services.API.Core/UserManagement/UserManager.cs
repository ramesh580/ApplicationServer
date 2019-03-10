using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services.API.DataAccess.Repositories;
using Services.API.DataModel.DataTransferObjects;

namespace Services.API.Core.UserManagement
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _repository;
        public UserManager(IUserRepository repository)
        {
            this._repository = repository;
        }

        public DtoUser AuthenticateUser(DtoUser login)
        {
            DtoUser user = null; 
            user = _repository.GetAllUsers().FirstOrDefault(ee => ee.UserName == login.UserName);
            return user;
        }

        public List<DtoUser> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }
    }
}
