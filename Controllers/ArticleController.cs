using JwtApp.Models;
using JwtAppNew.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;

namespace JwtAppNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IConfiguration _config;

        public ArticleController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        [Authorize]
        public List<ArticleModel> Article()
        {
            var article = ArticleConstants.Articles;
            return article.ToList();
        }

        [HttpGet("{Id}")]
        [Authorize]
        public ArticleModel ArticleById(int Id)
        {
            var article = ArticleConstants.Articles.Where(x => x.id == Id).FirstOrDefault();
            return article;
        }

    }
}
