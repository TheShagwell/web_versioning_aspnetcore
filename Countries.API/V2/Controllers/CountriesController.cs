using Asp.Versioning;
using Countries.API.Data;
using Countries.API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Countries.API.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/countries")]

    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var countriesDomainModel = CountriesData.Get();

            // Map Domain Model to DTO
            var response = new List<CountryDTOV2>();
            foreach (var countryDomain in countriesDomainModel)
            {
                response.Add(new CountryDTOV2
                {
                    Id = countryDomain.Id,
                    CountryName = countryDomain.Name,
                });
            }

            return Ok(response);
        }
    }
}
