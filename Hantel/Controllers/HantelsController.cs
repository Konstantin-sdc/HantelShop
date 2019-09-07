using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HantelShop.Models;

namespace HantelShop.Controllers {
  public class HantelsController : Controller {
    private HantelContext _db = new HantelContext();

    // GET: Hantels
    public async Task<ActionResult> Index() {
      return View(await _db.Cargos.ToListAsync());
    }

    // GET: Hantels/Details/5
    public async Task<ActionResult> Details(int? id) {
      if(id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Hantel hantel = await _db.Cargos.FindAsync(id);
      if(hantel == null) {
        return HttpNotFound();
      }
      return View(hantel);
    }

    // GET: Hantels/Create
    public ActionResult Create() {
      return View();
    }

    // POST: Hantels/Create
    // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
    // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create([Bind(Include = "Id,Weight,Length,LandingDiameter,OverallDiameter,Model,Name,Description,Code")] Hantel hantel) {
      if(ModelState.IsValid) {
        _db.Cargos.Add(hantel);
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
      }

      return View(hantel);
    }

    // GET: Hantels/Edit/5
    public async Task<ActionResult> Edit(int? id) {
      if(id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Hantel hantel = await _db.Cargos.FindAsync(id);
      if(hantel == null) {
        return HttpNotFound();
      }
      return View(hantel);
    }

    // POST: Hantels/Edit/5
    // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
    // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit([Bind(Include = "Id,Weight,Length,LandingDiameter,OverallDiameter,Model,Name,Description,Code")] Hantel hantel) {
      if(ModelState.IsValid) {
        _db.Entry(hantel).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
      }
      return View(hantel);
    }

    // GET: Hantels/Delete/5
    public async Task<ActionResult> Delete(int? id) {
      if(id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Hantel hantel = await _db.Cargos.FindAsync(id);
      if(hantel == null) {
        return HttpNotFound();
      }
      return View(hantel);
    }

    // POST: Hantels/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> DeleteConfirmed(int id) {
      Hantel hantel = await _db.Cargos.FindAsync(id);
      _db.Cargos.Remove(hantel);
      await _db.SaveChangesAsync();
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing) {
      if(disposing) {
        _db.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
