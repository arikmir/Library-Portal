using LibraryPortal.HttpHelpers;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LibraryPortal.Controllers
{
    public class ItemsController : Controller
    {
        private string BaseUrl = "http://localhost:44327//";

        private Entities db = new Entities();

        public async Task<ActionResult> Index()
        {
            var clientWrapper = new HttpClientWrapper<Item>();
            var items = await clientWrapper.GetItems();
            return View(items);
            //return PartialView("_table", items);

        }
        [HttpGet]
        public async Task<PartialViewResult> Table()
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
        
        // DELETE: api/items/id
        public async Task<ActionResult> Delete(int id)
        {
            var clientDeleteWrapper = new HttpClientWrapper<Item>();
            var item = await clientDeleteWrapper.Delete(id);
            return View(item);
        }

        //other methods

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }
    }
}