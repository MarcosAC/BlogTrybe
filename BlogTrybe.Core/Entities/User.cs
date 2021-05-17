using System.Collections.Generic;

namespace BlogTrybe.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string displayName, string email, string password, string image)
        {
            DisplayName = displayName;
            Email = email;
            Password = password;
            Image = image;
            UserPosts = new List<Post>();
        }

        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Image { get; private set; }
        public List<Post> UserPosts { get; set; }
    }
}
