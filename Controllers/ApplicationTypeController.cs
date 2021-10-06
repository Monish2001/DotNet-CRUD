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
    [Route("api/applicationtype")]
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        // [Route("/index")]
        // [HttpGet]
        // public ContentResult Get() { 
        //     return Content("Hello, World! this message is from Home Controller using the Action Result"); 
        // } 

        [HttpGet]  
        publicIEnumerable<string> Get()  
        {  
            returnnewstring[] { "value1", "value2" };  
        } 


        // [Route("api/v{v:apiVersion}/admin/admins")]
        // [HttpGet]
        // public IActionResult Get()
        // public IActionResult Index()
        // {
        //     IEnumerable<ApplicationType> objList = _db.ApplicationType.ToList();
        //     // return View(objList);
        //     return objList;
        // }


        //GET - CREATE
        // public IActionResult Create()
        // {
        //     return View();
        // }


        // POST - CREATE
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Create(ApplicationType obj)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _db.ApplicationType.Add(obj);
        //         _db.SaveChanges();
                // return RedirectToAction("Index");
            // }
            // return View(obj);

        // }


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