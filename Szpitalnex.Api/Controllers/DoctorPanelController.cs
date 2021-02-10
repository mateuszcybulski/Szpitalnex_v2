using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Szpitalnex.Api.Models;

namespace Szpitalnex.Api.Controllers
{
    public class DoctorPanelController : Controller
    {
        public List<VisitViewModel> Visits = new List<VisitViewModel>()
        {
            new VisitViewModel
            {
                Id = 1,
                Note = "nic",
                ConsultingRoom = 10
            },
            new VisitViewModel
            {
                Id = 2,
                Note = "cos",
                ConsultingRoom = 12
            },
            new VisitViewModel
            {
                Id = 3,
                Note = "nie wiem",
                ConsultingRoom = 13
            }
        };

        public DoctorPanelController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
