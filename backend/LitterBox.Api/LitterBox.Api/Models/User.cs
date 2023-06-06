using LitterBox.Api.Models.Entities;

namespace LitterBox.Api.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
