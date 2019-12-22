using LtBookingSite.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LtBookingSite.Data
{
    public interface IEventHelper
    {
        IEnumerable<EventLinkViewModel> GetEventLinks();
    }
}
