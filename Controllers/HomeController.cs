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
        return View("Index");
        
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.Equipos = Equipos.ListEquipos;
        ViewBag.Camiseta = Equipos.ListCamiseta;
        ViewBag.Medias = Equipos.ListMedias;
        ViewBag.Pantalones = Equipos.ListPantalon;
        return View("SelectIndumentaria");
    }
    public IActionResult GuardarIndumentaria(int Equipo,int Media,int Pantalon,int Remera){
if (Equipo == 0 || Media == 0 || Pantalon == 0 || Remera == 0) 
    {
        ViewBag.Error = "Por favor seleccione una opción para cada campo."; 
        return View("SelectIndumentaria");
    }else{
         Indumentaria indumentaria = new Indumentaria(ViewBag.ListCamiseta(Remera),ViewBag.ListPantalon(Pantalon),ViewBag.ListMedias(Media));
         bool Pudo = Equipos.ingresarIndumentaria(Equipos.ListEquipos[Equipo],indumentaria);
         ViewBag.DicEquipos = Equipos.DicEquipos;
         if(Pudo){ViewBag.Error = "Se cargo existosamente.";}else{ViewBag.Error = "No se pudo cargar.";}
      return View("Index");
    }
    }

    }