//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using PortalWebMVC.Models.DataBaseContex;
//using PortalWebMVC.Models.Entities.Base_info;

//namespace TehranPortalV2.Controllers.BaseInfo
//{
//    public class ITLabelesController : Controller
//    {
//        private readonly PortalDBContext _context;

//        public ITLabelesController(PortalDBContext context)
//        {
//            _context = context;
//        }

//        // GET: ITLabeles
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.TB_ITLabele.ToListAsync());
//        }

//        // GET: ITLabeles/Details/5
//        public async Task<IActionResult> Details(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var iTLabele = await _context.TB_ITLabele
//                .FirstOrDefaultAsync(m => m.IT_CodeLable == id);
//            if (iTLabele == null)
//            {
//                return NotFound();
//            }

//            return View(iTLabele);
//        }

//        // GET: ITLabeles/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: ITLabeles/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("IT_CodeLable,ITLableStatus")] ITLabele iTLabele)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(iTLabele);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(iTLabele);
//        }

//        // GET: ITLabeles/Edit/5
//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var iTLabele = await _context.TB_ITLabele.FindAsync(id);
//            if (iTLabele == null)
//            {
//                return NotFound();
//            }
//            return View(iTLabele);
//        }

//        // POST: ITLabeles/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(string id, [Bind("Id,IT_CodeLable,ITLableStatus")] ITLabele iTLabele)
//        {
//            if (id != iTLabele.IT_CodeLable)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(iTLabele);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ITLabeleExists(iTLabele.IT_CodeLable))
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
//            return View(iTLabele);
//        }

//        // GET: ITLabeles/Delete/5
//        public async Task<IActionResult> Delete(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var iTLabele = await _context.TB_ITLabele
//                .FirstOrDefaultAsync(m => m.IT_CodeLable == id);
//            if (iTLabele == null)
//            {
//                return NotFound();
//            }

//            return View(iTLabele);
//        }

//        // POST: ITLabeles/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(string id)
//        {
//            var iTLabele = await _context.TB_ITLabele.FindAsync(id);
//            if (iTLabele != null)
//            {
//                _context.TB_ITLabele.Remove(iTLabele);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ITLabeleExists(string id)
//        {
//            return _context.TB_ITLabele.Any(e => e.IT_CodeLable == id);
//        }
//    }
//}

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWebMVC.Models.DataBaseContex;
using PortalWebMVC.Models.Entities.Base_info;

namespace TehranPortalV2.Controllers.BaseInfo
{
    public class ITLabelesController : Controller
    {
        private readonly PortalDBContext _context;

        public ITLabelesController(PortalDBContext context)
        {
            _context = context;
        }

        // GET: ITLabeles
        public async Task<IActionResult> Index()
        {
            return View(await _context.TB_ITLabele.ToListAsync());
        }

        // GET: ITLabeles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTLabele = await _context.TB_ITLabele
                .FirstOrDefaultAsync(m => m.IT_CodeLable == id);
            if (iTLabele == null)
            {
                return NotFound();
            }

            return View(iTLabele);
        }

        // GET: ITLabeles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ITLabeles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IT_CodeLable, ITLableStatus")] ITLabele iTLabele)
        {
            // بررسی وجود IT_CodeLable در دیتابیس
            var existingLabel = await _context.TB_ITLabele
                .FirstOrDefaultAsync(l => l.IT_CodeLable == iTLabele.IT_CodeLable);

            if (existingLabel != null)
            {
                // اگر IT_CodeLable تکراری است، پیغام خطا داده می‌شود
                ModelState.AddModelError("IT_CodeLable", "این کد لیبل قبلاً در سیستم ثبت شده است.");
            }

            if (ModelState.IsValid)
            {
                _context.Add(iTLabele);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(iTLabele);
        }

        // GET: ITLabeles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTLabele = await _context.TB_ITLabele.FindAsync(id);
            if (iTLabele == null)
            {
                return NotFound();
            }
            return View(iTLabele);
        }

        // POST: ITLabeles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,IT_CodeLable,ITLableStatus")] ITLabele iTLabele)
        {
            if (id != iTLabele.IT_CodeLable)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iTLabele);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ITLabeleExists(iTLabele.IT_CodeLable))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(iTLabele);
        }

        // GET: ITLabeles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTLabele = await _context.TB_ITLabele
                .FirstOrDefaultAsync(m => m.IT_CodeLable == id);
            if (iTLabele == null)
            {
                return NotFound();
            }

            return View(iTLabele);
        }

        // POST: ITLabeles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var iTLabele = await _context.TB_ITLabele.FindAsync(id);
            if (iTLabele != null)
            {
                _context.TB_ITLabele.Remove(iTLabele);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ITLabeleExists(string id)
        {
            return _context.TB_ITLabele.Any(e => e.IT_CodeLable == id);
        }
    }
}
