using Microsoft.AspNetCore.Mvc;

namespace calculate_net_gross_vat_for_purchasesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _clientService;

        public CountryController(ICountryService clientService)
        {
            this._clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Country>>> GetAllCountries()
        {
            return await _clientService.GetAllCountries();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Country>>> GetCountry(int id)
        {
            var result = await _clientService.GetCountry(id);
            if (result is null) return NotFound("Country not found");

            return Ok(result);
        }
    }
}
