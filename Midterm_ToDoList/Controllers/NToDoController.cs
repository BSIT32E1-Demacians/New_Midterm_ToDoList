//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Midterm_ToDoList.Models;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Midterm_ToDoList.Controllers
//{
//    public class NToDoController : Controller
//    {
//        private readonly NAppDbContext _context;

//        public NToDoController(NAppDbContext context)
//        {
//            _context = context;
//        }

//        // GET: NToDo/Add
//        public IActionResult Add()
//        {
//            return View();
//        }

//        // POST: NToDo/Add
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Add([Bind("Id,Description,Category,Done")] NToDo nToDo)
//        {
//            if (ModelState.IsValid)
//            {
//                nToDo.Done = false;
//                _context.Add(nToDo);
//                _context.SaveChanges();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(nToDo);
//        }

//        // GET: NToDo/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var nToDo = await _context.NToDo.FindAsync(id);
//            if (nToDo == null)
//            {
//                return NotFound();
//            }
//            return View(nToDo);
//        }

//        // POST: NToDo/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Category,Done")] NToDo nToDo)
//        {
//            if (id != nToDo.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(nToDo);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!NToDoExists(nToDo.Id))
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
//            return View(nToDo);
//        }

//        // GET: NToDo/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var nToDo = await _context.NToDo
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (nToDo == null)
//            {
//                return NotFound();
//            }

//            return View(nToDo);
//        }

//        // POST: NToDo/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var nToDo = await _context.NToDo.FindAsync(id);
//            _context.NToDo.Remove(nToDo);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool NToDoExists(int id)
//        {
//            return _context.NToDo.Any(e => e.Id == id);
//        }
//    }
//}
