using Microsoft.AspNetCore.Mvc;
using IntroViews.Models;


namespace IntroViews.Controllers;


public class CalculadoraController : Controller
{

    public IActionResult Calculadora()
    {
        return View();
    }

    public IActionResult Operacao([FromForm]string operacao, [FromForm]double numero1, [FromForm]double numero2)
    {
        var viewModel = new Calculadora()
        {
            Operacao = operacao,
            Numero1 = numero1,
            Numero2 = numero2,
            Resultado = 0,
            NomeOperacao = ""
        };

        if(viewModel.Operacao == "+")
        {
            viewModel.Resultado = viewModel.Numero1 + viewModel.Numero2;
            viewModel.NomeOperacao = "Soma";
            return View(viewModel);
        }
        else if(viewModel.Operacao == "-")
        {
            viewModel.Resultado = viewModel.Numero1 - viewModel.Numero2;
            viewModel.NomeOperacao = "Subtração";
            return View(viewModel);
        }
        else if(viewModel.Operacao == "*")
        {
            viewModel.Resultado = viewModel.Numero1 * viewModel.Numero2;
            viewModel.NomeOperacao = "Multiplicação";
            return View(viewModel);
        }
        else
        {
            viewModel.Resultado = viewModel.Numero1 / viewModel.Numero2;
            viewModel.NomeOperacao = "Divisão";
            return View(viewModel);
        }
    }

}