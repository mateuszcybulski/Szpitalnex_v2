using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Szpitalnex.Api.Controllers
{
    public class PatientPanelController : Controller
    {

        public PatientPanelController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
