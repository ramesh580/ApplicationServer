using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services.API.DataModel.DataTransferObjects;

namespace Services.API.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {

        private RedbexApplicationServerDatabaseInstancecadContext _context;

        public UserRepository(
            RedbexApplicationServerDatabaseInstancecadContext context)
        {
            this._context = context;
        }

        public List<DtoUser> GetAllUsers()
        {
            var result = (from user in this._context.Users
                select new DtoUser()
                {
                    UserName = user.UserName, FirstName = user.FirstName, LastName = user.LastName
                }).ToList();

            return result;
        }

        public bool CheckUser(string userName)
        {
            var user = this._context.Users.FirstOrDefault(ee => ee.UserName == userName);
            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}
