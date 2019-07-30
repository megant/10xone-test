using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using TenXOne.Models;
using TenXOne.Models.Repositories;

namespace TenXOne.Services
{
    public class FinancialItemsService : IFinancialItemsService
    {
        private readonly IPartnersRepository _partnersRepository;
        private readonly IFinancialItemsRepository _financialItemsRepository;

        public FinancialItemsService(IPartnersRepository partnersRepository, IFinancialItemsRepository financialItemsRepository)
        {
            _financialItemsRepository = financialItemsRepository;
            _partnersRepository = partnersRepository;
        }

        public IList<Partner> GetAllPartners()
        {
            return _partnersRepository.GetPartnerList();
        }

        public IList<FinancialItem> GetAllItems()
        {
            return _financialItemsRepository.GetFinancialItems();
        }

        public void AddItem(decimal partnerID, DateTime date, decimal amount) {
            var partner = GetAllPartners().FirstOrDefault(x => x.PartnerID == partnerID);
            _financialItemsRepository.AddFinancialItem(new FinancialItem {
                FinancialItemID = Guid.NewGuid(),
                Partner = partner,
                PartnerID = partnerID,
                Date = date,
                Amount = amount
            });
        }

        public void UpdateItem(Guid itemID, decimal partnerID, DateTime date, decimal amount) {
            var partner = GetAllPartners().FirstOrDefault(x => x.PartnerID == partnerID);
            _financialItemsRepository.UpdateFinancialItem(new FinancialItem {
                FinancialItemID = itemID,
                Partner = partner,
                PartnerID = partnerID,
                Date = date,
                Amount = amount
            });
        }

        public void DeleteItem(Guid itemID) {
            _financialItemsRepository.DeleteFinancialItem(itemID);
        }
    }
}