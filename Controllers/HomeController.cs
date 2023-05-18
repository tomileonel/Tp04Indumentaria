using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TpIndumentaria.Models;

namespace TpIndumentaria.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.DicEquipos = Equipos.DicEquipos;
        return View();
        
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.Equipos = Equipos.ListEquipos;
        ViewBag.Camiseta = Equipos.ListCamiseta;
        ViewBag.Medias = Equipos.ListMedias;
        ViewBag.Pantalones = Equipos.ListPantalon;
        return View();
    }
    public IActionResult GuardarIndumentaria(string Equipo,int Medias,int Pantalon,int Remera){

         Indumentaria indumentaria = new Indumentaria(Equipos.ListCamiseta[Remera-1],Equipos.ListPantalon[Pantalon-1],Equipos.ListMedias[Medias-1]);
         bool Pudo = Equipos.ingresarIndumentaria(Equipo,indumentaria);
         ViewBag.DicEquipos = Equipos.DicEquipos;
         if(Pudo){ViewBag.Error = "Se cargo existosamente.";}else{ViewBag.Error = "No se pudo cargar.";}
      return View("Index");
    }
    }

    