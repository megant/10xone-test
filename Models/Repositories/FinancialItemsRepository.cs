using System.Linq;
using System.Collections.Generic;
using System;

namespace TenXOne.Models.Repositories
{
    public class FinancialItemsRepository : IFinancialItemsRepository
    {
        private IList<FinancialItem> FinancialItems;

        public void CreateFinancialItemsData() {
            var partnersRepository = new PartnersRepository();
            var partners = partnersRepository.GetPartnerList();
            FinancialItems.Add(new FinancialItem {
                FinancialItemID = Guid.NewGuid(),
                Partner = partners.First(x => x.PartnerID == 1),
                Date = new DateTime(2010, 1, 1),
                Amount = 5
            });
        }
        public IList<FinancialItem> GetFinancialItems()
        {    
            if (FinancialItems == null) {
                FinancialItems = new List<FinancialItem>();
                CreateFinancialItemsData();
            }
            return FinancialItems;
        }

        public void AddFinancialItem(FinancialItem newItem) {
            FinancialItems.Add(newItem);
        }

        public void UpdateFinancialItem(FinancialItem updatedItem) {
            var oldItem = FinancialItems.First(x => x.FinancialItemID == updatedItem.FinancialItemID);
            var itemIndex = FinancialItems.IndexOf(oldItem);

            if (itemIndex > -1) {
                FinancialItems[itemIndex] = updatedItem;
            }
        }

        public void DeleteFinancialItem(Guid itemID)
        {
            FinancialItems.Remove(FinancialItems.FirstOrDefault(x => x.FinancialItemID == itemID));
        }
    }
}