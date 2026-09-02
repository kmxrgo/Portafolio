using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto()
            {
                Titulo = "Amazon",
                Descripcion = "E-commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/Amazon.png"
            },
            new Proyecto()
            {
                Titulo = "New York Times",
                Descripcion = "Pagina de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/imagenes/NewYorkTimes.png"
            },
            new Proyecto()
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "/imagenes/Reddit.png"
            },
            new Proyecto()
            {
                Titulo = "Steam",
                Descripcion = "Tienda en linea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "/imagenes/Steam.png"
            },
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
