using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Extensions.Configuration;
using Services.API.DataModel.DataTransferObjects;

namespace Services.API.DataAccess.Repositories.User
{
    class UserDapperRespostiory : IUserDapperRepository
    {
        private readonly IConfiguration _config;

        public UserDapperRespostiory(IConfiguration config)
        {
            this._config = config;

        }


        public List<DtoUser> SelectAll()
            {
                using (IDbConnection connection = Connection)
                {
                    string query = "SELECT UserName FROM Users";
                    connection.Open();
                    var result = connection.Query<DtoUser>(query);
                    return result.ToList();
                }
            }

        /// <summary>
        /// Get connection.
        /// </summary>
        private IDbConnection Connection
        {
            get { return new SqlConnection(_config.GetConnectionString("ConnectionString:RedbexDB")); }
        }
    }
}
