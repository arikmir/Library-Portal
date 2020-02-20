using LibraryPortal.HttpHelpers;
using LibraryPortal.Models;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LibraryPortal.Controllers
{
    public class ItemsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("list")]
        public async Task<PartialViewResult> List()
        {
            var clientWrapper = new HttpClientWrapper<Item>();
            var items = await clientWrapper.GetItems();
            return PartialView("_table", items);
        }

        public async Task<ActionResult> StudentIndex()
        {
            var clientWrapper = new HttpClientWrapper<Item>();
            var items = await clientWrapper.GetItems();
            return View(items);
        }
        // POST: Items/Create

        [HttpPost]
        public async Task<ActionResult> Create(Item item)
        {
            var clientWrapper = new HttpClientWrapper<Item>();
            var items = await clientWrapper.Create(item);
            string redirectUrl = "/items";
            return Json(redirectUrl);
            //return RedirectToAction("Index");
            //return PartialView("_table", items);
        }

        public async Task<ActionResult> Update(int id)
        {
            var clientWrapper = new HttpClientWrapper<Item>();
            var item = await clientWrapper.GetItem(id);
            return View(item);
        }

        [HttpPost]
        public async Task<ActionResult> Update(int id, Item item)
        {
            var clientWrapper = new HttpClientWrapper<Item>();
            await clientWrapper.Update(id, item);
            return RedirectToAction("Index");
        }

        [HttpDelete]
        [ActionName("Delete")]
        // DELETE: api/items/id
        public async Task<ActionResult> Delete(int id)
        {
            var clientDeleteWrapper = new HttpClientWrapper<Item>();
            var item = await clientDeleteWrapper.Delete(id);
            //return View(item);
            return Json(true);
        }

        //other methods

        public ActionResult Details(int id)
        {
            var clientWrapper = new HttpClientWrapper<Item>();
            var item = clientWrapper.GetItem(id);
            return View(item);
        }
    }
}