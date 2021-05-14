using System;

namespace BlogTrybe.API.Models
{
    public class CreatePostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Published { get; set; }
        public DateTime UpDate { get; set; }
    }
}
