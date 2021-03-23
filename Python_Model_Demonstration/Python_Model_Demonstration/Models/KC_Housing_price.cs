using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Python_Model_Demonstration.Models
{
    public class KC_Housing_price
    {
        public int bedrooms { get; set; }
        public double bathrooms { get; set; }
        public int sqft_living { get; set; }
        public int sqft_lot { get; set; }
        public double floors { get; set; }
        public int waterfront { get; set; }
        public int view { get; set; }
        public int condition { get; set; }
        public int grade { get; set; }
        public int sqft_above { get; set; }
        public int sqft_basement { get; set; }
        public int year_built { get; set; }
        public int yr_renovated { get; set; }
        public int zip_code { get; set; }
        public double lat { get; set; }
        public double longi {get;set;}
        public int sqft_living15 { get; set; }
        public int sqft_lot15 { get; set; }

        public override string ToString()
        {
            return $"{bedrooms}+{bathrooms}+{sqft_living}+{sqft_lot}+{floors}+{waterfront}+{view}+{condition}" +
                $"+{grade}+{sqft_above}+{sqft_basement}+{year_built}+{yr_renovated}+{zip_code}+" +
                $"{lat}+{longi}+{sqft_living15}+{sqft_lot15}";
        }
    }
}
