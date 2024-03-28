using Microsoft.AspNetCore.Identity;

namespace Remote_IOT_Lab.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public readonly new string Id;
        private Extensions.Name _name;
        public Extensions.Name Name { get => _name; }
        private List<Role> _roles;
        private List<Organization> _organizations;
        private List<Group> _groups;

        public ApplicationUser()
        {
            Id = Guid.NewGuid().ToString();
        }

        public ApplicationUser(string name, string surname)
        {
            Id = Guid.NewGuid().ToString();
            _name = new Extensions.Name(name, surname);
        }

        public ApplicationUser(Extensions.Name name) 
        {
            Id = Guid.NewGuid().ToString();
            _name = name;
        }
    }
}
