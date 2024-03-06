using System.Security.Policy;

namespace ATMSoftware.Models
{
    public class CreditCard
    {
        
        private readonly Hash _id_hash;
        private readonly string _card_no;
        private readonly int _cvv;
        private int _pin { get; set; }
        private string _name {  get; set; }
        private int _balance { get; set; }

        public CreditCard() { }

        public CreditCard(string cn, int cvv, int pin, string name, int bal)
        {
            _card_no = cn;
            _cvv = cvv;
            _pin = pin;
            _name = name;
            _balance = bal;
        }

        public 
    }
}
