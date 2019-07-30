using System;
using System.Collections.Generic;
namespace TenXOne.Models.Repositories
{
    public interface IFinancialItemsRepository
    {
        void CreateFinancialItemsData();
        IList<FinancialItem> GetFinancialItems();
        void AddFinancialItem(FinancialItem newItem);
        void UpdateFinancialItem(FinancialItem updatedItem);
        void DeleteFinancialItem(Guid itemId);
    }
}