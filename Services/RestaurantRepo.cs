using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETSUEats.Model;
using Microsoft.EntityFrameworkCore;

namespace ETSUEats.Services
{
    public class RestaurantRepo : IRestaurants
    {
        private readonly hcirestaurantsContext _db;
        public RestaurantRepo(hcirestaurantsContext db)
        {
            _db = db;
        }
        public Restaurants Create(Restaurants book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Restaurants Read(int id)
        {
            return _db.Restaurants.Include(r => r.Covid19).FirstOrDefault(p => p.Id == id);
        }

        public ICollection<Restaurants> ReadAll()
        {
            return _db.Restaurants.Include(r => r.Covid19).ToList();
        }

        public void Update(int oldId, Restaurants restaurant)
        {
            throw new NotImplementedException();
        }

        public ICollection<Restaurants> ReadMatchingNameSubstr(string nameSubstr)
        {
            return _db.Restaurants.Include(r => r.Covid19).Where(r => r.Name.ToLower().Contains(nameSubstr.ToLower())).ToList();
        }
    }
}
