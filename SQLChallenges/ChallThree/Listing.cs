using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.ChallThree
{
    public class Listing
    {
        public int ListingID { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }
        public House HouseID { get; set; }

    }
}
