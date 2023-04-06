using Rebuilding_api.Models;

namespace Rebuilding_api.Business {
    public interface IBillingsBusinessInterface {

        List<Billing> GetAll();
        Billing PostBilling(Billing billing);
        Billing GetBillingById(int id);
    }
}
