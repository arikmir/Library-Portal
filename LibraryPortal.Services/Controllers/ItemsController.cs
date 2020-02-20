using LibraryPortal.Services.DAL;
using LibraryPortal.Services.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LibraryPortal.Services.Controllers
{
    [RoutePrefix("api")]
    public class ItemsController : ApiController
    {
        private Entities entities = new Entities();

        //GET: /api/items
        [Route("items")]
        public IEnumerable<Item> GetItems()
        {
            return entities.Items.ToList();
        }
        //GET: /api/items/id
        public IHttpActionResult GetItem(int id)
        {
            try
            {
                var item = entities.Items.SingleOrDefault(c => c.ItemId == id);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
        //POST: /api/items
        [HttpPost]
        public IHttpActionResult Create(Item item)
        {
            try
            {
                Item createdItem = new Item()
                {
                    ItemName = item.ItemName,
                    Author = item.Author,
                    ItemType = item.ItemType
                };
                entities.Items.Add(createdItem);
                entities.SaveChanges();
                return Ok();
                //return CreatedAtRoute("GetItem", new { id = createdItem.ItemId }, createdItem);
            }
            catch (Exception ex)
            {
                //LOG
                return InternalServerError();
            }
        }
        //PUT: /api/items/id
        [HttpPut]
        public IHttpActionResult Update(int id, Item item)
        {
            try
            {
                var existingItem = entities.Items.SingleOrDefault(x => x.ItemId == id);

                existingItem.ItemName = item.ItemName;
                existingItem.Author = item.Author;
                existingItem.ItemType = item.ItemType;

                entities.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
        //DELETE: /api/items/id
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        { 
            try
            {
                var item = entities.Items.SingleOrDefault(c => c.ItemId == id);
                if (item == null)
                {
                    return NotFound();
                }
                entities.Items.Remove(item);
                entities.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}