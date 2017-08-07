using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataLayer.Interfaces
{
    public interface IBreweryManager
    {
        Brewery AddBrewery(Brewery brewery);
        void UpdateBrewery(Brewery brewery);
        void DeleteBrewery(Brewery brewery);
        IList<Brewery> GetList();
        Brewery GetBrewery(int id);
    }
}
