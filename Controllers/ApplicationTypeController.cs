using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CRUD.Data;
using CRUD.Models;

namespace CRUD.Controllers
{

    // [Authorize(Roles = WC.AdminRole)]
    // [Route("api/[controller]")]
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("api/application-type")]
        public IActionResult Get()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationType.ToArray();
            // return View(objList);
            return Ok(objList);
        }


        // POST - CREATE
        [HttpPost]
        [Route("api/application-type")]
        public IActionResult POST(ApplicationType obj)
        {
            if (ModelState.IsValid)
            {
                _db.ApplicationType.Add(obj);
                _db.SaveChanges();
                string strng = string.Format("Success");
                return Ok(strng);
                // return RedirectToAction("Index");
            }
            string strng1 = string.Format("Failed");
            return NotFound(strng1);
            // return View(obj);

        }


        //GET - EDIT
        // public IActionResult Edit(int? id)
        // {
        //     if (id == null || id == 0)
        //     {
        //         return NotFound();
        //     }
        //     var obj = _db.ApplicationType.Find(id);
        //     if (obj == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(obj);
        // }

        //POST - EDIT
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Edit(ApplicationType obj)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _db.ApplicationType.Update(obj);
        //         _db.SaveChanges();
        //         return RedirectToAction("Index");
        //     }
        //     return View(obj);

        // }

        //GET - DELETE
        // public IActionResult Delete(int? id)
        // {
        //     if (id == null || id == 0)
        //     {
        //         return NotFound();
        //     }
        //     var obj = _db.ApplicationType.Find(id);
        //     if (obj == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(obj);
        // }

        //POST - DELETE
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult DeletePost(int? id)
        // {
        //     var obj = _db.ApplicationType.Find(id);
        //     if (obj == null)
        //     {
        //         return NotFound();
        //     }
        //     _db.ApplicationType.Remove(obj);
        //     _db.SaveChanges();
        //     return RedirectToAction("Index");


        // }

    }
}