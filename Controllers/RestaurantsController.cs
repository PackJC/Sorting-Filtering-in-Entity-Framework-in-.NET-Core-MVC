using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ETSUEats.Models;
using ETSUEats.Services;
using ETSUEats.Model;

namespace ETSUEats.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurants _restaurants;

        public RestaurantsController(IRestaurants restaurants)
        {
            _restaurants = restaurants;
        }

        public IActionResult Index(bool takeout, bool limitedSeating, bool indoorDining, bool curbside, bool sortDescending, string searchTerm)
        {
            var model = new List<Restaurants>();        // build up new list for filter

            // if any one of the services (e.g. HasTakeout) is true, then we'll filter by all that are true.
            // If none are true, we'll not filter by services.             
            ICollection<Restaurants> restaurants;
            if (searchTerm == null)
            {
                restaurants = _restaurants.ReadAll();
            }
            else
            {
                restaurants = _restaurants.ReadMatchingNameSubstr(searchTerm);
            }
            // TODO: move filters to repo for better performance on large sets?
            if (takeout || limitedSeating || indoorDining || curbside)
            {
                foreach (var r in restaurants)
                {
                    var covidPolicy = r.Covid19.FirstOrDefault();
                    if (covidPolicy != null)
                    {
                        if ((takeout && covidPolicy.TakeOut)
                            || (limitedSeating && covidPolicy.LimitSeating)
                            || (indoorDining && covidPolicy.IndoorDining)
                            || (curbside && covidPolicy.Curbside))
                        {
                            model.Add(r);
                        }
                    }
                }
            }
            else
            {
                // no filter by services
                model.AddRange(restaurants);
            }

            // apply sort order by name (default to ascending)
            if (!sortDescending)
            {
                model = model.OrderBy(r => r.Name).ToList();
            }
            else
            {
                model = model.OrderByDescending(r => r.Name).ToList();
            }

            // pass default checkbox states by string (so filter checks persist)
            ViewData["takeout"] = takeout ? "checked" : "";
            ViewData["limitedseating"] = limitedSeating ? "checked" : "";
            ViewData["indoordining"] = indoorDining ? "checked" : "";
            ViewData["curbside"] = curbside ? "checked" : "";
            ViewData["sortdescending"] = sortDescending ? "checked" : "";
            ViewData["searchterm"] = searchTerm;
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurants.Read(id);
            return View(model);
        }
    }
}
