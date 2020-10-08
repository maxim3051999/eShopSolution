using System.Collections.Generic;

namespace eShopSolution.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> items { get; set; }
    }
}