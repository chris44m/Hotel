using Microsoft.AspNetCore.Mvc;
using hostal.Models;
using hostal.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace hostal.Controllers
{
    public class CatalogoController:Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public CatalogoController(ApplicationDbContext context,  UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            Product objProduct = await _context.DataProducts.FindAsync(id);
            if(objProduct == null){
                return NotFound();
            }
            return View(objProduct);
        }

       public async Task<IActionResult> Add(int? id)
        {
            var userID = _userManager.GetUserName(User);
            if(userID == null){
                ViewData["Message"] = "Por favor debe loguearse antes de realizar una reserva";
                List<Product> productos = new List<Product>();
                return  View("Index",productos);
            }else{
                var producto = await _context.DataProducts.FindAsync(id);
                Proforma proforma = new Proforma();
                proforma.Producto = producto;
                proforma.Precio = producto.Precio;
                proforma.Quantity = 1;
                proforma.UserID = userID;
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Index));
            }
        }

        }

    }