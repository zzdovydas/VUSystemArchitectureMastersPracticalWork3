using CSMasterSystemArchitecture1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMasterSystemArchitecture1.Tests.Helpers
{
    public class FakeItemList
    {
        public virtual List<Item> Get()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item() { CountryOfOrigin = "Poland", Name = "Milk", Guid = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "An ingredient or a drink", Price = 1.78M });
            list.Add(new Item() { CountryOfOrigin = "Lithuania", Name = "Sourcream", Guid = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "An ingredien", Price = 2.98M });
            list.Add(new Item() { CountryOfOrigin = "Germany", Name = "Milk", Guid = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "An ingredient or a drink", Price = 1.78M });
            list.Add(new Item() { CountryOfOrigin = "USA", Name = "Milk", Guid = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "An ingredient or a drink", Price = 1.78M });
            list.Add(new Item() { CountryOfOrigin = "UK", Name = "Milk", Guid = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "An ingredient or a drink", Price = 1.78M });
            list.Add(new Item() { CountryOfOrigin = "Poland", Name = "Milk", Guid = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "An ingredient or a drink", Price = 1.78M });
            return list;
        }
    }
}
