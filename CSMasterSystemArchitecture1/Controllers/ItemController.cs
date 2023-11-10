using CSMasterSystemArchitecture1.Models;
using CSMasterSystemArchitecture1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace CSMasterSystemArchitecture1.Controllers
{

    public class ItemController : Controller
    {
        private readonly ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            List<Item> items = _itemService.Get(null);
            ViewData["items"] = items;

            return View();
        }

        [HttpGet("/Item/Get/{guid?}")]
        public IActionResult Get(string? guid)
        {
            List<Item> items = _itemService.Get(guid);

            return Ok(items);
        }

        [HttpGet("/Item/Add")]
        public IActionResult ViewAdd()
        {
            return View("Add");
        }

        [HttpPost("/Item/Add")]
        public IActionResult Add([FromBody]Item i)
        {
            _itemService.Add(i);

            return Ok();
        }

        [HttpGet("/Item/Remove/{guid}")]
        public IActionResult Remove(string guid)
        {
            try
            {
                _itemService.Delete(guid);
            }
            catch
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet("/Item/Edit/{guid}")]
        public IActionResult ViewEdit(string guid)
        {
            Item? item = _itemService.Get(guid).FirstOrDefault();

            if (item == null)
            {
                return NotFound();
            }

            return View("Add", item);
        }

        [HttpPost("/Item/Edit")]
        public IActionResult Edit([FromBody]Item i)
        {
            _itemService.Update(i);

            return Ok();
        }

    }
}