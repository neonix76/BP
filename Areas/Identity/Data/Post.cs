namespace BP.Areas.Identity.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public byte[]? Picture { get; set; }

    }
}
