using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList;
using WebDuLich.Models;

namespace WebDuLich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminOrdersController : Controller
    {
        private readonly QLDLContext _context;

        public AdminOrdersController(QLDLContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminOrders
    

        public async Task<IActionResult> Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var Orders = _context.Orders.Include(o => o.Cus).Include(o => o.Location).Include(o => o.Transact)
                .AsNoTracking()
                .OrderByDescending(x => x.OrderDate);

            PagedList<Order> models = new PagedList<Order>(Orders, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);


           
        }


        // GET: Admin/AdminOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Cus)
                .Include(o => o.Location)
                .Include(o => o.Transact)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            var Chitietdonhang = _context.Orderdetails
                .Include(x => x.Product)
                .AsNoTracking()
                .Where(x => x.OrderId == order.OrderId)
                .OrderBy(x => x.OrderDetailId)
                .ToList();
            ViewBag.ChiTiet = Chitietdonhang;

           
            return View(order);
        }


        public async Task<IActionResult> ChangeStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            
         
            ViewData["TrangThai"] = new SelectList(_context.Transactstatuses, "TransactId", "Status", order.TransactId);
            return View(order);
        }

      


        // GET: Admin/AdminOrders/Create
        public IActionResult Create()
        {
            ViewData["CusId"] = new SelectList(_context.Customers, "CusId", "CusId");
            ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId");
            ViewData["TransactId"] = new SelectList(_context.Transactstatuses, "TransactId", "TransactId");
            return View();
        }

        // POST: Admin/AdminOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,LocationId,CusId,OrderDate,ShipDate,TransactId,Status,Deteled,Paid,PaymentDate,PaymentId,Note,TotalMoney,Address,District,Ward,NgayDi")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CusId"] = new SelectList(_context.Customers, "CusId", "CusId", order.CusId);
            //ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId", order.LocationId);
            ViewData["TransactId"] = new SelectList(_context.Transactstatuses, "TransactId", "TransactId", order.TransactId);
            return View(order);
        }

        // GET: Admin/AdminOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CusId"] = new SelectList(_context.Customers, "CusId", "CusId", order.CusId);
            //ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId", order.LocationId);
            ViewData["TransactId"] = new SelectList(_context.Transactstatuses, "TransactId", "Status", order.TransactId);
            return View(order);
        }

        // POST: Admin/AdminOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,LocationId,CusId,OrderDate,ShipDate,TransactId,Status,Deteled,Paid,PaymentDate,PaymentId,Note,TotalMoney,Address,District,Ward, NgayDi")] Order order)
        {   
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
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
            ViewData["CusId"] = new SelectList(_context.Customers, "CusId", "CusId", order.CusId);
            //ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId", order.LocationId);
            ViewData["TransactId"] = new SelectList(_context.Transactstatuses, "TransactId", "Status", order.TransactId);
            return View(order);
        }

        // GET: Admin/AdminOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Cus)
                .Include(o => o.Location)
                .Include(o => o.Transact)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Admin/AdminOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
