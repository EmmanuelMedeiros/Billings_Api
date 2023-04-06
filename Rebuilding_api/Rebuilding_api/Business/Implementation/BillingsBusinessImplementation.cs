using Rebuilding_api.Models;
using Rebuilding_api.Repository;

namespace Rebuilding_api.Business.Implementation {
    public class BillingsBusinessImplementation : IBillingsBusinessInterface {

        private readonly IBillingsRepositoryInterface _repository;

        public BillingsBusinessImplementation(IBillingsRepositoryInterface repository) {
            _repository = repository;
        }

        public List<Billing> GetAll() {
            return _repository.GetAll();
        }

        public Billing GetBillingById(int id) {
            return _repository.GetBillingById(id);
        }

        public Billing PostBilling(Billing billing) {
            return _repository.PostBilling(billing);
        }

    }
}
