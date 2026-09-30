
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TtlNetCoreLAB06_EF.Models;
using TtlNetCoreLAB06_EF.Data;

public class TtlProductsController : Controller
{
    private readonly TtlProductDbContext _context;

    public TtlProductsController(TtlProductDbContext context)
    {
        _context = context;
    }

    // GET: TTLPRODUCTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.TtlProducts.ToListAsync());
    }

    // GET: TTLPRODUCTS/Details/5
    public async Task<IActionResult> Details(string? ttlid)
    {
        if (ttlid == null)
        {
            return NotFound();
        }

        var ttlproduct = await _context.TtlProducts
            .FirstOrDefaultAsync(m => m.TtlId == ttlid);
        if (ttlproduct == null)
        {
            return NotFound();
        }

        return View(ttlproduct);
    }

    // GET: TTLPRODUCTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: TTLPRODUCTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("TtlId,TtlName,TtlPrice,TtlSalePrice,TtlStatus,TtlCreateDate,TtlImages,TtlCategoryId,TtlDescription")] TtlProduct ttlproduct)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ttlproduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ttlproduct);
    }

    // GET: TTLPRODUCTS/Edit/5
    public async Task<IActionResult> Edit(string? ttlid)
    {
        if (ttlid == null)
        {
            return NotFound();
        }

        var ttlproduct = await _context.TtlProducts.FindAsync(ttlid);
        if (ttlproduct == null)
        {
            return NotFound();
        }
        return View(ttlproduct);
    }

    // POST: TTLPRODUCTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string? ttlid, [Bind("TtlId,TtlName,TtlPrice,TtlSalePrice,TtlStatus,TtlCreateDate,TtlImages,TtlCategoryId,TtlDescription")] TtlProduct ttlproduct)
    {
        if (ttlid != ttlproduct.TtlId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ttlproduct);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtlProductExists(ttlproduct.TtlId))
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
        return View(ttlproduct);
    }

    // GET: TTLPRODUCTS/Delete/5
    public async Task<IActionResult> Delete(string? ttlid)
    {
        if (ttlid == null)
        {
            return NotFound();
        }

        var ttlproduct = await _context.TtlProducts
            .FirstOrDefaultAsync(m => m.TtlId == ttlid);
        if (ttlproduct == null)
        {
            return NotFound();
        }

        return View(ttlproduct);
    }

    // POST: TTLPRODUCTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string? ttlid)
    {
        var ttlproduct = await _context.TtlProducts.FindAsync(ttlid);
        if (ttlproduct != null)
        {
            _context.TtlProducts.Remove(ttlproduct);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TtlProductExists(string? ttlid)
    {
        return _context.TtlProducts.Any(e => e.TtlId == ttlid);
    }
}
