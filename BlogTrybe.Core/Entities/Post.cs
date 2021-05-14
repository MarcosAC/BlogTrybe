using System;

namespace BlogTrybe.Core.Entities
{
    public class Post : BaseEntity
    {
        public Post(string title, string content, int idUser)
        {
            Title = title;
            Content = content;
            Published = DateTime.Now;
            IdUser = idUser;
        }

        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime Published { get; private set; }
        public DateTime? UpDate { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }

        public void Update(string title, string content)
        {
            Title = title;
            Content = content;
            UpDate = DateTime.Now;
        }
    }
}