using System;
using System.Collections.Generic;
//using Core.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Security.Authentication;
using MongoDB.Bson.Serialization;

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
        public AirbnbListing GetAllTasks()
        {
            BsonClassMap.RegisterClassMap<AirbnbListing>(x =>
            {
                x.AutoMap();
                x.GetMemberMap(m => m.ListingUrl).SetElementName("Listing Url");
                x.GetMemberMap(m => m.ScrapeID).SetElementName("Scrape ID");
                x.GetMemberMap(m => m.LastScraped).SetElementName("Last Scraped");
                x.GetMemberMap(m => m.ExperiencesOffered).SetElementName("Experiences Offered");
                x.GetMemberMap(m => m.NeighborhoodOverview).SetElementName("Neighborhood Overview");
                x.GetMemberMap(m => m.HouseRules).SetElementName("House Rules");
                x.GetMemberMap(m => m.ThumbnailUrl).SetElementName("Thumbnail Url");
                x.GetMemberMap(m => m.MediumUrl).SetElementName("Medium Url");
                x.GetMemberMap(m => m.PictureUrl).SetElementName("Picture Url");
                x.GetMemberMap(m => m.XLPictureUrl).SetElementName("XL Picture Url");
                x.GetMemberMap(m => m.HostID).SetElementName("Host ID");
                x.GetMemberMap(m => m.HostURL).SetElementName("Host URL");
                x.GetMemberMap(m => m.HostName).SetElementName("Host Name");
                x.GetMemberMap(m => m.HostSince).SetElementName("Host Since");
                x.GetMemberMap(m => m.HostLocation).SetElementName("Host Location");
                x.GetMemberMap(m => m.HostAbout).SetElementName("Host About");
                x.GetMemberMap(m => m.HostResponseTime).SetElementName("Host Response Time");
                x.GetMemberMap(m => m.HostResponseRate).SetElementName("Host Response Rate");
                x.GetMemberMap(m => m.HostAcceptanceRate).SetElementName("Host Acceptance Rate");
                x.GetMemberMap(m => m.HostThumbnailUrl).SetElementName("Host Thumbnail Url");
                x.GetMemberMap(m => m.HostPictureUrl).SetElementName("Host Picture Url");
                x.GetMemberMap(m => m.HostNeighbourhood).SetElementName("Host Neighbourhood");
                x.GetMemberMap(m => m.HostListingsCount).SetElementName("Host Listings Count");
                x.GetMemberMap(m => m.HostTotalListingsCount).SetElementName("Host Total Listings Count");
                x.GetMemberMap(m => m.HostVerifications).SetElementName("Host Verifications");
                x.GetMemberMap(m => m.NeighbourhoodCleansed).SetElementName("Neighbourhood Cleansed");
                x.GetMemberMap(m => m.NeighbourhoodGroupCleansed).SetElementName("Neighbourhood Group Cleansed");
                x.GetMemberMap(m => m.SmartLocation).SetElementName("Smart Location");
                x.GetMemberMap(m => m.CountryCode).SetElementName("Country Code");
                x.GetMemberMap(m => m.PropertyType).SetElementName("Property Type");
                x.GetMemberMap(m => m.RoomType).SetElementName("Room Type");
                x.GetMemberMap(m => m.BedType).SetElementName("Bed Type");
                x.GetMemberMap(m => m.SquareFeet).SetElementName("Square Feet");
                x.GetMemberMap(m => m.WeeklyPrice).SetElementName("Weekly Price");
                x.GetMemberMap(m => m.MonthlyPrice).SetElementName("Monthly Price");
                x.GetMemberMap(m => m.SecurityDeposit).SetElementName("Security Deposit");
                x.GetMemberMap(m => m.CleaningFee).SetElementName("Cleaning Fee");
                x.GetMemberMap(m => m.GuestsIncluded).SetElementName("Guests Included");
                x.GetMemberMap(m => m.ExtraPeople).SetElementName("Extra People");
                x.GetMemberMap(m => m.MinimumNights).SetElementName("Minimum Nights");
                x.GetMemberMap(m => m.MaximumNights).SetElementName("Maximum Nights");
                x.GetMemberMap(m => m.CalendarUpdated).SetElementName("Calendar Updated");
                x.GetMemberMap(m => m.HasAvailability).SetElementName("Has Availability");
                x.GetMemberMap(m => m.Availability30).SetElementName("Availability 30");
                x.GetMemberMap(m => m.Availability60).SetElementName("Availability 60");
                x.GetMemberMap(m => m.Availability90).SetElementName("Availability 90");
                x.GetMemberMap(m => m.Availability365).SetElementName("Availability 365");
                x.GetMemberMap(m => m.CalendarlastScraped).SetElementName("Calendar last Scraped");
                x.GetMemberMap(m => m.NumberofReviews).SetElementName("Number of Reviews");
                x.GetMemberMap(m => m.FirstReview).SetElementName("First Review");
                x.GetMemberMap(m => m.LastReview).SetElementName("Last Review");
                x.GetMemberMap(m => m.ReviewScoresRating).SetElementName("Review Scores Rating");
                x.GetMemberMap(m => m.ReviewScoresAccuracy).SetElementName("Review Scores Accuracy");
                x.GetMemberMap(m => m.ReviewScoresCleanliness).SetElementName("Review Scores Cleanliness");
                x.GetMemberMap(m => m.ReviewScoresCheckin).SetElementName("Review Scores Checkin");
                x.GetMemberMap(m => m.ReviewScoresCommunication).SetElementName("Review Scores Communication");
                x.GetMemberMap(m => m.ReviewScoresLocation).SetElementName("Review Scores Location");
                x.GetMemberMap(m => m.ReviewScoresValue).SetElementName("Review Scores Value");
                x.GetMemberMap(m => m.JurisdictionNames).SetElementName("Jurisdiction Names");
                x.GetMemberMap(m => m.CancellationPolicy).SetElementName("Cancellation Policy");
                x.GetMemberMap(m => m.Calculatedhostlistingscount).SetElementName("Calculated host listings count");
                x.GetMemberMap(m => m.ReviewsperMonth).SetElementName("Reviews per Month");

            });
            try
            {
                var collection = GetTasksCollection();
                var result = collection.Find(new BsonDocument()).FirstOrDefault();
                return result;
        
            }
            catch (MongoConnectionException)
            {
                return new AirbnbListing();
            }
        }

        //Creates a Task and inserts it into the collection in MongoDB.
        public void CreateTask(AirbnbListing task)
        {
            var collection = GetTasksCollectionForEdit();
            try
            {
                collection.InsertOne(task);
            }
            catch (MongoCommandException ex)
            {
                string msg = ex.Message;
            }
        }

        private IMongoCollection<AirbnbListing> GetTasksCollection()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress(host, 10255);
            settings.UseSsl = true;
            settings.SslSettings = new SslSettings();
            settings.SslSettings.EnabledSslProtocols = SslProtocols.Tls12;

            MongoIdentity identity = new MongoInternalIdentity(dbName, userName);
            MongoIdentityEvidence evidence = new PasswordEvidence(password);

            settings.Credentials = new List<MongoCredential>()
            {

                new MongoCredential("SCRAM-SHA-1", identity, evidence)
            };

            MongoClient client = new MongoClient(settings);



            var database = client.GetDatabase(dbName);
            var todoTaskCollection = database.GetCollection<AirbnbListing>(collectionName);
            return todoTaskCollection;
        }

        private IMongoCollection<AirbnbListing> GetTasksCollectionForEdit()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress(host, 10255);
            settings.UseSsl = true;
            settings.SslSettings = new SslSettings();
            settings.SslSettings.EnabledSslProtocols = SslProtocols.Tls12;

            MongoIdentity identity = new MongoInternalIdentity(dbName, userName);
            MongoIdentityEvidence evidence = new PasswordEvidence(password);

            settings.Credentials = new List<MongoCredential>()
            {
                new MongoCredential("SCRAM-SHA-1", identity, evidence)
            };
            MongoClient client = new MongoClient(settings);
            var database = client.GetDatabase(dbName);
            var todoTaskCollection = database.GetCollection<AirbnbListing>(collectionName);
            return todoTaskCollection;
        }

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
