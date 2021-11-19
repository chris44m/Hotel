using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using hostal.Data;
using hostal.Models;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using Rotativa.AspNetCore;

namespace hostal.Controllers
{
    public class ContactController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.DataContactos.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto ya esta registrado";
            //return RedirectToAction(nameof(Index));
            return View();
        }

        
        public IActionResult Edit(int id)
        {
            Contact objContacto = _context.DataContactos.Find(id);
            if(objContacto == null){
                return NotFound();
            }
            return View(objContacto);
        }

        [HttpPost]
        public IActionResult Edit(int id,[Bind("Id,Name,Email,Comment,Phone")] Contact objContacto)
        {
             _context.Update(objContacto);
             _context.SaveChanges();
              ViewData["Message"] = "El contacto ya esta actualizado";
             return View(objContacto);
        }

        public IActionResult Delete(int id)
        {
            Contact objContacto = _context.DataContactos.Find(id);
            _context.DataContactos.Remove(objContacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        /*************************EXPORTAR EXCEL******************************/
        public IActionResult ExportarExcel()
        {
            string excelContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var contacto = _context.DataContactos.AsNoTracking().ToList();
            using (var libro = new ExcelPackage())
            {
                var worksheet = libro.Workbook.Worksheets.Add("contacto");
                worksheet.Cells["A1"].LoadFromCollection(contacto, PrintHeaders: true);
                for (var col = 1; col < contacto.Count + 1; col++)
                {
                    worksheet.Column(col).AutoFit();
                }
                // Agregar formato de tabla
                var tabla = worksheet.Tables.Add(new ExcelAddressBase(fromRow: 1, fromCol: 1, toRow: contacto.Count + 1, toColumn: 2), "contacto");
                tabla.ShowHeader = true;
                tabla.TableStyle = TableStyles.Light6;
                tabla.ShowTotal = true;

                return File(libro.GetAsByteArray(), excelContentType, "contacto.xlsx");
            }
        }
    }
}