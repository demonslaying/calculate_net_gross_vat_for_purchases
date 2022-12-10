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
    }
}
