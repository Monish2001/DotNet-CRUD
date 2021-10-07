using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUD.Data;
using CRUD.Models;

namespace CRUD.Controllers
{

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

                return RedirectToAction("Get");
            }
            string strng1 = string.Format("Failed");
            return NotFound(strng1);
        }

        //POST - EDIT
        [HttpPut]
        [Route("api/application-type/")]
        public IActionResult PUT(int id,ApplicationType obj)
        {
            
            var existingApplicationType = _db.ApplicationType.Where(s => s.id == id)
                                                    .FirstOrDefault<ApplicationType>();

            if (existingApplicationType != null)
            {
                existingApplicationType.name = obj.name;
                
                _db.SaveChanges();
            }
            else
            {
                string strng1 = string.Format("Failed");
                return NotFound(strng1);
            }
            return RedirectToAction("Get");
        }

        
        [HttpDelete]
        [Route("api/application-type/")]
        public IActionResult DELETE(int id)
        {
            var obj = _db.ApplicationType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ApplicationType.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Get");
        }

    }
}