using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWebMVC.Models.DataBaseContex;
using PortalWebMVC.Models.Entities.Base_info;
using System.Threading.Tasks;
using PortalWebMVC.Models;
public class BranchesController : Controller
{
    private readonly PortalDBContext _context;

    public BranchesController(PortalDBContext context)
    {
        _context = context;
    }

    // اکشن برای نمایش لیست شعبه‌ها
    public async Task<IActionResult> Index()
    {
        var branches = await _context.TB_Branch.ToListAsync();
        return View(branches);
    }

    // دریافت یک شعبه بر اساس کد شعبه
    public async Task<IActionResult> Details(string code)
    {
        if (code == null)
        {
            return NotFound();
        }

        var branch = await _context.TB_Branch.FindAsync(code);

        if (branch == null)
        {
            return NotFound();
        }

        return View(branch);
    }

    // ایجاد یک شعبه جدید (نمایش فرم ایجاد)
    public IActionResult Create()
    {
        return View();
    }

    // ایجاد یک شعبه جدید (ثبت داده‌ها)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("BRCode,BRName,BRPhone1,BRPhone2,BRPhone3,IP Address")] Branch branch)
    {
        if (ModelState.IsValid)
        {
            _context.Add(branch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(branch);
    }
}

