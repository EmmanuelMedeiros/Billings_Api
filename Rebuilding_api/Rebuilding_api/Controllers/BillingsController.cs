using Microsoft.AspNetCore.Mvc;
using Rebuilding_api.Repository;
using Rebuilding_api.Models;
using Rebuilding_api.Business;

namespace Rebuilding_api.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class BillingsController : ControllerBase {

        public readonly ILogger<BillingsController> _logger;
        private IBillingsBusinessInterface _billingsBusiness;
        public BillingsController(ILogger<BillingsController> logger, IBillingsBusinessInterface billingsBusiness) {
            _logger = logger;
            _billingsBusiness = billingsBusiness;
        }

        [HttpGet]
        public IActionResult GetAllBillings() {
            if (_billingsBusiness.GetAll() != null) {
                return Ok(_billingsBusiness.GetAll());
            } else {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult PostBilling(double money_earned) {
            if (money_earned < 0) {
                return BadRequest();
            }

            Billing billing_to_add = new Billing(money_earned);
            billing_to_add.Today();

            return Ok(_billingsBusiness.PostBilling(billing_to_add));

        }

        [HttpGet("{id}")]
        public IActionResult GetBillingById(int id) {

            Billing my_billing = _billingsBusiness.GetBillingById(id);
            if (my_billing != null) {

                return Ok(my_billing);
            } else {

                return NotFound();
            }
        }

    }
}
