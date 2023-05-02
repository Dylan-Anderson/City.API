using CityInfo.API.Models;

namespace CityInfo.API
{   
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Pittsburgh",
                    Description = "Lots of bridges",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Point State Park",
                            Description = "Where the three rivers meet"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Detroit",
                    Description = "Rocket Mortgage is here",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Rocket Mortgage",
                            Description = "Its a company"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Tampa",
                    Description = "Good hockey team",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Hogans Beach Club",
                            Description = "Hulk Hogan owns a beach club here"
                        }
                    }
                }
            };
        }
    }
}
