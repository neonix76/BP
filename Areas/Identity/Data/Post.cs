namespace BP.Areas.Identity.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// тут нужно пользователя получить
        /// </summary>
        public byte[]? Picture { get; set; }
    }
}
