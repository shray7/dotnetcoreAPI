using Core.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
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
            db.Query<Brewery>("Insert into Brewery Values()").AsList();
            return brewery;
        }

        public void DeleteBrewery(Brewery brewery)
        {
            throw new NotImplementedException();
        }

        public Brewery GetBrewery(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Brewery> GetList()
        {
            return db.Query<Brewery>("Select * From Brewery").AsList();
        }

        public void UpdateBrewery(Brewery brewery)
        {
            throw new NotImplementedException();
        }
    }
}
