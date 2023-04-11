using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EjercicioPeliculas.Models;
using EjercicioPeliculas.Services;

namespace EjercicioPeliculas.Controllers;

public class MovieController : Controller
{
    public MovieController()
    {
    }

    public IActionResult Index() //Acción ASP que va a tomar el LAYOUT en Shared
    {   
        var model = new List<Movie>();
        model = MovieService.GetAll(); //La variable recibe lo que le manda el servicio, en este caso, un metodo getall que trae todos los datos de la lista dentro de... services? Models? No estoy seguro.

        return View(model);//Devuelve una View de la nueva variable Model
    }

    public IActionResult Detail(string id) //código para entrar al detalle de una pelicula según su ID. No debería ser según su code?
    {
        var model = MovieService.Get(id); //La variable modelo es igual al ID tomado del servicio MovieService

        return View(model);//Devuelve una View de la nueva variable Model
    }

    public IActionResult Create() //acción GET que dirige a la vista de Create donde está el formulario de Create
    {
        return View(); //Manda directamente a la View de Create
    }
    
    [HttpPost] //Esto recibe los datos de la llamada POST del formulario en Create.cshtml
    public IActionResult Create(Movie movie){
        if(!ModelState.IsValid){
            return RedirectToAction("Create");//Esto refresca la página si se escribe algo equivocado, si el modelo es invalido
        }

        MovieService.Add(movie);

        return RedirectToAction("Index");
    }
    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Delete(Movie movie){
        if(!ModelState.IsValid){
            return RedirectToAction("Delete"); 
        }

        MovieService.Delete(movie);

        return RedirectToAction("Index");
    }
}
