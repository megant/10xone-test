using System.Collections.Generic;
using TenXOne.Models;

namespace TenXOne.Services {
    public interface IStatisticsService {
        IList<StatisticItem> GetAllStatisticItems();
    }
}