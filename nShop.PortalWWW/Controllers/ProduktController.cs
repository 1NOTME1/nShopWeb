﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nShop.Data.Data;

namespace nShop.PortalWWW.Controllers
{
    public class ProduktController : Controller
    {
        private readonly nShopContext _context;

        public ProduktController(nShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produkt = await _context.Produkt
                                        .Include(p => p.Producent)
                                        .Include(p => p.Kategoria)
                                        .Include(p => p.Recenzje)
                                        .ThenInclude(r => r.Uzytkownik)
                                        .FirstOrDefaultAsync(p => p.Id == id);

            if (produkt == null)
            {
                return NotFound();
            }

            return View(produkt);
        }

        [HttpGet("Produkty/ByCategory/{id}")]
        public async Task<IActionResult> ByCategory(int id)
        {
            var produkty = await _context.Produkt
                                         .Include(p => p.Producent)
                                         .Include(p => p.Kategoria)
                                         .Where(p => p.KategoriaId == id)
                                         .ToListAsync();

            if (!produkty.Any())
            {
                return NotFound();
            }

            return View("WyswietlaniePoKategorii", produkty);
        }



        public async Task<IActionResult> Kategorie()
        {
            var kategorie = await _context.Kategoria
                .Include(k => k.Produkty) // Ładowanie produktów dla każdej kategorii
                .ToListAsync();

            return View(kategorie);
        }








    }
}
