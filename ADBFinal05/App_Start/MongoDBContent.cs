using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ADBFinal05.App_Start
{
    public class MongoDBContent
    {
       // MongoClient client;
        public IMongoDatabase database;
        public MongoDBContent()
        {
            //var client = new MongoClient("mongodb+srv://MongoDB:mongodb@adb-2e3eb.mongodb.net/ADBFinal05?retryWrites=true&w=majority");
            var client = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = client.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);

            //Test Connection
            //database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait();
        }
    }
}