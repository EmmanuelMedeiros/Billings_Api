using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Http.HttpResults;
using Rebuilding_api.Context;
using Rebuilding_api.Models;

namespace Rebuilding_api.Repository.Implementation {
    public class BillingsRepositoryImplementation : IBillingsRepositoryInterface {

        private MySQLContext _context;

        public BillingsRepositoryImplementation(MySQLContext context) {
            _context = context;
        }

        public List<Billing> GetAll() {

            if (_context.Billings.ToList() == null) {
                return null;
            } else {
                return _context.Billings.ToList();
            }
        }

        public Billing PostBilling(Billing billing) {
            try {

                Billing billing_to_post = billing;
                _context.Add(billing_to_post);
                _context.SaveChanges();
                return billing_to_post;
            } catch(Exception ex) {

                throw;
            }
        }

        public Billing GetBillingById(int id) {

            if (_context.Billings.Any(b => b.Id == id)) {

                try {

                    var billing_gathered = _context.Billings.FirstOrDefault(b => b.Id == id);
                    return billing_gathered;

                } catch(Exception ex) {

                    throw;
                }
            } else {

                return null;
            }
        }

    }
}
