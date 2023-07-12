using Delivery.Management.MVC.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Management.MVC.Controllers
{
    public class DeliveryAllocationsController : Controller
    {
        private readonly IDeliveryAllocationService _deliveryAllocationRepository;

        public DeliveryAllocationsController(IDeliveryAllocationService deliveryAllocationRepository)
        {
            _deliveryAllocationRepository = deliveryAllocationRepository;
        }

        // GET: DeliveryAllocationsController
        public async Task<ActionResult> Index()
        {
            var model = await _deliveryAllocationRepository.GetDeliveryAllocations();
            return View(model);
        }

        // GET: DeliveryAllocationsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        // GET: DeliveryAllocationsController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: DeliveryAllocationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeliveryAllocationsController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: DeliveryAllocationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeliveryAllocationsController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }

        // POST: DeliveryAllocationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
