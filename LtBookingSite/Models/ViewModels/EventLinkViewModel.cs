using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LtBookingSite.Models.ViewModels
{
    public class EventLinkViewModel
    {
        public string EventName { get; set; }

        public string EventLink { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string DisplayDate
        {
            get
            {
                var displayDate = StartDate.Value.ToString("dd/MM/yy HH:mm");

                if (EndDate.HasValue)
                {
                    displayDate += " - " + EndDate.Value.ToString("dd/MM/yy HH:mm");
                }

                return displayDate;
            }
        }
    }
}
