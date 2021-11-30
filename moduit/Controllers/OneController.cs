using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using moduit.Models;

namespace moduit.Controllers
{
    public class OneController : ApiController
    {
        private List<Items> ItemList = new List<Items>()
        {
            new Items { id = 523329, 
                title = "Rustic Steel Salad", 
                description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                footer = "Ergonomic",
                createdAt = "2021-06-28T17:56:03.7396771+00:00"
            }
        };

        [Route("backend/question/one")]
        [HttpGet]
        public HttpResponseMessage GetItem()
        {
            var jData = ItemList.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, jData, Configuration.Formatters.JsonFormatter);
        }
    }
}