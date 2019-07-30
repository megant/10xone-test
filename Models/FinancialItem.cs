using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TenXOne.Models
{
    public class FinancialItem
    {
        public FinancialItem() {}

        public FinancialItem(Guid FinancialItemID, int PartnerID, DateTime Date, decimal Amount)
        {
            this.FinancialItemID = FinancialItemID;
            this.PartnerID = PartnerID;
            this.Date = Date;
            this.Amount = Amount;
        }

        public Guid FinancialItemID { get; set; }
        [Key]
        [ForeignKey("Partner")]
        public decimal PartnerID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public virtual Partner Partner { get; set; }
    }
}