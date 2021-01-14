using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ETSUEats.Model
{
    public partial class Restaurants
    {
        public Restaurants()
        {
            Covid19 = new HashSet<Covid19>();
            Reviews = new HashSet<Reviews>();
        }

        public long Id { get; set; }
        public long CityId { get; set; }
        public long CuisineId { get; set; }
        public string Cuisines { get; set; }
        public string Currency { get; set; }
        public string Establishment { get; set; }
        public long? HasDelivery { get; set; }
        public long? HasTakeaway { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string Locality { get; set; }
        public string LocalityVerbose { get; set; }
        [Display(Name = "ZIP")]
        public string ZipCode { get; set; }
        public string MenuUrl { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public long? PriceRange { get; set; }
        public string Timings { get; set; }
        public string Url { get; set; }

        [Display(Name="Rating")]
        public string AggregateRating { get; set; }
        public string RatingText { get; set; }

        public virtual Cities CityNavigation { get; set; }
        public virtual Cuisines Cuisine { get; set; }
        public virtual ICollection<Covid19> Covid19 { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
