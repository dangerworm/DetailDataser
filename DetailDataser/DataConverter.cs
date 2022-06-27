using DetailDataser.Models;
using DetailDataser.Repositories;
using MongoDB.Bson;

namespace DetailDataser
{
    public static class DataConverter
    {
        public static PersonRegistration ToPersonRegistration(this BsonDocument bsonDocument)
        {
            var name = bsonDocument.GetValue(PersonRegistrationRepository.NameFieldName).AsString;
            var dateOfBirth = bsonDocument.GetValue(PersonRegistrationRepository.DateOfBirthFieldName).AsBsonDateTime.ToUniversalTime();

            return new PersonRegistration(name, dateOfBirth);
        }

        public static BsonDocument ToBsonDocument(this PersonRegistration personRegistration)
        {
            return new BsonDocument
            {
                {PersonRegistrationRepository.NameFieldName, personRegistration.Name}, 
                {PersonRegistrationRepository.DateOfBirthFieldName, personRegistration.DateOfBirth}
            };
        }
    }
}
