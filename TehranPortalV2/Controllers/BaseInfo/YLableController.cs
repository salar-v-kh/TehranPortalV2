//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using PortalWebMVC.Models.DataBaseContex;
//using PortalWebMVC.Models.Entities.Base_info;
//using System.Linq;
//using System.Threading.Tasks;

//namespace PortalWebMVC.Controllers
//{
//    public class YLablesController : Controller
//    {
//        private readonly PortalDBContext _context;

//        public YLablesController(PortalDBContext context)
//        {
//            _context = context;
//        }

//        // GET: YLables
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.TB_YLable.ToListAsync());
//        }

//        // GET: YLables/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var yLable = await _context.TB_YLable
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (yLable == null)
//            {
//                return NotFound();
//            }

//            return View(yLable);
//        }

//        // GET: YLables/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: YLables/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Y_LableCode,YLableStatus")] YLable yLable)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(yLable);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(yLable);
//        }

//        // GET: YLables/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var yLable = await _context.TB_YLable.FindAsync(id);
//            if (yLable == null)
//            {
//                return NotFound();
//            }
//            return View(yLable);
//        }

//        // POST: YLables/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Y_LableCode,YLableStatus")] YLable yLable)
//        {
//            if (id != yLable.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(yLable);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!YLableExists(yLable.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(yLable);
//        }

//        // GET: YLables/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var yLable = await _context.TB_YLable
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (yLable == null)
//            {
//                return NotFound();
//            }

//            return View(yLable);
//        }

//        // POST: YLables/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var yLable = await _context.TB_YLable.FindAsync(id);
//            _context.TB_YLable.Remove(yLable);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool YLableExists(int id)
//        {
//            return _context.TB_YLable.Any(e => e.Id == id);
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using PortalWebMVC.Models.DataBaseContex;
//using PortalWebMVC.Models.Entities.Base_info;
//using System.Linq;
//using System.Threading.Tasks;

//namespace PortalWebMVC.Controllers
//{
//    public class YLablesController : Controller
//    {
//        private readonly PortalDBContext _context;

//        public YLablesController(PortalDBContext context)
//        {
//            _context = context;
//        }

//        // GET: YLables
//        public async Task<IActionResult> Index()
//        {
//            var yLables = await _context.TB_YLable.AsNoTracking().ToListAsync();
//            return View(yLables);
//        }

//        // GET: YLables/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//                return NotFound();

//            var yLable = await _context.TB_YLable.AsNoTracking()
//                .FirstOrDefaultAsync(m => m.Id == id);

//            if (yLable == null)
//                return NotFound();

//            return View(yLable);
//        }

//        // GET: YLables/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: YLables/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Y_LableCode,YLableStatus")] YLable yLable)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Add(yLable);
//                    await _context.SaveChangesAsync();
//                    return RedirectToAction(nameof(Index));
//                }
//                catch (DbUpdateException _)
//                {
//                    ModelState.AddModelError("", "خطایی در ذخیره اطلاعات رخ داد.");
//                }
//            }
//            return View(yLable);
//        }

//        // GET: YLables/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//                return NotFound();

//            var yLable = await _context.TB_YLable.FindAsync(id);
//            if (yLable == null)
//                return NotFound();

//            return View(yLable);
//        }

//        // POST: YLables/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Y_LableCode,YLableStatus")] YLable yLable)
//        {
//            if (id != yLable.Id)
//                return NotFound();

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(yLable);
//                    await _context.SaveChangesAsync();
//                    return RedirectToAction(nameof(Index));
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!YLableExists(yLable.Id))
//                        return NotFound();
//                    throw;
//                }
//                catch (DbUpdateException _)
//                {
//                    ModelState.AddModelError("", "خطایی در به‌روزرسانی اطلاعات رخ داد.");
//                }
//            }
//            return View(yLable);
//        }

//        // GET: YLables/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//                return NotFound();

//            var yLable = await _context.TB_YLable.AsNoTracking()
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (yLable == null)
//                return NotFound();

//            return View(yLable);
//        }

//        // POST: YLables/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var yLable = await _context.TB_YLable.FindAsync(id);
//            if (yLable == null)
//                return NotFound();

//            try
//            {
//                _context.TB_YLable.Remove(yLable);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            catch (DbUpdateException _)
//            {
//                ModelState.AddModelError("", "امکان حذف این رکورد وجود ندارد.");
//                return View(yLable);
//            }
//        }

//        private bool YLableExists(int id)
//        {
//            return _context.TB_YLable.Any(e => e.Id == id);
//        }
//    }
//}


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWebMVC.Models.DataBaseContex;
using PortalWebMVC.Models.Entities.Base_info;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace PortalWebMVC.Controllers
{
    public class YLablesController : Controller
    {
        private readonly PortalDBContext _context;
        private readonly ILogger<YLablesController> _logger;

        public YLablesController(PortalDBContext context, ILogger<YLablesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: YLables
        public async Task<IActionResult> Index()
        {
            var yLables = await _context.TB_YLable.AsNoTracking().ToListAsync();
            return View(yLables);
        }

        // GET: YLables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var yLable = await _context.TB_YLable.AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (yLable == null)
                return NotFound();

            return View(yLable);
        }

        // GET: YLables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: YLables/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Y_LableCode,YLableStatus")] YLable yLable)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(yLable);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError(ex, "خطایی در ذخیره اطلاعات رخ داد.");
                    ModelState.AddModelError("", "خطایی در ذخیره اطلاعات رخ داد.");
                }
            }
            return View(yLable);
        }

        // GET: YLables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var yLable = await _context.TB_YLable.FindAsync(id);
            if (yLable == null)
                return NotFound();

            return View(yLable);
        }

        // POST: YLables/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Y_LableCode,YLableStatus")] YLable yLable)
        {
            if (id != yLable.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yLable);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YLableExists(yLable.Id))
                        return NotFound();
                    throw;
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError(ex, "خطایی در به‌روزرسانی اطلاعات رخ داد.");
                    ModelState.AddModelError("", "خطایی در به‌روزرسانی اطلاعات رخ داد.");
                }
            }
            return View(yLable);
        }

        // GET: YLables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var yLable = await _context.TB_YLable.AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yLable == null)
                return NotFound();

            return View(yLable);
        }

        // POST: YLables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yLable = await _context.TB_YLable.FindAsync(id);
            if (yLable == null)
                return NotFound();

            try
            {
                _context.TB_YLable.Remove(yLable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "امکان حذف این رکورد وجود ندارد.");
                ModelState.AddModelError("", "امکان حذف این رکورد وجود ندارد.");
                return View(yLable);
            }
        }

        private bool YLableExists(int id)
        {
            return _context.TB_YLable.Any(e => e.Id == id);
        }
    }
}
