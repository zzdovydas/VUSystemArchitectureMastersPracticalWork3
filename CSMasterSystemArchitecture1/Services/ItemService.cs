using CSMasterSystemArchitecture1.Models;
using CSMasterSystemArchitecture1.Repositories;

namespace CSMasterSystemArchitecture1.Services
{
    public class ItemService
    {

        private readonly ItemRepository _repository;
        public ItemService(ItemRepository itemRepository) 
        {
            _repository = itemRepository;
        }

        public List<Item> Get(string? guid)
        {
            List<Item> items = _repository.Get(guid);

            return items;
        }

        public string? Add(Item? i)
        {
            string? guid = _repository.Add(i);

            return guid;
        }

        public void Update(Item? i) 
        {
            _repository.Update(i);
        }

        public void Delete(string guid) 
        {
            _repository.Remove(guid);
        }
    }
}
