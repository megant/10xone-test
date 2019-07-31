using System.Linq;
using System.Collections.Generic;
using TenXOne.Models;
using TenXOne.Models.Repositories;

namespace TenXOne.Services
{
    
    class StatisticsService : IStatisticsService
    {
        private readonly IPartnersRepository _partnersRepository;
        private readonly IFinancialItemsRepository _financialItemsRepository;
        private IDictionary<decimal, PartnerNode> PartnerNodeList;
        public StatisticsService(IFinancialItemsRepository financialItemsRepository, IPartnersRepository partnersRepository)
        {
            _financialItemsRepository = financialItemsRepository;
            _partnersRepository = partnersRepository;
            PartnerNodeList = _partnersRepository.GetPartnerNodeList();
        }

        private StatisticItem CalculateDescendantData(PartnerNode partnerNode) {
            var statisticItem = new StatisticItem {
                PartnerName = partnerNode.PartnerName
            };
            var financialItemsOfPartner = _financialItemsRepository.GetFinancialItems(partnerNode.PartnerID);
            var partnerPurchase = financialItemsOfPartner.Sum(x => x.Amount);
            decimal descendantPurchase = 0;

            foreach (var descendantPartnerNodeID in partnerNode.Descendants) {
                var descendantPartnerFeePercent = PartnerNodeList[descendantPartnerNodeID].FeePercent;
                var financialItemsOfDescendant = _financialItemsRepository.GetFinancialItems(descendantPartnerNodeID);
                descendantPurchase = financialItemsOfDescendant.Sum(x => x.Amount);
                statisticItem.TeamPurchase += descendantPurchase;
            }

            statisticItem.TotalPurchase = statisticItem.TeamPurchase + partnerPurchase;
            statisticItem.TotalComission = statisticItem.TotalPurchase * partnerNode.FeePercent / 100;

            return statisticItem;
        }

        private StatisticItem CalculateStatisticItemData(PartnerNode partnerNode) {
            var statisticItem = CalculateDescendantData(partnerNode);

            foreach (var childrenPartnerNodeID in partnerNode.Children) {
                var childPartnerNode = PartnerNodeList[childrenPartnerNodeID];
                if (childPartnerNode.FeePercent < partnerNode.FeePercent) {
                    var childData = CalculateDescendantData(childPartnerNode);
                    statisticItem.TotalComission += childData.TotalPurchase * (partnerNode.FeePercent - childPartnerNode.FeePercent) / 100; 
                }
            }

            return statisticItem;
        }
        public IList<StatisticItem> GetAllStatisticItems()
        {
            var statisticItems = new List<StatisticItem>();
            foreach (var partnerNode in PartnerNodeList.Values) {
                var statisticItem = CalculateStatisticItemData(partnerNode); 
                statisticItems.Add(statisticItem);
            }

            return statisticItems;
        }
    }
}