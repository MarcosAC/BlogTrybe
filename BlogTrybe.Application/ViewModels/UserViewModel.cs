namespace BlogTrybe.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string displayName, string email, string image)
        {
            DisplayName = displayName;
            Email = email;
            Image = image;
        }

        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string Image { get; private set; }
    }
}
