using System;
using System.Collections.Generic;

namespace ETSUEats.Model
{
    public partial class Cuisines
    {
        public Cuisines()
        {
            Restaurants = new HashSet<Restaurants>();
        }

        public long Id { get; set; }
        public string CuisineName { get; set; }

        public virtual ICollection<Restaurants> Restaurants { get; set; }
    }
}
