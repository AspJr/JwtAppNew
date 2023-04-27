using JwtApp.Models;
using JwtAppNew.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace JwtAppNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private IConfiguration _config;
        IFirebaseClient client;

        public RegisterController(IConfiguration config)
        {
            _config = config;
        }

        IFirebaseConfig f_config = new FirebaseConfig()
        {
            AuthSecret = "Y51THIWtlz4zCUBYimODkhO4xScnAAnJI6gTjYav",
            BasePath = "https://dbfirebase-88eba-default-rtdb.firebaseio.com/",
        };

        [HttpPost("Reg")]
        [Authorize]
        public IActionResult Reg()
        {
            client = new FireSharp.FirebaseClient(f_config);
            if (client != null)
            {
                return Ok("Connection established");
            }
            else {
                return Ok("Connection not established");
            }
     
        }

        [HttpPost]   
        [Authorize]
        public IActionResult Register([FromBody] ProfileModel register)
        {
            string strJson = System.Text.Json.JsonSerializer.Serialize<ProfileModel>(register);
            var request = WebRequest.CreateHttp("https://dbfirebase-88eba-default-rtdb.firebaseio.com/.json");
            request.Method = "POST";
            request.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(strJson);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            strJson = (new StreamReader(response.GetResponseStream())).ReadToEnd();
            return NotFound("Profile has been created successfully");
        }
    }
}
