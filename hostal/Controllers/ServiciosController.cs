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
    public class ServiciosController:Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public ServiciosController(ApplicationDbContext context,  UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var servicios = from o in _context.DataServicios select o;
            return View(await servicios.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            Servicios objServicios = await _context.DataServicios.FindAsync(id);
            if(objServicios == null){
                return NotFound();
            }
            return View(objServicios);
        }

       public async Task<IActionResult> Add(int? id)
        {
            var userID = _userManager.GetUserName(User);
            if(userID == null){
                ViewData["Message"] = "Por favor debe loguearse antes de agregar un servicio";
                List<Servicios> serv = new List<Servicios>();
                return  View("Index",serv);
            }else{
                var servicio = await _context.DataServicios.FindAsync(id);
                Proforma proforma = new Proforma();
                /*proforma.Producto = servicio;*/
                proforma.Precio = servicio.Precio;
                proforma.Quantity = 1;
                proforma.UserID = userID;
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Index));
            }
        }

        }

    }