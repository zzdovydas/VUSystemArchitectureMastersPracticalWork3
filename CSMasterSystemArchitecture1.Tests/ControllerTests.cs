using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using CSMasterSystemArchitecture1.Controllers;
using CSMasterSystemArchitecture1.Models;
using CSMasterSystemArchitecture1.Tests.Helpers;

namespace CSMasterSystemArchitecture1.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void TestAdd()
        {
            ItemController controller = ControllerHelpers.InitializeController();

            Item i = new FakeItemList().Get()[0];

            var response = ((RedirectToActionResult)controller.Add(i));

            if (response.ActionName != "Index")
            {
                Assert.True(false);
                return;
            }

            Assert.True(true);
        }
        [Fact]
        public void TestEdit()
        {
            ItemController controller = ControllerHelpers.InitializeController();

            string guid = Guid.NewGuid().ToString();

            // ADD ITEM ------------------
            Item i = new FakeItemList().Get()[0];
            i.Guid = guid;
            controller.Add(i);

            // Change to name another product
            i.Name = "Eggs";

            // UPDATE ---------------------
            var response = ((RedirectToActionResult)controller.Edit(i));

            if (response.ActionName != "Index")
            {
                Assert.True(false);
                return;
            }

            Assert.True(true);
        }
        [Fact]
        public void TestDelete()
        {
            ItemController controller = ControllerHelpers.InitializeController();

            string guid = Guid.NewGuid().ToString();

            Item i = new FakeItemList().Get()[0];
            i.Guid = guid;
            controller.Add(i);

            var response = (RedirectToActionResult)controller.Remove(guid);

            if (response.ActionName != "Index")
            {
                Assert.True(false);
            }

            Assert.True(true);
        }

        [Fact]
        public void TestGet()
        {
            ItemController controller = ControllerHelpers.InitializeController();
            Item i = new FakeItemList().Get()[0];

            controller.Add(i);

            var response = controller.Index();

            Assert.True(true);
        }
    }
}