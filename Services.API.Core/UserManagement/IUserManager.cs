namespace Services.API.Core.UserManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Services.API.DataModel.DataTransferObjects;

    public interface IUserManager
    {
        List<DtoUser> GetAllUsers();

        DtoUser AuthenticateUser(DtoUser login);
    }
}
