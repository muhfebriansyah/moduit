using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using moduit.Models;

namespace moduit.Controllers
{
    public class TwoController : ApiController
    {
        private List<Items> ItemList = new List<Items>()
        {
            new Items { id = 523329,
                title = "Rustic Steel Salad",
                description = "Carbonite web goalkeeper gloves are ergonomically (Ergonomics) designed to give easy fit",
                footer = "Ergonomic",
                createdAt = "2021-06-28T17:56:03.7396771+00:00"
            },
            new Items { id = 523330,
                title = "Incredible Steel Salad",
                description = "Carbonite web goalkeeper gloves are ergonomically (Ergonomics) designed to give easy fit",
                footer = "Incredible",
                createdAt = "2021-06-28T10:59:47.2135292+00:00"
            },
            new Items { id = 523331,
                title = "Practical Frozen Ball",
                description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                footer = "Ergonomic",
                createdAt = "2021-06-28T17:56:03.7396771+00:00"
            },
            new Items { id = 523332,
                title = "Sleek Cotton Pants",
                description = "Carbonite web goalkeeper gloves are ergonomically (Ergonomics) designed to give easy fit",
                footer = "Handmade",
                createdAt = "2021-06-28T17:56:03.7396771+00:00"
            }
        };

        [Route("backend/question/two")]
        [HttpGet]
        public HttpResponseMessage GetItem()
        {
            var jData = ItemList
                .Where(x => x.description.Contains("Ergonomics") || x.title.Contains("Ergonomics"))
                .OrderByDescending(x => x.id)
                .Take(3)
                .ToList();
            return Request.CreateResponse(HttpStatusCode.OK, jData, Configuration.Formatters.JsonFormatter);
        }
    }
}