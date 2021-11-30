using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using moduit.Models;

namespace moduit.Controllers
{
    public class ThreeController : ApiController
    {
        private List<ItemHeader> ItemHeaderList = new List<ItemHeader>()
        {
            new ItemHeader {id = 800728, category = 4, createdAt = "2021-06-28T10:59:47.2135292+00:00"}
        };

        private List<Items> ItemList = new List<Items>()
        {
            new Items { id = 800728,
                title = "Incredible Steel Salad",
                description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                footer = "Incredible"
            },
            new Items { id = 800728,
                title = "Practical Frozen Ball",
                description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                footer = "Ergonomic"
            },
            new Items { id = 800728,
                title = "Sleek Cotton Pants",
                description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                footer = "Handmade"
            }
        };

        [Route("backend/question/three")]
        [HttpGet]
        public HttpResponseMessage GetItem()
        {
            var jData = from ih in ItemHeaderList
                        join i in ItemList on ih.id equals i.id
                        select new { ih.id, ih.category, i.title, i.description, i.footer, ih.createdAt };

            return Request.CreateResponse(HttpStatusCode.OK, jData, Configuration.Formatters.JsonFormatter);
        }
    }
}