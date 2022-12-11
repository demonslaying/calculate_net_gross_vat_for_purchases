using Microsoft.AspNetCore.Mvc;

namespace calculate_net_gross_vat_for_purchasesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VATRateController : ControllerBase
    {
        private readonly IVATRateService _clientService;

        public VATRateController(IVATRateService clientService)
        {
            this._clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<VATRate>>> GetAllVATRates()
        {
            return await _clientService.GetAllVATRates();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<VATRate>>> GetVATRate(int id)
        {
            var result = await _clientService.GetVATRatesByCountryId(id);
            if (result is null) return NotFound("There are no VAT rates for that country");

            return Ok(result);
        }
    }
}
