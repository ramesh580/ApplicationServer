using Services.API.DataAccess.Repositories;
using Services.API.DataModel.DataTransferObjects;
using System.Collections.Generic;
using System.Linq;

namespace Services.API.Core.UserManagement
{
    public class UserManager : IUserManager
    {
        private IRepositoryWrapper _repository;
         
        public UserManager(IRepositoryWrapper repository)
        {
            this._repository = repository;
        }

        public DtoUser AuthenticateUser(DtoUser login)
        { 
            return (from user in _repository.User.FindAll()
                          select new DtoUser()
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                }).ToList().FirstOrDefault(ee => ee.UserName == login.UserName);   
        }

        public List<DtoUser> GetAllUsers()
        {
            return _repository.User.GetAllUsers();
        }
    }
}
