namespace Services.API.DataAccess.Repositories
{
    using Services.API.DataModel.DataTransferObjects;
    using System.Collections.Generic;

    public interface IUserRepository
    {
        List<DtoUser> GetAllUsers();

        bool CheckUser(string userName);
    }
}
