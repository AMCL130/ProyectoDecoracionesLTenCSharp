using DecoracionesLTv4.Models;
using DecoracionesLTv4.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DecoracionesLTv4.Controllers
{
    public class HomeController : Controller
    {
        private readonly DecoracionesLtContext _dbcontext;

        public HomeController(DecoracionesLtContext context)
        {
            _dbcontext = context;
        }

        [Authorize]

        public IActionResult resumenClientes()
        {
            DateTime FechaInicio= DateTime.Now;
            FechaInicio=FechaInicio.AddDays(-5);

            List<VMCliente> Lista = (from tbcliente in _dbcontext.Clientes
                                     where tbcliente.FechaRegistro.Value.Date >= FechaInicio.Date
                                     group tbcliente by tbcliente.FechaRegistro.Value.Date into grupo
                                     select new VMCliente
                                     {
                                         fecha = grupo.Key.ToString("dd/MM/yyyy"),
                                         cantidad = grupo.Count(),
                                     }).ToList();
            return StatusCode(StatusCodes.Status200OK, Lista);

        }

        //public IActionResult resumenCategorias()
        //{
        //    DateTime FechaInicio = DateTime.Now;
        //    FechaInicio = FechaInicio.AddDays(-5);

        //    List<VMCategoria> Lista = (from tbcategoria in _dbcontext.Categorias
        //                             where tbcategoria.Nombre.ToString >= 
        //                             group tbcategoria by tbcategoria.FechaRegistro.Value.Date into grupo
        //                             select new VMCategoria
        //                             {
        //                                 fecha = grupo.Key.ToString("dd/MM/yyyy"),
        //                                 cantidad = grupo.Count(),
        //                             }).ToList();
        //    return StatusCode(StatusCodes.Status200OK, Lista);

        //}
        public IActionResult resumenCategorias()  //metodo para obtener informacion de los productos mas vendidos
        {

            List<VMCategoria> Lista = (from tbdetalleVenta in _dbcontext.Categorias
                                      group tbdetalleVenta by tbdetalleVenta.Nombre into grupo
                                      orderby grupo.Count() descending
                                      select new VMCategoria
                                      {
                                          fecha = grupo.Key,
                                          cantidad = grupo.Count(),
                                      }).Take(4).ToList();
            return StatusCode(StatusCodes.Status200OK, Lista);
        }




        public IActionResult Index()
        {
            return View();
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