using Services.API.DataModel.DataTransferObjects;
using System.Collections.Generic;

namespace Services.API.DataAccess.Repositories.User
{
    public interface IUserDapperRepository
    {
        List<DtoUser> SelectAll();
    }
}
