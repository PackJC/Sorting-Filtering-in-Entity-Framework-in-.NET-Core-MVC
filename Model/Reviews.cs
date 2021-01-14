using System;
using System.Collections.Generic;

namespace ETSUEats.Model
{
    public partial class Reviews
    {
        public long Id { get; set; }
        public long? RestaurantId { get; set; }
        public long? Rating { get; set; }
        public string RatingText { get; set; }
        public string ReviewText { get; set; }
        public string ReviewTimeFriendly { get; set; }
        public string CustomerName { get; set; }

        public virtual Restaurants Restaurant { get; set; }
    }
}
