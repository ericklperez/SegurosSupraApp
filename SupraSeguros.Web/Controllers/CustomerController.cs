using Microsoft.AspNetCore.Mvc;
using SupraSeguros.Web.Models.Api;
using SupraSeguros.Web.Models.View;
using SupraSeguros.Web.Services;

namespace SupraSeguros.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IServiceAsync<Models.Api.Customer> _customerService;

        public CustomerController(IServiceAsync<Models.Api.Customer> customerService)
        {
            _customerService = customerService;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            var customers = await _customerService.ListAllAsync();
            return View(customers.Select(customer => new Models.View.Customer
            {
                Apellido = customer.Apellido,
                ClienteId = customer.ClienteId,
                Direccion = customer.Direccion,
                Email = customer.Email,
                FechaNacimiento = customer.FechaNacimiento,
                Nombre = customer.Nombre,
                NumeroIdentificacion = customer.NumeroIdentificacion,
                Telefono = customer.Telefono,
                TipoIdentificacion = Enum.Parse<TipoIdentificacion>(customer.TipoIdentificacion)
            }).ToList());
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(ParseApiToView(customer));
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Models.View.Customer customer)
        {
            if (ModelState.IsValid)
            {
                await _customerService.AddAsync(ParseViewToApi(customer));
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(ParseApiToView(customer));
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Models.View.Customer customer)
        {
            if (id != customer.ClienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _customerService.UpdateAsync(ParseViewToApi(customer));
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(ParseApiToView(customer));
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid ClienteId)
        {
            var customer = await _customerService.GetByIdAsync(ClienteId);
            if (customer != null)
            {
                await _customerService.DeleteAsync(customer);
            }
            return RedirectToAction(nameof(Index));
        }

        private static Models.View.Customer ParseApiToView(Models.Api.Customer customer)
        {
            return new Models.View.Customer
            {
                Apellido = customer.Apellido,
                ClienteId = customer.ClienteId,
                Direccion = customer.Direccion,
                Email = customer.Email,
                FechaNacimiento = customer.FechaNacimiento,
                Nombre = customer.Nombre,
                NumeroIdentificacion = customer.NumeroIdentificacion,
                Telefono = customer.Telefono,
                TipoIdentificacion = Enum.Parse<TipoIdentificacion>(customer.TipoIdentificacion)
            };
        }

        private static Models.Api.Customer ParseViewToApi(Models.View.Customer customer)
        {
            return new Models.Api.Customer
            {
                Apellido = customer.Apellido,
                ClienteId = customer.ClienteId,
                Direccion = customer.Direccion,
                Email = customer.Email,
                FechaNacimiento = customer.FechaNacimiento,
                Nombre = customer.Nombre,
                NumeroIdentificacion = customer.NumeroIdentificacion,
                Telefono = customer.Telefono,
                TipoIdentificacion = customer.TipoIdentificacion.ToString()
            };
        }
    }
}
