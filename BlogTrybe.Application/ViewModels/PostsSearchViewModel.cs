using System;

namespace BlogTrybe.Application.ViewModels
{
    public class PostsSearchViewModel
    {
        public PostsSearchViewModel(int id, 
                                    DateTime published,
                                    DateTime? update,
                                    string title,
                                    string content,
                                    int idUser,
                                    string displayName,
                                    string email,
                                    string image)
        {
            Id = id;
            Published = published;
            UpDate = update;
            Title = title;
            Content = content;
            IdUser = idUser;
            DisplayName = displayName;
            Email = email;
            Image = image;
        }

        public int Id { get; private set; }
        public DateTime Published { get; private set; }
        public DateTime? UpDate { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int IdUser { get; private set; }
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string Image { get; private set; }
    }
}
