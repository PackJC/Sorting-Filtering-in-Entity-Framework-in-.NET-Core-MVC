using System;
using System.Collections.Generic;

namespace ETSUEats.Model
{
    public partial class Covid19
    {
        public long Id { get; set; }
        public long? RestaurantId { get; set; }
        public bool TakeOut { get; set; }
        public bool LimitSeating { get; set; }
        public bool IndoorDining { get; set; }
        public bool Curbside { get; set; }
        public string Comments { get; set; }

        public virtual Restaurants Restaurant { get; set; }
    }
}
