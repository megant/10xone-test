using System;
using System.Collections.Generic;
using TenXOne.Models;

namespace TenXOne.Services {
    public interface IFinancialItemsService {
        IList<Partner> GetAllPartners();
        IList<FinancialItem> GetAllItems();
        void AddItem (decimal partnerID, DateTime date, decimal amount);
        void UpdateItem (Guid itemID, decimal partnerID, DateTime date, decimal amount);
        void DeleteItem (Guid itemID);
        void DeleteAllItems();
    }
}