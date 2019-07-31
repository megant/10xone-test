using System;
namespace TenXOne.Models
{
    public class Partner
    {
        public Partner() {}

        public Partner(decimal PartnerID, string Name)
        {
            this.PartnerID = PartnerID;
            this.Name = Name;
        }
        public decimal PartnerID { get; set; }
        public string Name { get; set; }
    }
}