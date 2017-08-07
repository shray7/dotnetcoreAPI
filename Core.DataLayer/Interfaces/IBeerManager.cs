using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataLayer.Interfaces
{
    public interface IBeerManager
    {
        Beer AddBeer(Beer beer);
        void UpdateBeer(Beer beer);
        void DeleteBeer(Beer beer);
        IList<Beer> GetList();
        Beer GetBeer(int id);
    }
}
