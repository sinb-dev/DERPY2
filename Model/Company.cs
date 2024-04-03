using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERPY.Model
{
    public class Company
    {
        /*Firmanavn
• Vej
• Husnummer
• Postnummer
• By
• Land
• Valuta
        */
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
    }
}

