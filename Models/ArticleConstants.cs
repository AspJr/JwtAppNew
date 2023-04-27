using JwtApp.Models;
using System.Collections.Generic;

namespace JwtAppNew.Models
{
    public class ArticleConstants
    {
        public static List<ArticleModel> Articles = new List<ArticleModel>()
        {
            new ArticleModel() { id = 1, title = "Ronaldo's Team wins the Europa League", body = "testtesttesttesttest test testtest testtest test" },
            new ArticleModel() { id = 2, title = "Messi's Team wins the America League", body = "testtesttesttesttest test testtest testtest test" },
            new ArticleModel() { id = 3, title = "Mbappe's Team wins the France League", body = "testtesttesttesttest test testtest testtest test" },
         };
    }
}
