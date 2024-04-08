using System.ComponentModel;

namespace RazorLesson.Models
{
    public class UserModel
    {
        [DisplayName("First name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last name")]
        public string LastName { get; set; } = string.Empty;
        public string SelectedCountry { get; set; } = string.Empty;
        public List<CountryModel> CountryList { get; set; }
    }
}
