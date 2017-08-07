using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataLayer
{
    public class AirbnbListing
    {
        
        public object ID { get; set; }
        public string ListingUrl { get; set; }
        public object ScrapeID { get; set; }
        public DateTime? LastScraped { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public object Space { get; set; }
        public string Description { get; set; }
        public string ExperiencesOffered { get; set; }
        public object NeighborhoodOverview { get; set; }
        public object Notes { get; set; }
        public object Transit { get; set; }
        public object Access { get; set; }
        public object Interaction { get; set; }
        public object HouseRules { get; set; }
        public string ThumbnailUrl { get; set; }
        public string MediumUrl { get; set; }
        public object PictureUrl { get; set; }
        public string XLPictureUrl { get; set; }
        public object HostID { get; set; }
        public string HostURL { get; set; }
        public string HostName { get; set; }
        public DateTime? HostSince { get; set; }
        public string HostLocation { get; set; }
        public string HostAbout { get; set; }
        public string HostResponseTime { get; set; }
        public object HostResponseRate { get; set; }
        public string HostAcceptanceRate { get; set; }
        public string HostThumbnailUrl { get; set; }
        public string HostPictureUrl { get; set; }
        public string HostNeighbourhood { get; set; }
        public int? HostListingsCount { get; set; }
        public int? HostTotalListingsCount { get; set; }
        public string HostVerifications { get; set; }
        public string Street { get; set; }
        public string Neighbourhood { get; set; }
        public string NeighbourhoodCleansed { get; set; }
        public object NeighbourhoodGroupCleansed { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public BsonDateTime Zipcode { get; set; }
        public string Market { get; set; }
        public string SmartLocation { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public string PropertyType { get; set; }
        public string RoomType { get; set; }
        public int? Accommodates { get; set; }
        public float Bathrooms { get; set; }
        public int? Bedrooms { get; set; }
        public int? Beds { get; set; }
        public string BedType { get; set; }
        public string Amenities { get; set; }
        public object SquareFeet { get; set; }
        public object Price { get; set; }
        public object WeeklyPrice { get; set; }
        public object MonthlyPrice { get; set; }
        public object SecurityDeposit { get; set; }
        public object CleaningFee { get; set; }
        public int? GuestsIncluded { get; set; }
        public object ExtraPeople { get; set; }
        public int? MinimumNights { get; set; }
        public int? MaximumNights { get; set; }
        public string CalendarUpdated { get; set; }
        public object HasAvailability { get; set; }
        public int? Availability30 { get; set; }
        public int? Availability60 { get; set; }
        public int? Availability90 { get; set; }
        public int? Availability365 { get; set; }
        public DateTime? CalendarlastScraped { get; set; }
        public int? NumberofReviews { get; set; }
        public DateTime? FirstReview { get; set; }
        public DateTime? LastReview { get; set; }
        public DateTime? ReviewScoresRating { get; set; }
        public DateTime? ReviewScoresAccuracy { get; set; }
        public DateTime? ReviewScoresCleanliness { get; set; }
        public DateTime? ReviewScoresCheckin { get; set; }
        public DateTime? ReviewScoresCommunication { get; set; }
        public DateTime? ReviewScoresLocation { get; set; }
        public DateTime? ReviewScoresValue { get; set; }
        public object License { get; set; }
        public string JurisdictionNames { get; set; }
        public string CancellationPolicy { get; set; }
        public int? Calculatedhostlistingscount { get; set; }
        public string ReviewsperMonth { get; set; }
        public object Geolocation { get; set; }
        public object Features { get; set; }
        public ObjectId _id { get; set; }
    }
}
