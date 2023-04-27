namespace JwtAppNew.Models
{
    public class ArticleModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }
}
