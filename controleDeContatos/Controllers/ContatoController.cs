using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace controleDeContatos.Controllers
{
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        [Route("Contato/Index")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("Contato/Criar")]
        public IActionResult Criar()
        {
            return View();
        }

        [Route("Contato/Editar")]
        public IActionResult Editar()
        {
            return View();
        }

        [Route("Contato/Apagar")]
        public IActionResult Apagar()
        {
            return View();
        }
        
    }
}