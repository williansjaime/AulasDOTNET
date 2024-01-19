using Microsoft.AspNetCore.Mvc;
namespace ASPNetMVC.Controllers;

public class FilmesController : Controller
{
    public IActionResult Index()
    {
        return View();//"Essa é uma string padrão";
    }

    public IActionResult BemVindo(string nome, int id)
    {
        ViewData["Title"] = "Listas de Filmes";
        ViewData["Nome"] = nome;
        ViewData["Numerox"] = id;
        return View();
    } 
    
    
    //=> $"Ola seja muito bem vindo {nome} - {numero}"; 
    
    // public IActionResult index() //interface que retorna o resultrado da ação    
    // {
    //     return View();
    // }

}
