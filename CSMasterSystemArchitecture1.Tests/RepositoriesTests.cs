using CSMasterSystemArchitecture1.Context;
using CSMasterSystemArchitecture1.Models;
using CSMasterSystemArchitecture1.Repositories;
using CSMasterSystemArchitecture1.Services;
using CSMasterSystemArchitecture1.Tests.Helpers;

namespace CSMasterSystemArchitecture1.Tests
{
    public class RepositoriesTests
    {
        string dbName => "repositoryTest";
        [Fact]
        public void TestAdd()
        {
            ItemDbContext c = ContextHelper.InitializeContext(dbName);
            ItemRepository iR = new(c);

            Item i = new FakeItemList().Get()[0];

            iR.Add(i);

            Item? addedItem = c.Items.ToList()[0];

            if (addedItem.Name != i.Name
             || addedItem.Description != i.Description
             || addedItem.Price != i.Price)
            {
                Assert.True(false);
                return;
            }


            Assert.True(true);
        }
        [Fact]
        public void TestEdit()
        {
            ItemDbContext c = ContextHelper.InitializeContext(dbName);
            ItemRepository iR = new(c);

            Item i = new FakeItemList().Get()[0];

            iR.Add(i);

            Item addedItem = c.Items.ToList()[0];
            addedItem.Name = "Updated";
            addedItem.Description = "Updated";
            addedItem.Price = 11;

            iR.Update(addedItem);

            if (addedItem.Name == "Updated" && addedItem.Description == "Updated" && addedItem.Price == 11)
            {
                Assert.True(true);
                return;
            }


            Assert.True(false);
        }
        [Fact]
        public void TestDelete()
        {
            ItemDbContext c = ContextHelper.InitializeContext(dbName);
            ItemRepository iR = new(c);

            Item i = new FakeItemList().Get()[0];

            iR.Add(i);

            Item addedItem = c.Items.ToList()[0];

            if (addedItem == null)
            {
                Assert.False(true);
                return;
            }

            iR.Remove(addedItem.Guid);

            if (c.Items.ToList().Count == 0)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);
        }
        [Fact]
        public void TestGet()
        {
            ItemDbContext c = ContextHelper.InitializeContext(dbName);
            ItemRepository iR = new(c);

            Item i = new FakeItemList().Get()[0];

            iR.Add(i);

            if (c.Items.ToList().Count > 0)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);
        }
    }
}