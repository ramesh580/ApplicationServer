namespace Services.API.DataAccess.Repositories
{
    using Services.API.DataAccess.Models;
    using Services.API.DataModel.DataTransferObjects;
    using System.Collections.Generic;

    public interface IUserRepository:  IRepositoryBase<Users>
    {
        List<DtoUser> GetAllUsers();

        bool CheckUser(string userName);
    }
}
