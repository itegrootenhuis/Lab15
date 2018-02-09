using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class CountiesController
    {
        public static List<string> GetCountryList()
        {
            return CountriesModel.ReadFile();
        }

        public static void AddCountryToList(string countryName)
        {
            CountriesModel.WriteFile(countryName);
        }
    }
}