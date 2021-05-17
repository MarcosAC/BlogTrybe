using System;

namespace BlogTrybe.Application.ViewModels
{
    public class PostViewModel
    {
        public PostViewModel(int id, string title, string content, DateTime published)
        {
            Id = id;
            Title = title;
            Content = content;
            Published = published;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime Published { get; private set; }
    }
}
