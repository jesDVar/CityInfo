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
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The bla bla...",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "A great park..."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A skyscraper."
                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Bla bla...",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Cathedral of Our Lady",
                            Description = "A Gothic style cathedral"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Antwerp Central Station",
                            Description = "A fine railway station."
                        },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The Country with good wine and cheese.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "The Eiffel Tower",
                            Description = "A tower on Champ de Mars."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        },
                    }
                },
            };
        }
    }
}

