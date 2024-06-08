using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nShop.Data.Data;
using nShop.Data.Data.Sklep;
using nShop.PortalWWW.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nShop.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly nShopContext _context;

        public HomeController(ILogger<HomeController> logger, nShopContext context)
        {
            _logger = logger;
            _context = context;
        }

        //w parametrze id jest numer storny, ktory klik, a przy 1 uruchomieniu witryny id wynosi 1
        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.ModelStrony = await _context.Strona.OrderBy(s => s.Pozycja).ToListAsync();

            if (id == null)
                id = 1;

            var item = await _context.Strona.FindAsync(id);

            // Ustawiamy produkty tylko dla strony o ID 1
            if (id == 1)
            {
                ViewBag.ModelProdukt = await _context.Produkt.OrderBy(s => s.Id).ToListAsync();
            }
            else if (id == 2)
            {
                ViewBag.ModelKategoria = await _context.Kategoria.ToListAsync();
            }
            else if (id == 3)
            {
                var koszyk = await _context.Zamowienie
                    .Include(z => z.ElementyZamowienia)
                    .ThenInclude(e => e.Produkt)
                    .FirstOrDefaultAsync(z => z.UzytkownikId == GetCurrentUserId() && z.StatusZamowieniaId == GetCartStatusId());

                if (koszyk == null)
                {
                    koszyk = new Zamowienie
                    {
                        UzytkownikId = GetCurrentUserId(),
                        StatusZamowieniaId = GetCartStatusId(),
                        DataZamowienia = DateTime.Now
                    };
                    _context.Zamowienie.Add(koszyk);
                    await _context.SaveChangesAsync();
                }

                ViewBag.ModelKoszyk = koszyk;
            }
            else
            {
                ViewBag.ModelProdukt = null;
                ViewBag.ModelKategoria = null;
            }

            return View(item);
        }

        private int GetCurrentUserId()
        {
            // Placeholder for getting current user's ID
            // Replace with actual implementation
            return 1;
        }

        private int GetCartStatusId()
        {
            // Placeholder for getting the status ID for a cart
            // Replace with actual implementation
            return 1;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
