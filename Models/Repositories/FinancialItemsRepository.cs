using System.Linq;
using System.Collections.Generic;
using System;

namespace TenXOne.Models.Repositories
{
    public class FinancialItemsRepository : IFinancialItemsRepository
    {
        private IList<FinancialItem> FinancialItems;

        public FinancialItemsRepository() {
            FinancialItems = new List<FinancialItem>();
            CreateFinancialItemsData();
        }
        private void CreateFinancialItemsData() {
            var partnersRepository = new PartnersRepository();
            var partners = partnersRepository.GetPartnerList();
            FinancialItems.Add(new FinancialItem {
                FinancialItemID = Guid.NewGuid(),
                Partner = partners.First(x => x.PartnerID == 1),
                Date = new DateTime(2010, 1, 1),
                Amount = 5
            });
        }
        public IList<FinancialItem> GetAllFinancialItems()
        {    
            return FinancialItems;
        }

        public IList<FinancialItem> GetFinancialItems(decimal partnerID) {
            return FinancialItems.Where(x => x.PartnerID == partnerID).ToList();
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