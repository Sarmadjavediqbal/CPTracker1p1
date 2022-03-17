using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPTracker1p1.Models
{
    public class Parcel
    {
        public int pId { get; set; }
        public string parType { get; set; }
        public string parCategory { get; set; }
        public string ItemType { get; set; }
        public DateTime GetDateTime { get; set; }
        public string Barcode { get; set; }
    }
}
