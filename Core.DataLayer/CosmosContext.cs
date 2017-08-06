using System;
using System.Collections.Generic;

namespace Core.DataLayer
{
    public class CosmosContext : IDisposable
    {

        private bool disposed = false;

        private string connectionString = "mongodb://shraycore:VNt0xl5HNH5xXzXk38VsSlSeRarBMEkKl8o4itgwMY8NSmI9uFYCxdhDQ6wtcsFJN1Z63prYIhpKiD6gtgEwBw==@shraycore.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        private string userName = "shraycore";
        private string host = "shraycore.documents.azure.com";
        private string password = "VNt0xl5HNH5xXzXk38VsSlSeRarBMEkKl8o4itgwMY8NSmI9uFYCxdhDQ6wtcsFJN1Z63prYIhpKiD6gtgEwBw==";

        // This sample uses a database named "Tasks" and a 
        //collection named "TasksList".  The database and collection 
        //will be automatically created if they don't already exist.
        private string dbName = "CoreDocument";
        private string collectionName = "AirbnbListing";

        // Gets all Task items from the MongoDB server.        
        //public List<AirbnbListing> GetAllTasks()
        //{
            //    try
            //    {
            //        var collection = GetTasksCollection();
            //        return collection.Find(new BsonDocument()).ToList();
            //    }
            //    catch (MongoConnectionException)
            //    {
            //        return new List<MyTask>();
            //    }
            //return null;
        //}

        // Creates a Task and inserts it into the collection in MongoDB.
        //public void CreateTask(MyTask task)
        //{
        //    var collection = GetTasksCollectionForEdit();
        //    try
        //    {
        //        collection.InsertOne(task);
        //    }
        //    catch (MongoCommandException ex)
        //    {
        //        string msg = ex.Message;
        //    }
        //}

        //private IMongoCollection<MyTask> GetTasksCollection()
        //{
        //    MongoClientSettings settings = new MongoClientSettings();
        //    settings.Server = new MongoServerAddress(host, 10255);
        //    settings.UseSsl = true;
        //    settings.SslSettings = new SslSettings();
        //    settings.SslSettings.EnabledSslProtocols = SslProtocols.Tls12;

        //    MongoIdentity identity = new MongoInternalIdentity(dbName, userName);
        //    MongoIdentityEvidence evidence = new PasswordEvidence(password);

        //    settings.Credentials = new List<MongoCredential>()
        //    {
        //        new MongoCredential("SCRAM-SHA-1", identity, evidence)
        //    };

        //    MongoClient client = new MongoClient(settings);
        //    var database = client.GetDatabase(dbName);
        //    var todoTaskCollection = database.GetCollection<MyTask>(collectionName);
        //    return todoTaskCollection;
        //}

        //private IMongoCollection<MyTask> GetTasksCollectionForEdit()
        //{
        //    MongoClientSettings settings = new MongoClientSettings();
        //    settings.Server = new MongoServerAddress(host, 10255);
        //    settings.UseSsl = true;
        //    settings.SslSettings = new SslSettings();
        //    settings.SslSettings.EnabledSslProtocols = SslProtocols.Tls12;

        //    MongoIdentity identity = new MongoInternalIdentity(dbName, userName);
        //    MongoIdentityEvidence evidence = new PasswordEvidence(password);

        //    settings.Credentials = new List<MongoCredential>()
        //    {
        //        new MongoCredential("SCRAM-SHA-1", identity, evidence)
        //    };
        //    MongoClient client = new MongoClient(settings);
        //    var database = client.GetDatabase(dbName);
        //    var todoTaskCollection = database.GetCollection<MyTask>(collectionName);
        //    return todoTaskCollection;
        //}

        # region IDisposable

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                }
            }

            this.disposed = true;
        }

        # endregion
    }
}
