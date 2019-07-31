using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections;

namespace TenXOne.Models.Repositories
{
    public class PartnersRepository : IPartnersRepository
    {
        private IDictionary<decimal, PartnerNode> PartnerNodeList;
        private IList<Partner> PartnerList;
        private IList<decimal> AvailableParents;
        public PartnersRepository() {
            AvailableParents = new List<decimal>();
            PartnerNodeList = new Dictionary<decimal, PartnerNode>();
            PartnerList = new List<Partner>();
            CreatePartners();
        }

        private decimal GetFeePercent() {
            var random = new Random();
            decimal randomNumber = random.Next(1, 20);
            return randomNumber;
        }

        private void AddPartnerNode(Partner partner) {
            var randomGenerator = new Random();
            decimal? parentPartnerID = null;

            if (AvailableParents.Count > 0) {
                var randomIndex = randomGenerator.Next(AvailableParents.Count);
                parentPartnerID = AvailableParents[randomIndex];
            } 

            AvailableParents.Add(partner.PartnerID);
            PartnerNodeList.Add(partner.PartnerID, new PartnerNode {
                PartnerID = partner.PartnerID,
                ParentPartnerID = parentPartnerID,
                PartnerName = partner.Name,
                FeePercent = GetFeePercent(),
                Children = new List<decimal>(),
                Descendants = new List<decimal>()
            });
        }

        private void CreatePartnerNode(string name) {
            var partnerID = PartnerNodeList.Count() + 1;
            var partner = new Partner {
                PartnerID = partnerID,
                Name = name
            };
            PartnerList.Add(partner);
            AddPartnerNode(partner);
        }

        private void CollectPartnerNodeChildren() {
            foreach(KeyValuePair<decimal, PartnerNode> partnerNode in PartnerNodeList)
            {
                if (partnerNode.Value.ParentPartnerID != null) {
                    PartnerNodeList[(decimal)partnerNode.Value.ParentPartnerID].Children.Add(partnerNode.Value.PartnerID);
                }
            }
        }

        private void CollectPartnerNodeDescendants(IList<decimal> ancestorPartnerIDs, PartnerNode partnerNode) {
            if (partnerNode.Children.Count > 0) {
                var newAncestorPartnerIDs = ancestorPartnerIDs.ToList();
                newAncestorPartnerIDs.Add(partnerNode.PartnerID);
                foreach (var ancestorPartnerID in newAncestorPartnerIDs) {
                    foreach (var childPartnerID in partnerNode.Children) {
                        if (!PartnerNodeList[ancestorPartnerID].Descendants.Contains(childPartnerID)) {
                            PartnerNodeList[ancestorPartnerID].Descendants.Add(childPartnerID);
                        }
                        CollectPartnerNodeDescendants(newAncestorPartnerIDs, PartnerNodeList[childPartnerID]);
                    }
                }
            }
        }

        private void BuildChildBranches() {
            CollectPartnerNodeChildren();
            var topParent = PartnerNodeList.Values.First(x => x.ParentPartnerID == null);
            CollectPartnerNodeDescendants(new List<decimal>(), topParent);
        }
        private void CreatePartners() {
            string[] names = {
                "John McDonalds",
                "Matt Damon",
                "Fred Aster",
                "Martin Luther King",
                "Kate Middleton",
                "Sandy Kovacs",
                "Gyula Bodrogi"
            };

            Random rnd = new Random();
            var orderedNames = names.OrderBy(x => rnd.Next()).ToArray();

            Array.ForEach(orderedNames, name => CreatePartnerNode(name));
            BuildChildBranches();
        }

        public IList<Partner> GetPartnerList() {
            return PartnerList;
        }

        public IDictionary<decimal, PartnerNode> GetPartnerNodeList() {
            return PartnerNodeList;
        }
    }
}