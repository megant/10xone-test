using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections;

namespace TenXOne.Models.Repositories
{
    public class PartnersRepository : IPartnersRepository
    {
        private IList<PartnerNode> PartnerTree;
        private IList<decimal> Parents;

        public PartnersRepository() {
            Parents = new List<decimal>();
            PartnerTree = new List<PartnerNode>();
            CreatePartnerTree();
        }

        private string GetParent() {
            return "";
        }

        private decimal GetFeePercent() {
            var random = new Random();
            decimal randomNumber = random.Next(1, 20);
            return randomNumber;
        }

        private void AddPartnerNode(Partner partner) {
            Parents.Add(partner.PartnerID);
            PartnerTree.Add(new PartnerNode {
                Partner = partner
            });
        }

        private void CreatePartnerNode(string name) {
            var partnerID = PartnerTree.Count() + 1;
            var randomGenerator = new Random();
            decimal? parentPartnerID = null;
            if (Parents.Count > 0) {
                var randomIndex = randomGenerator.Next(Parents.Count);
                parentPartnerID = Parents[randomIndex];
            } 
            
            AddPartnerNode(new Partner {
                PartnerID = partnerID,
                Name = name,
                FeePercent = GetFeePercent(),
                ParentPartnerID = parentPartnerID
            });
        }

        public void CreatePartnerTree() {
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
        }
        public IList<PartnerNode> GetPartnerTree() {    
            if (PartnerTree.Count() == 0) {
                CreatePartnerTree();
            }
            return PartnerTree;
        }

        public IList<Partner> GetPartnerList() {
            return PartnerTree.Select(x => new Partner {
                PartnerID = x.Partner.PartnerID,
                Name = x.Partner.Name
            }).ToList();
        }
    }
}