using System.Collections.Generic;

namespace TenXOne.Models.Repositories
{
    public interface IPartnersRepository
    {
        IList<Partner> GetPartnerList();
        IDictionary<decimal, PartnerNode> GetPartnerNodeList();
    }
}