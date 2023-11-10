using CSMasterSystemArchitecture1.Context;
using CSMasterSystemArchitecture1.Models;
using CSMasterSystemArchitecture1.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSMasterSystemArchitecture1.Repositories
{
    public class ItemRepository
    {

        private readonly ItemDbContext _dbContext;
        public ItemRepository(ItemDbContext context)
        {
            _dbContext = context;
        }

        public List<Item> Get(string? guid)
        {
            List<Item> items = new();

            if (guid == null)
            {
                items = _dbContext.Items.ToList();
            }
            else
            {
                items = _dbContext.Items.Where(x => x.Guid == guid).ToList();
            }

            return items;
        }

        public string? Add(Item i)
        {
            i.CreatedAt = DateTime.Now;
            i.Guid ??= Guid.NewGuid().ToString();

            _dbContext.Items.Add(i);
            _dbContext.SaveChanges();

            return i.Guid;
        }

        public void Update(Item i)
        {
            _dbContext.Update(i);
            _dbContext.SaveChanges();
        }

        public void Remove(string guid)
        {
            Item? i = _dbContext.Items.Where(x => x.Guid == guid).FirstOrDefault();

            if (i == null)
            {
                throw new Exception("Not found!");
            }

            _dbContext.Items.Remove(i);

            _dbContext.SaveChanges();
        }
    }
}
