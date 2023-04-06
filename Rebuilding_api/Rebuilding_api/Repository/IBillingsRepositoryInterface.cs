using Rebuilding_api.Models;

namespace Rebuilding_api.Repository {
    public interface IBillingsRepositoryInterface {
        List<Billing> GetAll();
        Billing PostBilling(Billing billing);
        Billing GetBillingById(int id);

    }
}
