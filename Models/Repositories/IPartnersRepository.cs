using System.Collections.Generic;
namespace TenXOne.Models.Repositories
{
    public interface IPartnersRepository
    {
        void CreatePartnerTree();
        IList<PartnerNode> GetPartnerTree();
        IList<Partner> GetPartnerList();
    }
}