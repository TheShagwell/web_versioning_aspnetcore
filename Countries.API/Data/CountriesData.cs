using Countries.API.Models.Domain;

namespace Countries.API.Data
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
{
                new { Id = 1, Name = "United States"},
                new { Id = 2, Name = "Canada"},
                new { Id = 3, Name = "Mexico"},
                new { Id = 4, Name = "Brazil"},
                new { Id = 5, Name = "India"},
                new { Id = 6, Name = "China"},
                new { Id = 7, Name = "Japan"},
                new { Id = 8, Name = "Germany"},
                new { Id = 9, Name = "France"},
                new { Id = 10, Name = "South Africa"},
                new { Id = 11, Name = "Nigeria"},
                new { Id = 12, Name = "Australia"},
                new { Id = 13, Name = "Russia"},
                new { Id = 14, Name = "Ghana"},
        };

            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
