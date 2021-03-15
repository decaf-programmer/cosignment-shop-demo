using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public double PaymentDue { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - ${2}", FirstName, LastName, PaymentDue);
            }
        }

        public Vendor()
        {
            Commission = .5;
        }
    }
}
