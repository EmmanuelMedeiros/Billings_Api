using System.ComponentModel.DataAnnotations.Schema;

namespace Rebuilding_api.Models {
    public class Billing {

        [Column("id")]
        public long Id { get; set; }
        [Column("weekDay")]
        public string Weekday { get; set; }
        [Column("day")]
        public int Day { get; set; }
        [Column("month")]
        public string Month { get; set; }
        [Column("moneyEarned")]
        public double Money_earned { get; set; }

        public Billing(double money_earned) {
            Money_earned= money_earned;
        }

        public void Today() {

            DateTime today = DateTime.Now;

            Month = today.ToString("MMMM");
            Weekday = today.ToString("ddd");
            Day = (int)today.Day;
        }

    }
}
