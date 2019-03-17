using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using Services.API.DataAccess.Models;
using Services.API.DataModel.DataTransferObjects;

namespace Services.API.DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<Users>, IUserRepository
    {

        private RedbexDBContext _context;
         
        public UserRepository(RedbexDBContext repositoryContext)
            : base(repositoryContext)
        {
            this._context = repositoryContext;

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
