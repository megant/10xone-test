using System;
namespace TenXOne.Models
{
    public class Partner
    {
        public Partner() {}

        public Partner(decimal PartnerID, string Name, decimal FeePercent, decimal ParentPartnerID)
        {
            this.ParentPartnerID = PartnerID;
            this.Name = Name;
            this.FeePercent = FeePercent;
            this.ParentPartnerID = ParentPartnerID;
        }
        public decimal PartnerID { get; set; }
        public string Name { get; set; }
        public decimal FeePercent { get; set; }
        public decimal? ParentPartnerID { get; set; }
    }
}