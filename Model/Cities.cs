using System;
using System.Collections.Generic;

namespace ETSUEats.Model
{
    public partial class Cities
    {
        public Cities()
        {
            Restaurants = new HashSet<Restaurants>();
        }

        public long Id { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string FullName { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<Restaurants> Restaurants { get; set; }
    }
}
