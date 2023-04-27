using JwtAppNew.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace JwtAppNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IConfiguration _config;

        public ProfileController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("Test")]
        [Authorize]
        public List<ProfileModel> Test()
        {
            var profile = ProfileConstants.Profile;
            return profile.ToList();
        }

        [HttpGet]
        [Authorize]
        public List<ProfileModel> Profile()
        {
            var profile = ProfileConstants.Profile;
            return profile.ToList();
        }
    }
}
