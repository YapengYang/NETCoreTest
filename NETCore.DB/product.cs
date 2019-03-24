using System;

namespace NETCore.DB
{
    public class product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public int dir_id { get; set; }
        public double salePrice { get; set; }
        public string supplier { get; set; }
        public string brand { get; set; }
        public double cutoff { get; set; }
        public double costPrice { get; set; }

    }
}
