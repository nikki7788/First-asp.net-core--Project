using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        //DependencyInjection
        private IServiceProvider _serviceProvider;
        public AccountController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Members member)
        {
            //for checking validation in Members class such as required,... that is called data Annotation 
            if (!ModelState.IsValid)
            {
                return View(member);
            }
            //save new informations (member) from user in the database
            using (var db = _serviceProvider.GetRequiredService<ApplicationDbContex>())
            {
                db.Members.Add(member);
                db.SaveChanges();
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var tbl = new Members();
            using (var db=_serviceProvider.GetRequiredService<ApplicationDbContex>())
            {
                tbl = db.Members.Where(m => m.MEmberId == id).SingleOrDefault();

            }


            return View(tbl);
        }

        [HttpPost]
        public IActionResult Edit(Members model)
        {
            using (var db=_serviceProvider.GetRequiredService<ApplicationDbContex>())
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                db.Members.Update(model);
                db.SaveChanges();

            }
            return View();
        }

    }
}