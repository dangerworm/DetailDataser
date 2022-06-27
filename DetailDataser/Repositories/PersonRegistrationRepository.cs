using DetailDataser.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DetailDataser.Repositories
{
    public class PersonRegistrationRepository
    {
        public const string NameFieldName = "Name";
        public const string DateOfBirthFieldName = "DateOfBirth";

        private const string ConnectionString = "mongodb+srv://dbuser:dbuser@cluster0.sssd1.mongodb.net/?retryWrites=true&w=majority";
        private const string DatabaseName = "testdb";
        private const string CollectionName = "peopleReg";

        private readonly IMongoDatabase _database;

        public PersonRegistrationRepository()
        {
            _database = new MongoClient(ConnectionString).GetDatabase(DatabaseName);
        }

        public void Create(PersonRegistration personRegistration)
        {
            var bsonDocument = personRegistration.ToBsonDocument();

            var collection = _database.GetCollection<BsonDocument>(CollectionName);
            collection.InsertOne(bsonDocument);
        }

        public List<PersonRegistration> ReadAll()
        {
            return _database
                .GetCollection<BsonDocument>(CollectionName)
                .Find(x => x != null)
                .ToList()
                .Select(DataConverter.ToPersonRegistration)
                .ToList();
        }
    }
}
