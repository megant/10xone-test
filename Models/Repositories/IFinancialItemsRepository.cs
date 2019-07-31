using System;
using System.Collections.Generic;
namespace TenXOne.Models.Repositories
{
    public interface IFinancialItemsRepository
    {
        IList<FinancialItem> GetFinancialItems(decimal partnerID);
        IList<FinancialItem> GetAllFinancialItems();
        void AddFinancialItem(FinancialItem newItem);
        void UpdateFinancialItem(FinancialItem updatedItem);
        void DeleteFinancialItem(Guid itemId);
    }
}