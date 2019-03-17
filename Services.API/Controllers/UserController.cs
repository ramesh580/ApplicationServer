namespace Services.API.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Services.API.Core.UserManagement;
    using Services.API.DataModel.DataTransferObjects;
    using System.Collections.Generic;

    [Authorize]
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            this._userManager = userManager;
        }

        // GET api/values
        [EnableCors("MyPolicy")]
        [HttpGet("GetUsers")]
        public ActionResult<IEnumerable<DtoUser>> GetUsers()
        {
            return _userManager.GetAllUsers();
        }


        // Post api/values
        [HttpPost("GetUser")]
        public ActionResult<IEnumerable<DtoUser>> GetUser([FromBody]DtoUser user)
        {
            return _userManager.GetAllUsers();
        }
    }
}
