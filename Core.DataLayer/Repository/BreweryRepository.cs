using Core.DataLayer.Interfaces;
using System.Collections.Generic;
using Core.Models;
using Dapper;
using System.Data.SqlClient;

namespace Core.DataLayer.Repository
{
    public class BreweryRepository : IBreweryManager
    {
        private SqlConnection db;
        private string connectionString = "Server=tcp:wcb6doyo9l.database.windows.net,1433;Initial Catalog=Core;Persist Security Info=False;User ID=shray;Password=Pass@word1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public BreweryRepository()
        {
            db = new SqlConnection(connectionString);
        }
        public Brewery AddBrewery(Brewery brewery)
        {
            db.Execute(string.Format("Insert into Brewery (Name, City, State)Values('{0}','{1}','{2}')", brewery.Name, brewery.City, brewery.State));
            return brewery;
        }

        public void DeleteBrewery(int id)
        {
            db.Execute(string.Format("Delete FROM Brewery WHERE Brewery.BreweryID = {0}", id));
        }

        public Brewery GetBrewery(int id)
        {
            return db.QueryFirstOrDefault<Brewery>(string.Format("Select * From Brewery WHERE Brewery.BreweryID = {0}", id));
        }

        public IList<Brewery> GetList()
        {
            
            return db.Query<Brewery>("Select * From Brewery").AsList();
        }

        public void UpdateBrewery(Brewery brewery)
        {
            string sqlQuery = "UPDATE Brewery SET Name = @Name, City = @City, State = @State WHERE BreweryId = @BreweryId";

            db.Execute(sqlQuery, brewery);
        }
    }
}
