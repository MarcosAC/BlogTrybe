namespace DevFreela.API.Models
{
    public class CreateUserModel
    {
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Image { get; private set; }
    }
}
