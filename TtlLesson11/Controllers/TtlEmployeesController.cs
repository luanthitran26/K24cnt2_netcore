
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TtlLesson11.Models;

public class TtlEmployeesController : Controller
{
    private readonly TtlEmployeesLesson11Context _context;

    public TtlEmployeesController(TtlEmployeesLesson11Context context)
    {
        _context = context;
    }

    // GET: TTLEMPLOYEES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.TtlEmployees.ToListAsync());
    }

    // GET: TTLEMPLOYEES/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ttlemployee = await _context.TtlEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ttlemployee == null)
        {
            return NotFound();
        }

        return View(ttlemployee);
    }

    // GET: TTLEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: TTLEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,TtlName,TtlGender,TtlBirthDay,TtlEmail,TtlPhone,TtlActive")] TtlEmployee ttlemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ttlemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ttlemployee);
    }

    // GET: TTLEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ttlemployee = await _context.TtlEmployees.FindAsync(id);
        if (ttlemployee == null)
        {
            return NotFound();
        }
        return View(ttlemployee);
    }

    // POST: TTLEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,TtlName,TtlGender,TtlBirthDay,TtlEmail,TtlPhone,TtlActive")] TtlEmployee ttlemployee)
    {
        if (id != ttlemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ttlemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtlEmployeeExists(ttlemployee.Id))
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
        return View(ttlemployee);
    }

    // GET: TTLEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ttlemployee = await _context.TtlEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ttlemployee == null)
        {
            return NotFound();
        }

        return View(ttlemployee);
    }

    // POST: TTLEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var ttlemployee = await _context.TtlEmployees.FindAsync(id);
        if (ttlemployee != null)
        {
            _context.TtlEmployees.Remove(ttlemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TtlEmployeeExists(long? id)
    {
        return _context.TtlEmployees.Any(e => e.Id == id);
    }
}
