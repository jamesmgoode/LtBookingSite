using LtBookingSite.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace LtBookingSite.Data
{
    public class EventHelper : IEventHelper
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EventHelper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<EventLinkViewModel> GetEventLinks()
        {
            var eventLinks = new List<EventLinkViewModel>();

            foreach (var eventDetails in _applicationDbContext.Events.ToList().OrderBy(e => e.StartDate).ThenBy(e => e.EventName))
            {
                eventLinks.Add(new EventLinkViewModel
                {
                    EventName = eventDetails.EventName,
                    EventLink = eventDetails.EventLink,
                    StartDate = eventDetails.StartDate,
                    EndDate = eventDetails.EndDate
                });
            }

            return eventLinks;
        }
    }
}
