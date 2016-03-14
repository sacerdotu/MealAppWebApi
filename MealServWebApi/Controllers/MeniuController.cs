using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MealServWebApi.Models;

namespace MealServWebApi.Controllers
{
    public class MeniuController : ApiController
    {
        Meniu[] menus = new Meniu[] 
        { 
            new Meniu { Id = 1, Name = "Ciorba perisoare", Category = "Fel1", Price = 1 }, 
            new Meniu { Id = 2, Name = "Pizza", Category = "Fel2", Price = 3.75M }, 
            new Meniu { Id = 3, Name = "Savarina", Category = "Desert", Price = 16.99M } 
        };

        public IEnumerable<Meniu> GetAllMenu()
        {
            return menus;
        }

        public IHttpActionResult GetMenu(int id)
        {
            var menu = menus.FirstOrDefault((p) => p.Id == id);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }
    }
}
