using System.Collections.Generic;

namespace TenXOne.Models
{
    public class PartnerNode
    {
        public PartnerNode() {}

        public PartnerNode(decimal PartnerID, decimal? ParentPartnerID, string PartnerName, decimal FeePercent, IList<decimal> ChildBranch)
        {
            this.PartnerID = PartnerID;
            this.ParentPartnerID = ParentPartnerID;
            this.PartnerName = PartnerName;
            this.Children = ChildBranch;
        }
        public decimal PartnerID { get; set; }
        public decimal? ParentPartnerID { get; set; }
        public string PartnerName { get; set; }
        public decimal FeePercent { get; set; }
        public IList<decimal> Children { get; set; }
        public IList<decimal> Descendants { get; set; }
    }
}