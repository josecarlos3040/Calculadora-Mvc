using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class OperacoesMatematicasController : Controller{

    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult ResultadoSoma([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.resultado = n1 + n2;

        return View();
    }



    public IActionResult Subtrair()
    {
        return View();
    }

        public IActionResult ResultadoSubtrair([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.resultado = n1 - n2;

        return View();
    }



    public IActionResult Mult()
    {
        return View();
    }

        public IActionResult ResultadoMult([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.resultado = n1 * n2;

        return View();
    }




    public IActionResult Divis()
    {
        return View();
    }
    
        public IActionResult ResultadoDivis([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.resultado = n1 / n2;

        return View();
    }


}