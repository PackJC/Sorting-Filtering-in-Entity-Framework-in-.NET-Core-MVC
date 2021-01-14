using ETSUEats.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETSUEats.Services
{
    public interface IRestaurants
    {
        Model.Restaurants Read(int id);
        public Model.Restaurants Create(Model.Restaurants book);
        ICollection<Model.Restaurants> ReadAll();
        void Update(int oldId, Model.Restaurants book);
        void Delete(int Id);
        public ICollection<Restaurants> ReadMatchingNameSubstr(string nameSubstr);
    }
}
