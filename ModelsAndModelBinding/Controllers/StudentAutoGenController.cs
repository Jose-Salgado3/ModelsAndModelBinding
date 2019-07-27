using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentAutoGenController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}