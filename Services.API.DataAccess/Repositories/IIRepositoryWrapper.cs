using System;
using System.Collections.Generic;
using System.Text;

namespace Services.API.DataAccess.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; } 
    }
}
