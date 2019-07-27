  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // When data is posted to Student/Register this action will execute
        [HttpPost]
        public IActionResult Register(IFormCollection data)
        {
            // Validate input ( lots of work)
            // Server-side and client-side

            Student stu = new Student()
            {
                FullName = data["full-name"],
                ProgramOfChoice = data["program"],
                DateOfBirth = Convert.ToDateTime(data["dob"]),
                HomeAddress = data["address"]
            };

            //Add to database
            return View();
        }

        /// <summary>
        /// Registration done with ModelBinding
        /// </summary>
        /// <returns></returns>
        
        [HttpGet]
        public IActionResult RegisterMB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterMB(Student s)
        {
            return View();
        }
    }
}