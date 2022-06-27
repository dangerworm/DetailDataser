using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DetailDataser
{
    public class Details
    {
        public string name { get; }
        public DateTime DOB { get; }
        public BsonDocument document { get; }
        public MongoClient dbClient { get; }
        public Details(string Name, DateTime Age)
        {
            DOB = Age;
            name = Name;
            document = new BsonDocument { { "name", name }, { "age", DOB } };
            dbClient = new MongoClient("mongodb+srv://dbuser:dbuser@cluster0.sssd1.mongodb.net/?retryWrites=true&w=majority");
        }
        public List<BsonDocument> ReadFrom()
        {
            var database = dbClient.GetDatabase("testdb");
            var collection = database.GetCollection<BsonDocument>("peopleReg");
            var documents = collection.Find(new BsonDocument()).ToList();
            return documents;
        }
        public void Submit()
        {
            var database = dbClient.GetDatabase("testdb");
            var collection = database.GetCollection<BsonDocument>("peopleReg");
            collection.InsertOne(document);
        }
    }
}
