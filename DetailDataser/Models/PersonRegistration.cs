using MongoDB.Bson;

namespace DetailDataser.Models
{
    public class PersonRegistration
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PersonRegistration(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }
}
