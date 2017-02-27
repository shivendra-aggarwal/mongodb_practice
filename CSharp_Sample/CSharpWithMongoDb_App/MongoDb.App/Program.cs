using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDb.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MongoClient client = new MongoClient("mongodb://127.0.0.1:27017");

            IMongoDatabase database = client.GetDatabase("test");

            IMongoCollection<BsonDocument> restaurants = database.GetCollection<BsonDocument>("restaurants");

            BsonDocument restaurant = new BsonDocument();
            restaurant.Add(new BsonElement("name", "Shivendra from c#"));
            restaurant.Add(new BsonElement("borough", "c#"));

            restaurants.InsertOne(restaurant);

            System.Console.WriteLine(restaurant["_id"]);

            //BsonDocument doc = restaurants.FindOneAndUpdate()

            System.Console.ReadLine();

        }
    }
}
