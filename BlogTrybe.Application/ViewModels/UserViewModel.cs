namespace BlogTrybe.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(/*int id,*/ string displayName, string email, string image)
        {
            //Id = id;
            DisplayName = displayName;
            Email = email;
            Image = image;
        }

        //public int Id { get; private set; }
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string Image { get; private set; }
    }
}
