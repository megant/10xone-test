using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TenXOne.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace TenXOne.ViewModels {

    public class FinancialItemsViewModel {
        [Required]
        [RegularExpression("\\d", ErrorMessage = "Please select a partner!")]
        public decimal PartnerID { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public IList<Partner> Partners { get; set; }  
        public IEnumerable<SelectListItem> PartnerList { get {
            return Partners.Select(partner =>
                  new SelectListItem
                  {
                      Text = partner.Name,
                      Value = partner.PartnerID.ToString()
                  });
        }}
        public IList<FinancialItem> FinancialItems { get; set; }
    }
}