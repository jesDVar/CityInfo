using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            // Init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto() { Id = 1, Name ="New York City", Description = "The bla bla..."},
                new CityDto() { Id = 2, Name ="Antwerp", Description = "Bla bla..."},
                new CityDto(){ Id = 3, Name = "Paris", Description = "Voilá."}

            };
        }
    }
}
