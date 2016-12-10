using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BellHouse.Models
{
    public class ReservationModel
    {
        public IList<string> ExtraOptions
        {
            get
            {
                return new List<string>()
                {
                    "Attending Theater After Dinner",
                    "Birthday",
                    "Anniversary",
                    "Special Event"
                };
            }
        }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int NumberInParty { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }
    }
}